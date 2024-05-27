/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/19/2024
 * Time: 5:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace desenTehnic48
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtposx;
		private System.Windows.Forms.TextBox txtposy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtmousedowny;
		private System.Windows.Forms.TextBox txtmousedownx;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtposx = new System.Windows.Forms.TextBox();
			this.txtposy = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtmousedowny = new System.Windows.Forms.TextBox();
			this.txtmousedownx = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(67, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(900, 556);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseMove);
			// 
			// txtposx
			// 
			this.txtposx.Location = new System.Drawing.Point(1144, 22);
			this.txtposx.Name = "txtposx";
			this.txtposx.Size = new System.Drawing.Size(100, 20);
			this.txtposx.TabIndex = 1;
			// 
			// txtposy
			// 
			this.txtposy.Location = new System.Drawing.Point(1278, 21);
			this.txtposy.Name = "txtposy";
			this.txtposy.Size = new System.Drawing.Size(100, 20);
			this.txtposy.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(981, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mouse Position:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(1118, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "x:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(1250, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "y:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(1250, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "y:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(1118, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "x:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(981, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Mouse Location:";
			// 
			// txtmousedowny
			// 
			this.txtmousedowny.Location = new System.Drawing.Point(1278, 44);
			this.txtmousedowny.Name = "txtmousedowny";
			this.txtmousedowny.Size = new System.Drawing.Size(100, 20);
			this.txtmousedowny.TabIndex = 7;
			// 
			// txtmousedownx
			// 
			this.txtmousedownx.Location = new System.Drawing.Point(1144, 45);
			this.txtmousedownx.Name = "txtmousedownx";
			this.txtmousedownx.Size = new System.Drawing.Size(100, 20);
			this.txtmousedownx.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1390, 829);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtmousedowny);
			this.Controls.Add(this.txtmousedownx);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtposy);
			this.Controls.Add(this.txtposx);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "desenTehnic48";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
