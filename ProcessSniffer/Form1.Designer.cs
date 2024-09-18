namespace ProcessSniffer
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
            label1 = new Label();
            ProcessNameTxt = new TextBox();
            ProcessLoadBtn = new Button();
            TypeCB = new ComboBox();
            label2 = new Label();
            SnifferBtn = new Button();
            checkBox1 = new CheckBox();
            protIDLbl = new Label();
            label4 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            RefreshBtn = new Button();
            menuStrip1 = new MenuStrip();
            configToolStripMenuItem = new ToolStripMenuItem();
            deviceListsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Process Name";
            // 
            // ProcessNameTxt
            // 
            ProcessNameTxt.Location = new Point(98, 33);
            ProcessNameTxt.Name = "ProcessNameTxt";
            ProcessNameTxt.Size = new Size(259, 23);
            ProcessNameTxt.TabIndex = 1;
            // 
            // ProcessLoadBtn
            // 
            ProcessLoadBtn.Location = new Point(10, 318);
            ProcessLoadBtn.Name = "ProcessLoadBtn";
            ProcessLoadBtn.Size = new Size(75, 23);
            ProcessLoadBtn.TabIndex = 2;
            ProcessLoadBtn.Text = "Load";
            ProcessLoadBtn.UseVisualStyleBackColor = true;
            ProcessLoadBtn.Click += ProcessLoadBtn_Click;
            // 
            // TypeCB
            // 
            TypeCB.FormattingEnabled = true;
            TypeCB.Items.AddRange(new object[] { "Select Type", "UDP", "TCP" });
            TypeCB.Location = new Point(50, 269);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(87, 23);
            TypeCB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 272);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // SnifferBtn
            // 
            SnifferBtn.Enabled = false;
            SnifferBtn.Location = new Point(10, 345);
            SnifferBtn.Name = "SnifferBtn";
            SnifferBtn.Size = new Size(96, 23);
            SnifferBtn.TabIndex = 5;
            SnifferBtn.Text = "Start Capture";
            SnifferBtn.UseVisualStyleBackColor = true;
            SnifferBtn.Click += SnifferBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(121, 348);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Color the changes";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // protIDLbl
            // 
            protIDLbl.AutoSize = true;
            protIDLbl.Location = new Point(76, 300);
            protIDLbl.Name = "protIDLbl";
            protIDLbl.Size = new Size(0, 15);
            protIDLbl.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 300);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 59);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 9;
            label3.Text = "or Select from list";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 77);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(346, 184);
            listBox1.TabIndex = 10;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(364, 77);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 11;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { configToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(450, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deviceListsToolStripMenuItem });
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 20);
            configToolStripMenuItem.Text = "Config";
            // 
            // deviceListsToolStripMenuItem
            // 
            deviceListsToolStripMenuItem.Name = "deviceListsToolStripMenuItem";
            deviceListsToolStripMenuItem.Size = new Size(180, 22);
            deviceListsToolStripMenuItem.Text = "Device Lists";
            deviceListsToolStripMenuItem.Click += deviceListsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 382);
            Controls.Add(RefreshBtn);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(protIDLbl);
            Controls.Add(checkBox1);
            Controls.Add(SnifferBtn);
            Controls.Add(label2);
            Controls.Add(TypeCB);
            Controls.Add(ProcessLoadBtn);
            Controls.Add(ProcessNameTxt);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProcessSniffer";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ProcessNameTxt;
        private Button ProcessLoadBtn;
        private ComboBox TypeCB;
        private Label label2;
        private Button SnifferBtn;
        private CheckBox checkBox1;
        private Label protIDLbl;
        private Label label4;
        private Label label3;
        private ListBox listBox1;
        private Button RefreshBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem deviceListsToolStripMenuItem;
    }
}
