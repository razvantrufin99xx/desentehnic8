/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/19/2024
 * Time: 6:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace desenTehnic48.utile
{
	/// <summary>
	/// Description of grafica.
	/// </summary>
	public class grafica
	{
			public Graphics g;
			public Pen p = new Pen(Color.Black,1);
			public Brush b = new SolidBrush(Color.Black);
			public void createGraphicsRef(ref Panel  pp)
			{
				g = pp.CreateGraphics();
				
			}
			public void createGraphics(Panel  pp)
			{
				g = pp.CreateGraphics();
				
			}
			
		public grafica()
		{
			
		}
	}
}
