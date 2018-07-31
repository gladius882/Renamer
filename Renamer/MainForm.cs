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
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Renamer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private int currentNum;
		private bool cycleValuesVisible;
		private int cycleValueIndex;
		
		public MainForm()
		{
			InitializeComponent();
			
			cycleValuesVisible = false;
			
			string[] patterns = File.ReadAllLines("patterns.txt");
			foreach(string pattern in patterns) {
				Patterns.Items.Add(pattern);
			}
			
			AutoCompleteStringCollection col = new AutoCompleteStringCollection();
			foreach(string item in File.ReadAllLines(".autocomplete")) {
				col.Add(item);
			}
			FolderPath.AutoCompleteCustomSource = col;
			
			LoadConfiguration();
		}
		
		private void LoadConfiguration()
		{
			try {
				FolderPath.Text = Configuration.Value.GetValue("folder");
			}
			catch {
				FolderPath.Text = "";
			}
			
			try {
				LeadingZeros.Value = int.Parse(Configuration.Value.GetValue("leading-zeros"));
			}
			catch {
				LeadingZeros.Value = 3;
			}
			
			try {
				SortOrder.SelectedIndex = int.Parse(Configuration.Value.GetValue("sort-order"));
			}
			catch {
				SortOrder.SelectedIndex = 0;
			}
			finally {
				SortOrder.Select();
			}
			
			
			try {
				SortOrderType.SelectedIndex = int.Parse(Configuration.Value.GetValue("sort-type"));
			}
				
			catch {
				SortOrderType.SelectedIndex = 0;
			}
			finally {
				SortOrderType.Select();
			}
			
			
			try {
				StartFrom.Value = int.Parse(Configuration.Value.GetValue("start-from"));
			}
			catch {
				StartFrom.Value = 1;
			}
			
			try {
				Step.Value = StartFrom.Value = int.Parse(Configuration.Value.GetValue("step"));
			} catch {
				Step.Value = 1;
			}
			
			
			
		}
		
		void ChooseFolderButtonClick(object sender, EventArgs e)
		{
			folderBrowserDialog.ShowDialog();
			this.FolderPath.Text = folderBrowserDialog.SelectedPath;
		}
		
		private void RenameAllButtonClick(object sender, EventArgs e)
		{
			try {
				CheckData();
			}
			catch {
				return;
			}
		
			cycleValueIndex = 0;
			string directory = FolderPath.Text.Trim();
			AddAutocomplete(directory);
				
			List<FileInfo> files = new List<FileInfo>();
			
			foreach(string fileName in Directory.GetFiles(FolderPath.Text.Trim())) {
				files.Add(new FileInfo(fileName));
			}
			
			string sort = SortOrder.SelectedItem.ToString();
			string sortType = SortOrderType.SelectedItem.ToString();
			currentNum = (int)StartFrom.Value;
			
			files = SortFiles(files, sort,sortType);
			
			foreach(FileInfo file in files) {
				RenameFile(file);
			}
		}
		
		private void AddAutocomplete(string directory)
		{
			List<string> autocomplete = File.ReadAllLines(".autocomplete").ToList();
			if(autocomplete.Contains(directory) == false)
			{
				autocomplete.Add(directory);
				FolderPath.AutoCompleteCustomSource.Add(directory);
			}
			
			File.WriteAllText(".autocomplete", "");
			foreach(string item in autocomplete) {
				File.AppendAllText(".autocomplete", item + Environment.NewLine);
			}
		}
		
		private List<FileInfo> SortFiles(List<FileInfo> files, string order, string type)
		{
			order = order.ToLower().Trim();
			type = type.ToLower().Trim();
			List<FileInfo> res;
			
			switch(order)
			{
					case "creation date" : {
						res = files.OrderBy(f => f.CreationTime).ToList();
						break;
					}
					case "modification date" : {
						res = files.OrderBy(f => f.LastWriteTime).ToList();
						break;
					}
					case "filename" : {
						res = files.OrderBy(f => f.Name).ToList();
						break;
					}
					default : {
						res = files;
						break;
					}
				
			}
			
			if(type == "descending") {
				res.Reverse();
			}
			
			return res;
		}
		
		private void RenameFile(FileInfo file)
		{
			string path = file.FullName;
			string[] oldPath = path.Trim().Split('\\');
			string folderName = oldPath[oldPath.Length-2];
			string extension = path.Split('.')[path.Split('.').Length-1];
			List<string> newPathArr = new List<string>();
			
			for(int i=0; i<oldPath.Length-1; i++) {
				newPathArr.Add(oldPath[i]+"\\");
			}
			
			string pattern = Patterns.SelectedItem.ToString();
			pattern = pattern.Replace("<FolderName>", folderName);
			string number = currentNum.ToString();
			
			if(LeadingZeros.Value != 0) {
				number = currentNum.ToString("D"+LeadingZeros.Value.ToString());
			}
			
			pattern = pattern.Replace("*", number);
			
			if(CycleValues.Text.Trim().Length != 0)
			{
				if(cycleValueIndex >= CycleValues.Lines.Count())
					cycleValueIndex = 0;
				
				pattern = pattern.Replace("<CycleValue>", CycleValues.Lines[cycleValueIndex]);
			}
			
			newPathArr.Add(pattern+"."+extension);
			
			string newPath = "";
			
			foreach(string el in newPathArr) {
				newPath += el;
			}
			
			File.Move(path, newPath);
			
			currentNum += (int)Step.Value;
			cycleValueIndex++;
		}
		
		private void CheckData()
		{
			if(FolderPath.Text.Trim() == String.Empty)
			{
				MessageBox.Show("Directory cannot be empty", "Warning", MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				throw new Exception();
			}
			if(Directory.Exists(FolderPath.Text.Trim()) == false)
			{
				MessageBox.Show("Can't find choosen directory", "Warning", MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				throw new Exception();
			}
			if(Directory.Exists(FolderPath.Text.Trim()) == false)
			{
				MessageBox.Show("", "Error", MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				throw new Exception();
			}
			
			if(Patterns.SelectedIndex == -1)
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
			
			File.AppendAllText("patterns.txt", "\n"+PatternBox.Text.Trim());
			Patterns.Items.Add(PatternBox.Text.Trim());
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		
		void run()
		{
			if(this.InvokeRequired)
			{
				this.Invoke(new MethodInvoker( () => this.Slide() ));
			}
			else {
				this.Slide();
			}
			
		}
		
		void Slide()
		{
			int step = 2;
			if(cycleValuesVisible == true)
			{
				step = -step;
				button1.Text = ">>>";
			}
			else {
				button1.Text = "<<<";
			}
			
			for(int i=0; i<150; i++)
			{
				this.Width += step;
			}
			
			cycleValuesVisible = !cycleValuesVisible;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Task.Run(() => this.run());			
		}
		
		void TextBoxDragEnter(object sender, DragEventArgs e)
		{
			if(e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}
		}
		
		void TextBox2DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			
			if(files != null && files.Length != 0)
			{
				string fileName = files[0];
				CycleValues.Text = "";
				CycleValues.Lines = File.ReadAllLines(fileName);
			}
		}
		
		void TextBox1DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			
			if(files != null && files.Length != 0)
			{
				FolderPath.Text = files[0];
			}
		}
		
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			int selected = Patterns.SelectedIndex;
			
			if(selected != -1) {
				Patterns.Items.RemoveAt(selected);
			}
			
			File.WriteAllText("patterns.txt", "");
			foreach(object item in Patterns.Items)
			{
				File.AppendAllText("patterns.txt", item.ToString() + Environment.NewLine);
			}
		}
		
		void MainFormResizeBegin(object sender, EventArgs e)
		{
			return;
		}
		
		void FolderPathTextChanged(object sender, EventArgs e)
		{
			Configuration.Value.UpdateValue("folder", FolderPath.Text);
			Configuration.Value.Save();
		}
		
		void LeadingZerosValueChanged(object sender, EventArgs e)
		{
			Configuration.Value.UpdateValue("leading-zeros", LeadingZeros.Value.ToString());
			Configuration.Value.Save();
		}
		
		void SortOrderSelectedIndexChanged(object sender, EventArgs e)
		{
			Configuration.Value.UpdateValue("sort-order", SortOrder.SelectedIndex.ToString());
			Configuration.Value.Save();
		}
		
		void SortOrderTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			Configuration.Value.UpdateValue("sort-order", SortOrderType.SelectedIndex.ToString());
			Configuration.Value.Save();
		}
		
		void StartFromValueChanged(object sender, EventArgs e)
		{
			Configuration.Value.UpdateValue("start-from", StartFrom.Value.ToString());
			Configuration.Value.Save();
		}
		
		void StepValueChanged(object sender, EventArgs e)
		{
			Configuration.Value.UpdateValue("step", Step.Value.ToString());
			Configuration.Value.Save();
		}
	}
}
