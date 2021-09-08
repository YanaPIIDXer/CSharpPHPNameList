
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.userList);
			this.Name = "MainForm";
			this.Text = "簡単な名簿システム";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox userList;
	}
}

