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

		private void userList_SelectedIndexChanged(object sender, EventArgs e)
		{
			userPanel.Enabled = (userList.SelectedIndex > 0);
			if (!userPanel.Enabled) { return; }
			User user = userList.SelectedItem as User;
			updateLastNameTextBox.Text = user.LastName;
			updateFirstNameTextBox.Text = user.FirstName;
		}

		private async void updateButton_Click(object sender, EventArgs e)
		{
			User user = userList.SelectedItem as User;
			bool bResult = await ServerConnection.UpdateUser(user.Id, updateLastNameTextBox.Text, updateFirstNameTextBox.Text);
			if (!bResult)
			{
				MessageBox.Show("更新に失敗しました。");
				return;
			}

			await FetchAndUpdateUserList();
		}
	}
}
