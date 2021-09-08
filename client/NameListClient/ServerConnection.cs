using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
