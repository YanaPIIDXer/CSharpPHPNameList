using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NameListClient
{
	/// <summary>
	/// ユーザクラス
	/// </summary>
	[JsonObject]
	public class User
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// 名前
		/// </summary>
		[JsonProperty("last_name")]
		public string LastName { get; set; }

		/// <summary>
		/// 苗字
		/// </summary>
		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		/// <summary>
		/// ToString
		/// </summary>
		/// <returns>「苗字 + " " + 名前」のフォーマットで出力</returns>
		public override string ToString()
		{
			return string.Format("{0} {1}", LastName, FirstName);
		}
	}
}
