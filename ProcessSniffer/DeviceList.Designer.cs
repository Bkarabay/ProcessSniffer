namespace ProcessSniffer
{
    partial class DeviceList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DeviceListBox = new ListBox();
            SelectDeviceBtn = new Button();
            SuspendLayout();
            // 
            // DeviceListBox
            // 
            DeviceListBox.FormattingEnabled = true;
            DeviceListBox.ItemHeight = 15;
            DeviceListBox.Location = new Point(17, 15);
            DeviceListBox.Name = "DeviceListBox";
            DeviceListBox.Size = new Size(358, 349);
            DeviceListBox.TabIndex = 0;
            // 
            // SelectDeviceBtn
            // 
            SelectDeviceBtn.Enabled = false;
            SelectDeviceBtn.Location = new Point(388, 15);
            SelectDeviceBtn.Name = "SelectDeviceBtn";
            SelectDeviceBtn.Size = new Size(75, 23);
            SelectDeviceBtn.TabIndex = 1;
            SelectDeviceBtn.Text = "OK";
            SelectDeviceBtn.UseVisualStyleBackColor = true;
            SelectDeviceBtn.Click += SelectDeviceBtn_Click;
            // 
            // DeviceList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 389);
            Controls.Add(SelectDeviceBtn);
            Controls.Add(DeviceListBox);
            MaximizeBox = false;
            Name = "DeviceList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeviceList";
            Load += DeviceList_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox DeviceListBox;
        private Button SelectDeviceBtn;
    }
}