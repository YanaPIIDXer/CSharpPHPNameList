using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace NameListClient
{
	/// <summary>
	/// サーバ接続クラス
	/// </summary>
	public static class ServerConnection
	{
		/// <summary>
		/// エンドポイントのフォーマット
		/// ※string.Formatメソッドに投げるもの
		/// </summary>
		private static readonly string ENDPOINT_FORMAT = "http://localhost/api/{0}.php";

		/// <summary>
		/// ユーザリスト取得結果
		/// </summary>
		[JsonObject]
		class FetchUserListResult
		{
			/// <summary>
			/// 結果
			/// </summary>
			[JsonProperty("result")]
			public bool result = false;

			/// <summary>
			/// ユーザリスト
			/// </summary>
			[JsonProperty("list")]
			public User[] list = null;
		}

		/// <summary>
		/// ユーザリストを取得してくる
		/// </summary>
		/// <returns>ユーザリスト</returns>
		public static async Task<List<User>> FetchUserList()
		{
			List<User> userList = null;
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync(string.Format(ENDPOINT_FORMAT, "list"));
				var responseStr = await response.Content.ReadAsStringAsync();
				FetchUserListResult result = JsonConvert.DeserializeObject<FetchUserListResult>(responseStr);
				if (result.result)
				{
					userList = new List<User>(result.list);
				}
			}
			return userList;
		}
	}
}
