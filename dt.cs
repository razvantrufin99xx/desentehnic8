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
namespace desenTehnic48.proiectdesentehnic
{
	/// <summary>
	/// Description of dt.
	/// </summary>
	public class dt
	{
		public List<instrument> instrumentele;
		public List<forma> formele;
		public List<corp> corpurile;
		public List<caracterpixel>caracterepixelate;
		public List<hartie>pagini;
		public List<desene.desen>desene = new List<desene.desen>();
		public List<dosar>dosare;
		public List<material>materiale;
		public List<model>modele;
		public List<perspectiva>perspective;
		public List<plan>planuri;
		public List<proiectie>proiectii;
		public List<sistemdeproiectie>sistemedeproiectie;
		public List<text>texte;
		public List<indicator>indicatoare;
		public List<persoana>autori;
		
		public dt()
		{
			desene.Add(new desene.desen());
		}
	}
}
