/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/19/2024
 * Time: 6:30 PM
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
	/// Description of stil.
	/// </summary>
	public class stil
	{
		public Font f;
			public void createFontRef(ref Font pf)
			{
				this.f = pf;
			
			}
			public Color back;
			public Color front;
			
		public stil()
		{
			
		}
	}
}
