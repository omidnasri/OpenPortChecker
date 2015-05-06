namespace OpenPortChecker
{
    partial class MainView
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
            this.lblServer = new System.Windows.Forms.Label();
            this.inputServer = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.inputMethod = new System.Windows.Forms.ComboBox();
            this.lblFirstPort = new System.Windows.Forms.Label();
            this.inputFirstPort = new System.Windows.Forms.TextBox();
            this.lblLastPort = new System.Windows.Forms.Label();
            this.inputLastPort = new System.Windows.Forms.TextBox();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonScanPorts = new System.Windows.Forms.Button();
            this.progressScanning = new System.Windows.Forms.ProgressBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(13, 13);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server";
            // 
            // inputServer
            // 
            this.inputServer.Location = new System.Drawing.Point(57, 10);
            this.inputServer.Name = "inputServer";
            this.inputServer.Size = new System.Drawing.Size(249, 20);
            this.inputServer.TabIndex = 1;
            this.inputServer.TextChanged += new System.EventHandler(this.inputServer_TextChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(13, 42);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(67, 13);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Scanmethod";
            // 
            // inputMethod
            // 
            this.inputMethod.FormattingEnabled = true;
            this.inputMethod.Items.AddRange(new object[] {
            "Single port",
            "Range",
            "All ports"});
            this.inputMethod.Location = new System.Drawing.Point(86, 39);
            this.inputMethod.Name = "inputMethod";
            this.inputMethod.Size = new System.Drawing.Size(220, 21);
            this.inputMethod.TabIndex = 3;
            this.inputMethod.Text = "Single port";
            this.inputMethod.SelectedIndexChanged += new System.EventHandler(this.inputMethod_SelectedIndexChanged);
            // 
            // lblFirstPort
            // 
            this.lblFirstPort.AutoSize = true;
            this.lblFirstPort.Location = new System.Drawing.Point(13, 72);
            this.lblFirstPort.Name = "lblFirstPort";
            this.lblFirstPort.Size = new System.Drawing.Size(26, 13);
            this.lblFirstPort.TabIndex = 4;
            this.lblFirstPort.Text = "Port";
            // 
            // inputFirstPort
            // 
            this.inputFirstPort.Location = new System.Drawing.Point(57, 69);
            this.inputFirstPort.Name = "inputFirstPort";
            this.inputFirstPort.Size = new System.Drawing.Size(52, 20);
            this.inputFirstPort.TabIndex = 5;
            this.inputFirstPort.Text = "80";
            this.inputFirstPort.TextChanged += new System.EventHandler(this.inputFirstPort_TextChanged);
            // 
            // lblLastPort
            // 
            this.lblLastPort.AutoSize = true;
            this.lblLastPort.Location = new System.Drawing.Point(115, 72);
            this.lblLastPort.Name = "lblLastPort";
            this.lblLastPort.Size = new System.Drawing.Size(20, 13);
            this.lblLastPort.TabIndex = 6;
            this.lblLastPort.Text = "To";
            // 
            // inputLastPort
            // 
            this.inputLastPort.Enabled = false;
            this.inputLastPort.Location = new System.Drawing.Point(141, 69);
            this.inputLastPort.Name = "inputLastPort";
            this.inputLastPort.Size = new System.Drawing.Size(52, 20);
            this.inputLastPort.TabIndex = 7;
            this.inputLastPort.TextChanged += new System.EventHandler(this.inputLastPort_TextChanged);
            // 
            // buttonPing
            // 
            this.buttonPing.Enabled = false;
            this.buttonPing.Location = new System.Drawing.Point(199, 67);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(107, 23);
            this.buttonPing.TabIndex = 8;
            this.buttonPing.Text = "Ping Server";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonScanPorts
            // 
            this.buttonScanPorts.Enabled = false;
            this.buttonScanPorts.Location = new System.Drawing.Point(16, 95);
            this.buttonScanPorts.Name = "buttonScanPorts";
            this.buttonScanPorts.Size = new System.Drawing.Size(144, 23);
            this.buttonScanPorts.TabIndex = 9;
            this.buttonScanPorts.Text = "Scan ports";
            this.buttonScanPorts.UseVisualStyleBackColor = true;
            this.buttonScanPorts.Click += new System.EventHandler(this.buttonScanPorts_Click);
            // 
            // progressScanning
            // 
            this.progressScanning.Location = new System.Drawing.Point(16, 124);
            this.progressScanning.Name = "progressScanning";
            this.progressScanning.Size = new System.Drawing.Size(290, 23);
            this.progressScanning.TabIndex = 10;
            this.progressScanning.Click += new System.EventHandler(this.progressScanning_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(166, 95);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel scan";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(323, 160);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.progressScanning);
            this.Controls.Add(this.buttonScanPorts);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.inputLastPort);
            this.Controls.Add(this.lblLastPort);
            this.Controls.Add(this.inputFirstPort);
            this.Controls.Add(this.lblFirstPort);
            this.Controls.Add(this.inputMethod);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.inputServer);
            this.Controls.Add(this.lblServer);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Port Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox inputServer;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox inputMethod;
        private System.Windows.Forms.Label lblFirstPort;
        private System.Windows.Forms.TextBox inputFirstPort;
        private System.Windows.Forms.Label lblLastPort;
        private System.Windows.Forms.TextBox inputLastPort;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonScanPorts;
        private System.Windows.Forms.ProgressBar progressScanning;
        private System.Windows.Forms.Button buttonCancel;

    }
}

