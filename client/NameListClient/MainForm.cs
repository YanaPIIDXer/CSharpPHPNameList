using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameListClient
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			await FetchAndUpdateUserList();
		}

		/// <summary>
		/// サーバからユーザリストを取ってきて表示
		/// </summary>
		private async Task FetchAndUpdateUserList()
		{
			var users = await ServerConnection.FetchUserList();
			userList.DataSource = users;
		}

		private async void insertButton_Click(object sender, EventArgs e)
		{
			bool bResult = await ServerConnection.InsertUser(lastNameTextBox.Text, firstNameTextBox.Text);
			if (!bResult)
			{
				MessageBox.Show("追加に失敗しました。");
				return;
			}

			await FetchAndUpdateUserList();
		}
	}
}
