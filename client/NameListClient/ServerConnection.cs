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
				try
				{
					var response = await client.GetAsync(string.Format(ENDPOINT_FORMAT, "list"));
					var responseStr = await response.Content.ReadAsStringAsync();
					var result = JsonConvert.DeserializeObject<FetchUserListResult>(responseStr);
					if (result.result)
					{
						userList = new List<User>(result.list);
					}
				}
				catch { return null; }
			}
			return userList;
		}

		/// <summary>
		/// ユーザ登録リクエスト
		/// </summary>
		[JsonObject]
		class InsertUserRequest
		{
			/// <summary>
			/// 名前
			/// </summary>
			[JsonProperty("last_name")]
			public string lastName = "";

			/// <summary>
			/// 苗字
			/// </summary>
			[JsonProperty("first_name")]
			public string firstName = "";
		}

		/// <summary>
		/// 実行結果
		/// </summary>
		class CommandResult
		{
			/// <summary>
			/// 結果
			/// </summary>
			[JsonProperty("result")]
			public bool result = false;
		}

		/// <summary>
		/// ユーザ追加
		/// </summary>
		/// <param name="lastName">名前</param>
		/// <param name="firstName">苗字</param>
		/// <returns>結果</returns>
		public static async Task<bool> InsertUser(string lastName, string firstName)
		{
			bool bResult = false;
			using (var client = new HttpClient())
			{
				InsertUserRequest request = new InsertUserRequest();
				request.lastName = lastName;
				request.firstName = firstName;
				var jsonText = JsonConvert.SerializeObject(request);
				try
				{
					var response = await client.PostAsync(string.Format(ENDPOINT_FORMAT, "insert"), new StringContent(jsonText, Encoding.UTF8, "application/json"));
					var responseStr = await response.Content.ReadAsStringAsync();
					var result = JsonConvert.DeserializeObject<CommandResult>(responseStr);
					bResult = result.result;
				}
				catch { return false; }
			}
			return bResult;
		}
	}
}
