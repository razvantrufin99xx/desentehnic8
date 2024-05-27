/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/18/2024
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace shapesDrawings
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
		public class positions
		{
			public float x;
			public float y;
		}
		public class stil
		{
			public Font f;
			public void createFontRef(ref Font pf)
			{
				this.f = pf;
			
			}
			public Color back;
			public Color front;
		}
		public class grafica
		{
			public Graphics g;
			public Pen p = new Pen(Color.Black,1);
			public Brush b = new SolidBrush(Color.Black);
			public void createGraphicsRef(ref Panel  pp)
			{
				g = pp.CreateGraphics();
				
			}
		}
		public class pair
		{
			public float a;
			public float b;
		}
		public class dimensions
		{
			public float w;
			public float h;
		}
		public class shape
		{
			public string TIP = "SHAPE";
			public dimensions d = new dimensions();
			public stil s = new stil();
			public positions p = new positions();
			public List<pair> shapedots = new List<pair>();
			public void draw(ref Graphics pg,ref desen pd, string tip)
			{
				pd.draw(ref pg, ref pd,ref tip, this);
			}
			public void draw(ref Graphics pg,desen pd, string tip)
			{
				pd.draw(ref pg, ref pd,ref tip, this);
			}
			
			
		}
		public class desen
		{
			public grafica g = new grafica();
			public int counterofshapes = -1;
			
			public List<shape> shapes = new List<shape>();
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
				this.shapes.Add(new shape());
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
			public void draw(ref Graphics ppg,ref desen ppd, ref string ptip,  shape sp)
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
			
			public void drawThis(ref Graphics ppg, desen ppd, ref string ptip,  shape sp)
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
			public void drawRECTANGLE(ref Graphics pg, ref desen ds, ref shape psp)
			{
				pg.DrawRectangle(new Pen(psp.s.back,1),psp.p.x,psp.p.y,psp.d.w,psp.d.h);
			}
			public void drawCIRCLE(ref Graphics pg, ref desen ds, ref shape psp)
			{
				pg.DrawEllipse(new Pen(psp.s.back,1),psp.p.x,psp.p.y,psp.d.w,psp.d.h);
			}
			public void drawLINE(ref Graphics pg, ref desen ds, ref shape psp)
			{
				pg.DrawLine(new Pen(psp.s.back,1),psp.p.x,psp.p.y,psp.d.w,psp.d.h);
			}
			
			
			
			public void clearscreen(Color c)
			{
				this.g.g.Clear(c);
			}
		}
		
		public desen D = new desen();
		void MainFormLoad(object sender, EventArgs e)
		{
			D.g.createGraphicsRef(ref this.panel1);
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			//RECTANGLE
			D.counterofshapes++;
			D.shapes.Add(new shape());
			D.shapes[D.counterofshapes].d.h = 150;
			D.shapes[D.counterofshapes].d.w = 150;
			D.shapes[D.counterofshapes].s.back = Color.Red;
			D.shapes[D.counterofshapes].s.f = this.Font;
			D.shapes[D.counterofshapes].s.front = Color.Blue;
			D.shapes[D.counterofshapes].p.x = 100;
			D.shapes[D.counterofshapes].p.y = 100;
			D.shapes[D.counterofshapes].TIP = "RECTANGLE";
			D.shapes[D.counterofshapes].draw(ref D.g.g, ref D,D.shapes[D.counterofshapes].TIP);
		}
		void Button4Click(object sender, EventArgs e)
		{
			D.clearscreen(this.BackColor);
		}
		void Button2Click(object sender, EventArgs e)
		{
			//CIRCLE
			D.counterofshapes++;
			D.shapes.Add(new shape());
			D.shapes[D.counterofshapes].d.h = 150;
			D.shapes[D.counterofshapes].d.w = 150;
			D.shapes[D.counterofshapes].s.back = Color.Red;
			D.shapes[D.counterofshapes].s.f = this.Font;
			D.shapes[D.counterofshapes].s.front = Color.Blue;
			D.shapes[D.counterofshapes].p.x = 100;
			D.shapes[D.counterofshapes].p.y = 100;
			D.shapes[D.counterofshapes].TIP = "CIRCLE";
			D.shapes[D.counterofshapes].draw(ref D.g.g, ref D,D.shapes[D.counterofshapes].TIP);
		}
		void Button3Click(object sender, EventArgs e)
		{
			//LINE
			D.counterofshapes++;
			D.shapes.Add(new shape());
			D.shapes[D.counterofshapes].d.h = 150;
			D.shapes[D.counterofshapes].d.w = 150;
			D.shapes[D.counterofshapes].s.back = Color.Red;
			D.shapes[D.counterofshapes].s.f = this.Font;
			D.shapes[D.counterofshapes].s.front = Color.Blue;
			D.shapes[D.counterofshapes].p.x = 100;
			D.shapes[D.counterofshapes].p.y = 100;
			D.shapes[D.counterofshapes].TIP = "LINE";
			D.shapes[D.counterofshapes].draw(ref D.g.g, ref D,D.shapes[D.counterofshapes].TIP);
		}
		void Button5Click(object sender, EventArgs e)
		{
			//redrawall
			D.redrawallshapes();
		}
		void Button6Click(object sender, EventArgs e)
		{
			D.addShape(250,150,Color.Red, this.Font, Color.Blue, 256,100,"CIRCLE");
		}
		void Button7Click(object sender, EventArgs e)
		{
			
			float ph =0;//= float.Parse(this.txth.Text);
			float pw =0;//= float.Parse(this.txtw.Text);
			Color pbc =Color.Black;//= Color.Red;
			Font pfn = this.Font;//= this.Font;
			Color pfc = Color.Red;;// = Color.Blue;
			float px = 0;// = float.Parse(this.txtx.Text);
			float py= 0;// = float.Parse(this.txty.Text);
			string ptip = "SHAPE" ;//= this.txttip.Text.ToUpper();
			
			try {
			 ph = float.Parse(this.txth.Text);
			 pw = float.Parse(this.txtw.Text);
			 pbc = Color.Red;
			 pfn = this.Font;
			 pfc = Color.Blue;
			 px = float.Parse(this.txtx.Text);
			 py = float.Parse(this.txty.Text);
			 ptip = this.txttip.Text.ToUpper();
			} catch  {
				
				
			}
			
			
			try{
		
				D.addShape(ph,pw,pbc, pfn, pfc , px,py ,ptip);
		
			}
			catch{}
		}
		void Panel1MouseDown(object sender, MouseEventArgs e)
		{
			txtx.Text = e.X.ToString();
			txty.Text = e.Y.ToString();
		}
		
		
	}
}

 */
