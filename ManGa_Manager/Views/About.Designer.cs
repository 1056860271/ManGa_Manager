namespace ManGa_Manager.Views
{
	partial class About
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.name_labe = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.conf_but = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// name_labe
			// 
			this.name_labe.AutoSize = true;
			this.name_labe.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.name_labe.Location = new System.Drawing.Point(12, 9);
			this.name_labe.Name = "name_labe";
			this.name_labe.Size = new System.Drawing.Size(143, 45);
			this.name_labe.TabIndex = 0;
			this.name_labe.Text = "ManGa";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(203, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "作者：XeonY";
			// 
			// conf_but
			// 
			this.conf_but.Location = new System.Drawing.Point(323, 180);
			this.conf_but.Name = "conf_but";
			this.conf_but.Size = new System.Drawing.Size(75, 23);
			this.conf_but.TabIndex = 2;
			this.conf_but.Text = "确认";
			this.conf_but.UseVisualStyleBackColor = true;
			this.conf_but.Click += new System.EventHandler(this.conf_but_Click);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 215);
			this.Controls.Add(this.conf_but);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.name_labe);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label name_labe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button conf_but;
	}
}