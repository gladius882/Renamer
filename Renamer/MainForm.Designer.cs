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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button ChooseFolderButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.ListBox ListBox;
		private System.Windows.Forms.Button RenameAllButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown LeadingZeros;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PatternBox;
		private System.Windows.Forms.Button AddPatternButton;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ChooseFolderButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.ListBox = new System.Windows.Forms.ListBox();
			this.RenameAllButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LeadingZeros = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.PatternBox = new System.Windows.Forms.TextBox();
			this.AddPatternButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SortOrder = new System.Windows.Forms.ComboBox();
			this.SortOrderType = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LeadingZeros)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.Location = new System.Drawing.Point(12, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(452, 22);
			this.textBox1.TabIndex = 0;
			// 
			// ChooseFolderButton
			// 
			this.ChooseFolderButton.Location = new System.Drawing.Point(12, 55);
			this.ChooseFolderButton.Name = "ChooseFolderButton";
			this.ChooseFolderButton.Size = new System.Drawing.Size(99, 23);
			this.ChooseFolderButton.TabIndex = 1;
			this.ChooseFolderButton.Text = "Choose folder";
			this.ChooseFolderButton.UseVisualStyleBackColor = true;
			this.ChooseFolderButton.Click += new System.EventHandler(this.Button1Click);
			// 
			// ListBox
			// 
			this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ListBox.FormattingEnabled = true;
			this.ListBox.ItemHeight = 16;
			this.ListBox.Location = new System.Drawing.Point(12, 86);
			this.ListBox.Name = "ListBox";
			this.ListBox.Size = new System.Drawing.Size(452, 148);
			this.ListBox.TabIndex = 2;
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
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.programToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(474, 24);
			this.menuStrip1.TabIndex = 4;
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
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
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
			this.PatternBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PatternBox.Location = new System.Drawing.Point(11, 247);
			this.PatternBox.Name = "PatternBox";
			this.PatternBox.Size = new System.Drawing.Size(225, 22);
			this.PatternBox.TabIndex = 7;
			// 
			// AddPatternButton
			// 
			this.AddPatternButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AddPatternButton.Location = new System.Drawing.Point(242, 247);
			this.AddPatternButton.Name = "AddPatternButton";
			this.AddPatternButton.Size = new System.Drawing.Size(89, 23);
			this.AddPatternButton.TabIndex = 8;
			this.AddPatternButton.Text = "Add pattern";
			this.AddPatternButton.UseVisualStyleBackColor = true;
			this.AddPatternButton.Click += new System.EventHandler(this.AddPatternButtonClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 289);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Sort order:";
			// 
			// SortOrder
			// 
			this.SortOrder.DisplayMember = "Date";
			this.SortOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SortOrder.FormattingEnabled = true;
			this.SortOrder.Items.AddRange(new object[] {
									"Date",
									"Filename",
									"None"});
			this.SortOrder.Location = new System.Drawing.Point(87, 286);
			this.SortOrder.Name = "SortOrder";
			this.SortOrder.Size = new System.Drawing.Size(121, 21);
			this.SortOrder.TabIndex = 11;
			this.SortOrder.Text = "Date";
			this.SortOrder.ValueMember = "Date";
			// 
			// SortOrderType
			// 
			this.SortOrderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SortOrderType.FormattingEnabled = true;
			this.SortOrderType.Items.AddRange(new object[] {
									"Ascending",
									"Descending"});
			this.SortOrderType.Location = new System.Drawing.Point(214, 286);
			this.SortOrderType.Name = "SortOrderType";
			this.SortOrderType.Size = new System.Drawing.Size(121, 21);
			this.SortOrderType.TabIndex = 12;
			this.SortOrderType.Text = "Descending";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 318);
			this.Controls.Add(this.SortOrderType);
			this.Controls.Add(this.SortOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AddPatternButton);
			this.Controls.Add(this.PatternBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LeadingZeros);
			this.Controls.Add(this.RenameAllButton);
			this.Controls.Add(this.ListBox);
			this.Controls.Add(this.ChooseFolderButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Renamer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LeadingZeros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox SortOrderType;
		private System.Windows.Forms.ComboBox SortOrder;
		private System.Windows.Forms.Label label2;
	}
}
