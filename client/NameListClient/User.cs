using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameListClient
{
	/// <summary>
	/// ユーザクラス
	/// </summary>
	public class User
	{
		/// <summary>
		/// 名前
		/// </summary>
		public string LastName { get { return lastName; } }
		private string lastName = "";

		/// <summary>
		/// 苗字
		/// </summary>
		public string FirstName { get { return firstName; } }
		private string firstName = "";

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="lastName">名前</param>
		/// <param name="firstName">苗字</param>
		public User(string lastName, string firstName)
		{
			this.lastName = lastName;
			this.firstName = firstName;
		}

		/// <summary>
		/// ToString
		/// </summary>
		/// <returns>「苗字 + " " + 名前」のフォーマットで出力</returns>
		public override string ToString()
		{
			return string.Format("{0} {1}", lastName, firstName);
		}
	}
}
