/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-11
 * Time: 19:05
 * 
 */
using System;
using System.Windows.Forms;

namespace Renamer
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
