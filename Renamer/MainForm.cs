/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-11
 * Time: 19:05
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Renamer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private int currentNum;
		
		public MainForm()
		{
			currentNum = 1;
			InitializeComponent();
			
			string[] patterns = File.ReadAllLines("patterns.txt");
			foreach(string pattern in patterns)
			{
				ListBox.Items.Add(pattern);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			folderBrowserDialog.ShowDialog();
			this.textBox1.Text = folderBrowserDialog.SelectedPath;
		}
		
		private void RenameAllButtonClick(object sender, EventArgs e)
		{
			try {
				CheckData();
			}
			catch(Exception ex) {
				return;
			}
			
			string[] files = Directory.GetFiles(textBox1.Text.Trim());
			
			foreach(string file in files)
			{
				RenameFile(file);
			}
			
			currentNum = 1;
		}
		
		private void RenameFile(string path)
		{
			string[] oldPath = path.Trim().Split('\\');
			string folderName = oldPath[oldPath.Length-2];
			string extension = path.Split('.')[path.Split('.').Length-1];
			List<string> newPathArr = new List<string>();
			
			for(int i=0; i<oldPath.Length-1; i++)
			{
				newPathArr.Add(oldPath[i]+"\\");
			}
			
			string pattern = ListBox.SelectedItem.ToString();
			pattern = pattern.Replace("[FolderName]", folderName);
			string number = currentNum.ToString();
			
			if(LeadingZeros.Value != 0)
			{
				number = currentNum.ToString("D"+LeadingZeros.Value.ToString());
			}
			
			pattern = pattern.Replace("$", number);
			newPathArr.Add(pattern+"."+extension);
			
			string newPath = "";
			
			foreach(string el in newPathArr)
			{
				newPath += el;
			}
			
			File.Move(path, newPath);
			
			currentNum++;
		}
		
		private void CheckData()
		{
			if(textBox1.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Can't find choosen directory", "Warning", MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				throw new Exception();
			}
			
			if(Directory.Exists(textBox1.Text.Trim()) == false)
			{
				MessageBox.Show("", "Error", MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				throw new Exception();
			}
			
			if(ListBox.SelectedIndex == -1)
			{
				MessageBox.Show("First naming pattern must be selected", "Warning", MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				throw new Exception();
			}
			
			if(LeadingZeros.Value < 0)
			{
				MessageBox.Show("Num of leading zeros must be higer or equal 0", "Warning", MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				
				throw new Exception();
			}
		}
		void AddPatternButtonClick(object sender, EventArgs e)
		{
			if(PatternBox.Text.Trim() == String.Empty)
			{
				MessageBox.Show("First please enter valid pattern", "Warning", MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				return;
			}
			
			File.AppendAllLines("patterns.txt", new string[] {PatternBox.Text.Trim()});
			ListBox.Items.Add(PatternBox.Text.Trim());
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
