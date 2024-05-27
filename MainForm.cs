/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/19/2024
 * Time: 5:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace desenTehnic48
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public proiectdesentehnic.dt desenultehnic = new proiectdesentehnic.dt();
		void MainFormLoad(object sender, EventArgs e)
		{
			this.desenultehnic.desene[0].g.createGraphicsRef(ref this.panel1);
			
		}
		void Panel1MouseMove(object sender, MouseEventArgs e)
		{
			txtposx.Text = e.X.ToString();
			txtposy.Text = e.Y.ToString();
		}
		void Panel1MouseDown(object sender, MouseEventArgs e)
		{
			txtmousedownx.Text = e.X.ToString();
			txtmousedowny.Text = e.Y.ToString();
		}
	}
}
