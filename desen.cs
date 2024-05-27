/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/19/2024
 * Time: 5:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace desenTehnic48.desene
{
	/// <summary>
	/// Description of desen.
	/// </summary>
	public class desen
	{
			public utile.grafica g = new utile.grafica();
			public int counterofshapes = -1;
			
			public List<forme.shape> shapes = new List<forme.shape>();
			public void redrawallshapes()
			{
				for(int i = 0 ;i < this.shapes.Count ; i++)
				{
					this.shapes[i].draw(ref this.g.g, this,this.shapes[i].TIP);	
				}
			}
			
			public void addShape(float ph, float pw, Color cb, Font pf, Color cf , float px, float py, string ptip )
			{
				counterofshapes++;
				this.shapes.Add(new forme.shape());
				this.shapes[this.counterofshapes].d.h = ph;
				this.shapes[this.counterofshapes].d.w = pw;
				this.shapes[this.counterofshapes].s.back = cb;
				this.shapes[this.counterofshapes].s.f = pf;
				this.shapes[this.counterofshapes].s.front = cf;
				this.shapes[this.counterofshapes].p.x = px;
				this.shapes[this.counterofshapes].p.y = py;
				this.shapes[this.counterofshapes].TIP = ptip;
				this.shapes[this.counterofshapes].draw(ref this.g.g,  this,this.shapes[this.counterofshapes].TIP);
				
			}
			public void redrawallshapes2()
			{
				for(int i = 0 ;i < this.shapes.Count ; i++)
				{
					this.drawThis(ref this.g.g, this, ref this.shapes[i].TIP, shapes[i]);
				}
			}
			public void draw(ref Graphics ppg,ref desen ppd, ref string ptip,  forme.shape sp)
			{
				if(ptip=="CIRCLE")
				{
					drawCIRCLE(ref ppg, ref ppd, ref sp);
				}
				else if(ptip=="RECTANGLE")
				{
					drawRECTANGLE(ref ppg, ref ppd, ref sp);
				}
				else if(ptip=="LINE")
				{
					drawLINE(ref ppg, ref ppd, ref sp);
				}
				else if(ptip=="CLEARSCREEN")
				{
				
				}
				
			}
			
			public void drawThis(ref Graphics ppg, desen ppd, ref string ptip,  forme.shape sp)
			{
				if(ptip=="CIRCLE")
				{
					drawCIRCLE(ref ppg, ref ppd, ref sp);
				}
				else if(ptip=="RECTANGLE")
				{
					drawRECTANGLE(ref ppg, ref ppd, ref sp);
				}
				else if(ptip=="LINE")
				{
					drawLINE(ref ppg, ref ppd, ref sp);
				}
				else if(ptip=="CLEARSCREEN")
				{
				
				}
				
			}
			public void drawRECTANGLE(ref Graphics pg, ref desen ds, ref forme.shape psp)
			{
				pg.DrawRectangle(new Pen(psp.s.back,1),psp.p.x,psp.p.y,psp.d.w,psp.d.h);
			}
			public void drawCIRCLE(ref Graphics pg, ref desen ds, ref forme.shape psp)
			{
				pg.DrawEllipse(new Pen(psp.s.back,1),psp.p.x,psp.p.y,psp.d.w,psp.d.h);
			}
			public void drawLINE(ref Graphics pg, ref desen ds, ref forme.shape psp)
			{
				pg.DrawLine(new Pen(psp.s.back,1),psp.p.x,psp.p.y,psp.d.w,psp.d.h);
			}
			
			
			
			public void clearscreen(Color c)
			{
				this.g.g.Clear(c);
			}
			
		public desen()
		{
		}
	}
}
