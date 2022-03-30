namespace WinForms_SideThread
{
    partial class ThreadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Main = new System.Windows.Forms.TextBox();
            this.textBox_Subline = new System.Windows.Forms.TextBox();
            this.checkBox_Turn = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(578, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.saveasToolStripMenuItem.Text = "Сохранить как...";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.saveasToolStripMenuItem_Click);
            // 
            // textBox_Main
            // 
            this.textBox_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Main.Location = new System.Drawing.Point(12, 30);
            this.textBox_Main.Multiline = true;
            this.textBox_Main.Name = "textBox_Main";
            this.textBox_Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Main.Size = new System.Drawing.Size(554, 323);
            this.textBox_Main.TabIndex = 2;
            // 
            // textBox_Subline
            // 
            this.textBox_Subline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Subline.Location = new System.Drawing.Point(12, 359);
            this.textBox_Subline.Name = "textBox_Subline";
            this.textBox_Subline.Size = new System.Drawing.Size(554, 23);
            this.textBox_Subline.TabIndex = 3;
            // 
            // checkBox_Turn
            // 
            this.checkBox_Turn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Turn.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Turn.BackColor = System.Drawing.Color.LimeGreen;
            this.checkBox_Turn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Turn.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.checkBox_Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Turn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Turn.Location = new System.Drawing.Point(12, 388);
            this.checkBox_Turn.Name = "checkBox_Turn";
            this.checkBox_Turn.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Turn.Size = new System.Drawing.Size(554, 50);
            this.checkBox_Turn.TabIndex = 5;
            this.checkBox_Turn.Text = "Start/Stop";
            this.checkBox_Turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Turn.UseVisualStyleBackColor = false;
            this.checkBox_Turn.CheckedChanged += new System.EventHandler(this.checkBox_Turn_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files|*.txt";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "result.txt";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // ThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.checkBox_Turn);
            this.Controls.Add(this.textBox_Subline);
            this.Controls.Add(this.textBox_Main);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ThreadForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveasToolStripMenuItem;
        private TextBox textBox_Main;
        private TextBox textBox_Subline;
        private CheckBox checkBox_Turn;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}