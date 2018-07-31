/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-07-31
 * Time: 20:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Renamer
{
	/// <summary>
	/// Description of GuideForm.
	/// </summary>
	public partial class GuideForm : Form
	{
		public GuideForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string curDir = System.IO.Directory.GetCurrentDirectory();
			this.webBrowser1.Url = new Uri(@"file://"+curDir+"/guide/index.html");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
