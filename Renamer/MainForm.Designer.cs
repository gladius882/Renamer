/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-11
 * Time: 19:05
 * 
 */
namespace Renamer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox FolderPath;
		private System.Windows.Forms.Button ChooseFolderButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.ListBox Patterns;
		private System.Windows.Forms.Button RenameAllButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.NumericUpDown LeadingZeros;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PatternBox;
		private System.Windows.Forms.Button AddPatternButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.FolderPath = new System.Windows.Forms.TextBox();
			this.ChooseFolderButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.Patterns = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RenameAllButton = new System.Windows.Forms.Button();
			this.LeadingZeros = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.PatternBox = new System.Windows.Forms.TextBox();
			this.AddPatternButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SortOrder = new System.Windows.Forms.ComboBox();
			this.SortOrderType = new System.Windows.Forms.ComboBox();
			this.StartFrom = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.Step = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.CycleValues = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LeadingZeros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StartFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// FolderPath
			// 
			this.FolderPath.AllowDrop = true;
			this.FolderPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.FolderPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.FolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FolderPath.Location = new System.Drawing.Point(12, 27);
			this.FolderPath.Name = "FolderPath";
			this.FolderPath.Size = new System.Drawing.Size(452, 22);
			this.FolderPath.TabIndex = 0;
			this.FolderPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox1DragDrop);
			this.FolderPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxDragEnter);
			// 
			// ChooseFolderButton
			// 
			this.ChooseFolderButton.Location = new System.Drawing.Point(12, 55);
			this.ChooseFolderButton.Name = "ChooseFolderButton";
			this.ChooseFolderButton.Size = new System.Drawing.Size(99, 23);
			this.ChooseFolderButton.TabIndex = 1;
			this.ChooseFolderButton.Text = "Choose folder";
			this.ChooseFolderButton.UseVisualStyleBackColor = true;
			this.ChooseFolderButton.Click += new System.EventHandler(this.ChooseFolderButtonClick);
			// 
			// Patterns
			// 
			this.Patterns.ContextMenuStrip = this.contextMenuStrip1;
			this.Patterns.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Patterns.FormattingEnabled = true;
			this.Patterns.ItemHeight = 18;
			this.Patterns.Location = new System.Drawing.Point(12, 86);
			this.Patterns.Name = "Patterns";
			this.Patterns.Size = new System.Drawing.Size(452, 184);
			this.Patterns.Sorted = true;
			this.Patterns.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItemClick);
			// 
			// RenameAllButton
			// 
			this.RenameAllButton.Location = new System.Drawing.Point(137, 55);
			this.RenameAllButton.Name = "RenameAllButton";
			this.RenameAllButton.Size = new System.Drawing.Size(99, 23);
			this.RenameAllButton.TabIndex = 3;
			this.RenameAllButton.Text = "Rename all";
			this.RenameAllButton.UseVisualStyleBackColor = true;
			this.RenameAllButton.Click += new System.EventHandler(this.RenameAllButtonClick);
			// 
			// LeadingZeros
			// 
			this.LeadingZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LeadingZeros.Location = new System.Drawing.Point(382, 58);
			this.LeadingZeros.Name = "LeadingZeros";
			this.LeadingZeros.Size = new System.Drawing.Size(80, 22);
			this.LeadingZeros.TabIndex = 5;
			this.LeadingZeros.Value = new decimal(new int[] {
									3,
									0,
									0,
									0});
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(278, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Leading zeros:";
			// 
			// PatternBox
			// 
			this.PatternBox.AutoCompleteCustomSource.AddRange(new string[] {
									"<FolderName>"});
			this.PatternBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.PatternBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.PatternBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PatternBox.Location = new System.Drawing.Point(12, 276);
			this.PatternBox.Name = "PatternBox";
			this.PatternBox.Size = new System.Drawing.Size(356, 22);
			this.PatternBox.TabIndex = 7;
			// 
			// AddPatternButton
			// 
			this.AddPatternButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AddPatternButton.Location = new System.Drawing.Point(374, 275);
			this.AddPatternButton.Name = "AddPatternButton";
			this.AddPatternButton.Size = new System.Drawing.Size(89, 23);
			this.AddPatternButton.TabIndex = 8;
			this.AddPatternButton.Text = "Add pattern";
			this.AddPatternButton.UseVisualStyleBackColor = true;
			this.AddPatternButton.Click += new System.EventHandler(this.AddPatternButtonClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 318);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Sort order:";
			// 
			// SortOrder
			// 
			this.SortOrder.DisplayMember = "Date";
			this.SortOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SortOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SortOrder.FormattingEnabled = true;
			this.SortOrder.Items.AddRange(new object[] {
									"Modification Date",
									"Creation Date",
									"Filename",
									"None"});
			this.SortOrder.Location = new System.Drawing.Point(88, 315);
			this.SortOrder.Name = "SortOrder";
			this.SortOrder.Size = new System.Drawing.Size(121, 23);
			this.SortOrder.TabIndex = 11;
			this.SortOrder.Text = "Creation Date";
			this.SortOrder.ValueMember = "Date";
			// 
			// SortOrderType
			// 
			this.SortOrderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SortOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SortOrderType.FormattingEnabled = true;
			this.SortOrderType.Items.AddRange(new object[] {
									"Ascending",
									"Descending"});
			this.SortOrderType.Location = new System.Drawing.Point(215, 315);
			this.SortOrderType.Name = "SortOrderType";
			this.SortOrderType.Size = new System.Drawing.Size(121, 23);
			this.SortOrderType.TabIndex = 12;
			this.SortOrderType.Text = "Descending";
			// 
			// StartFrom
			// 
			this.StartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.StartFrom.Location = new System.Drawing.Point(88, 347);
			this.StartFrom.Maximum = new decimal(new int[] {
									1000000,
									0,
									0,
									0});
			this.StartFrom.Name = "StartFrom";
			this.StartFrom.Size = new System.Drawing.Size(120, 21);
			this.StartFrom.TabIndex = 13;
			this.StartFrom.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(12, 349);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Start from:";
			// 
			// Step
			// 
			this.Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Step.Location = new System.Drawing.Point(257, 347);
			this.Step.Maximum = new decimal(new int[] {
									1000000,
									0,
									0,
									0});
			this.Step.Name = "Step";
			this.Step.Size = new System.Drawing.Size(120, 21);
			this.Step.TabIndex = 15;
			this.Step.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(215, 349);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Step:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Location = new System.Drawing.Point(470, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 345);
			this.button1.TabIndex = 17;
			this.button1.Text = ">>>";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(504, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "Cycle values";
			// 
			// CycleValues
			// 
			this.CycleValues.AllowDrop = true;
			this.CycleValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CycleValues.Location = new System.Drawing.Point(504, 59);
			this.CycleValues.Multiline = true;
			this.CycleValues.Name = "CycleValues";
			this.CycleValues.Size = new System.Drawing.Size(286, 309);
			this.CycleValues.TabIndex = 20;
			this.CycleValues.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox2DragDrop);
			this.CycleValues.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxDragEnter);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.programToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(497, 24);
			this.menuStrip1.TabIndex = 21;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// programToolStripMenuItem
			// 
			this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.programToolStripMenuItem.Name = "programToolStripMenuItem";
			this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.programToolStripMenuItem.Text = "Program";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 378);
			this.Controls.Add(this.CycleValues);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Step);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.StartFrom);
			this.Controls.Add(this.SortOrderType);
			this.Controls.Add(this.SortOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AddPatternButton);
			this.Controls.Add(this.PatternBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LeadingZeros);
			this.Controls.Add(this.RenameAllButton);
			this.Controls.Add(this.Patterns);
			this.Controls.Add(this.ChooseFolderButton);
			this.Controls.Add(this.FolderPath);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Renamer";
			this.ResizeBegin += new System.EventHandler(this.MainFormResizeBegin);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LeadingZeros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StartFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
		private System.Windows.Forms.TextBox CycleValues;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown Step;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown StartFrom;
		private System.Windows.Forms.ComboBox SortOrderType;
		private System.Windows.Forms.ComboBox SortOrder;
		private System.Windows.Forms.Label label2;
	}
}
