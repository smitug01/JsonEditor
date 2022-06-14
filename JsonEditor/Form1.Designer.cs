namespace JsonEditor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.filesToolStripMenuItem.Text = "File";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.viewStatusToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.chineseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.languageToolStripMenuItem.Text = "Language";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // chineseToolStripMenuItem
            // 
            this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            this.chineseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.chineseToolStripMenuItem.Text = "Chinese";
            this.chineseToolStripMenuItem.Click += new System.EventHandler(this.chineseToolStripMenuItem_Click);
            // 
            // viewStatusToolStripMenuItem
            // 
            this.viewStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeViewToolStripMenuItem,
            this.textViewToolStripMenuItem});
            this.viewStatusToolStripMenuItem.Name = "viewStatusToolStripMenuItem";
            this.viewStatusToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.viewStatusToolStripMenuItem.Text = "ViewStatus";
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.treeViewToolStripMenuItem.Text = "TreeView";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            // 
            // textViewToolStripMenuItem
            // 
            this.textViewToolStripMenuItem.Name = "textViewToolStripMenuItem";
            this.textViewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.textViewToolStripMenuItem.Text = "TextView";
            this.textViewToolStripMenuItem.Click += new System.EventHandler(this.textViewToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licencesToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.programInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // licencesToolStripMenuItem
            // 
            this.licencesToolStripMenuItem.Name = "licencesToolStripMenuItem";
            this.licencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.licencesToolStripMenuItem.Text = "License";
            this.licencesToolStripMenuItem.Click += new System.EventHandler(this.licencesToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportBugToolStripMenuItem.Text = "Report Bug";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.reportBugToolStripMenuItem_Click);
            // 
            // programInfoToolStripMenuItem
            // 
            this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            this.programInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programInfoToolStripMenuItem.Text = "Program Info";
            this.programInfoToolStripMenuItem.Click += new System.EventHandler(this.programInfoToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(57, 58);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(275, 280);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(508, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(373, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(372, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(372, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Route:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(372, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 129);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(372, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(57, 58);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(632, 280);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 58);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 58);
            this.button4.TabIndex = 13;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(510, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "*main node need = 1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Json Editor (Dev Version)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem viewStatusToolStripMenuItem;
        private ToolStripMenuItem treeViewToolStripMenuItem;
        private ToolStripMenuItem textViewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem licencesToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem reportBugToolStripMenuItem;
        private ToolStripMenuItem programInfoToolStripMenuItem;
        private TreeView treeView1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private RichTextBox richTextBox2;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem chineseToolStripMenuItem;
        private Button button3;
        private Button button4;
        private Label label4;
    }
}