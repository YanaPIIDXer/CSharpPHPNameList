
namespace NameListClient
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.userList = new System.Windows.Forms.ListBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.insertButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userList
			// 
			this.userList.FormattingEnabled = true;
			this.userList.ItemHeight = 12;
			this.userList.Location = new System.Drawing.Point(40, 24);
			this.userList.Name = "userList";
			this.userList.Size = new System.Drawing.Size(592, 316);
			this.userList.TabIndex = 0;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(162, 374);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(100, 19);
			this.lastNameTextBox.TabIndex = 1;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(335, 374);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(100, 19);
			this.firstNameTextBox.TabIndex = 1;
			// 
			// insertButton
			// 
			this.insertButton.Location = new System.Drawing.Point(487, 374);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(75, 23);
			this.insertButton.TabIndex = 2;
			this.insertButton.Text = "追加";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.insertButton);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.userList);
			this.Name = "MainForm";
			this.Text = "簡単な名簿システム";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox userList;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Button insertButton;
	}
}

