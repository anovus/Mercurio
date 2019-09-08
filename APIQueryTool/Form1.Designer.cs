namespace APIQueryTool
{
    partial class Mercurio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mercurio));
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InvokeButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.headersBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.responseBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.authenticationToggle = new System.Windows.Forms.CheckBox();
            this.payloadBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mediaTypeSelection = new System.Windows.Forms.ComboBox();
            this.uriBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(26, 360);
            this.responseBox.Margin = new System.Windows.Forms.Padding(6);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(743, 166);
            this.responseBox.TabIndex = 1;
            this.responseBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 532);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Response Body:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InvokeButton
            // 
            this.InvokeButton.Location = new System.Drawing.Point(161, 35);
            this.InvokeButton.Margin = new System.Windows.Forms.Padding(6);
            this.InvokeButton.Name = "InvokeButton";
            this.InvokeButton.Size = new System.Drawing.Size(92, 26);
            this.InvokeButton.TabIndex = 4;
            this.InvokeButton.Text = "GET";
            this.InvokeButton.UseVisualStyleBackColor = true;
            this.InvokeButton.Click += new System.EventHandler(this.InvokeButton_Click);
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(64, 35);
            this.postButton.Margin = new System.Windows.Forms.Padding(6);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(85, 26);
            this.postButton.TabIndex = 5;
            this.postButton.Text = "POST";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // headersBox
            // 
            this.headersBox.Location = new System.Drawing.Point(26, 144);
            this.headersBox.Margin = new System.Windows.Forms.Padding(6);
            this.headersBox.Name = "headersBox";
            this.headersBox.Size = new System.Drawing.Size(355, 179);
            this.headersBox.TabIndex = 6;
            this.headersBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Request Headers here on separate lines:";
            // 
            // responseBody
            // 
            this.responseBody.Location = new System.Drawing.Point(26, 551);
            this.responseBody.Margin = new System.Windows.Forms.Padding(6);
            this.responseBody.Name = "responseBody";
            this.responseBody.Size = new System.Drawing.Size(743, 245);
            this.responseBody.TabIndex = 8;
            this.responseBody.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Response Headers:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "User:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(426, 61);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(346, 20);
            this.passwordBox.TabIndex = 14;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(426, 35);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(346, 20);
            this.userBox.TabIndex = 15;
            // 
            // authenticationToggle
            // 
            this.authenticationToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authenticationToggle.AutoSize = true;
            this.authenticationToggle.Location = new System.Drawing.Point(426, 87);
            this.authenticationToggle.Name = "authenticationToggle";
            this.authenticationToggle.Size = new System.Drawing.Size(116, 17);
            this.authenticationToggle.TabIndex = 16;
            this.authenticationToggle.Text = "Use Authentication";
            this.authenticationToggle.UseVisualStyleBackColor = true;
            this.authenticationToggle.CheckedChanged += new System.EventHandler(this.authenticationToggle_CheckedChanged);
            // 
            // payloadBox
            // 
            this.payloadBox.Location = new System.Drawing.Point(426, 144);
            this.payloadBox.Name = "payloadBox";
            this.payloadBox.Size = new System.Drawing.Size(346, 150);
            this.payloadBox.TabIndex = 17;
            this.payloadBox.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Enter json payload here:";
            // 
            // mediaTypeSelection
            // 
            this.mediaTypeSelection.FormattingEnabled = true;
            this.mediaTypeSelection.Items.AddRange(new object[] {
            "application/json",
            "application/x-www-form-urlencoded"});
            this.mediaTypeSelection.Location = new System.Drawing.Point(531, 302);
            this.mediaTypeSelection.Name = "mediaTypeSelection";
            this.mediaTypeSelection.Size = new System.Drawing.Size(238, 21);
            this.mediaTypeSelection.TabIndex = 19;
            this.mediaTypeSelection.Text = "application/json";
            // 
            // uriBox2
            // 
            this.uriBox2.Location = new System.Drawing.Point(64, 6);
            this.uriBox2.Name = "uriBox2";
            this.uriBox2.Size = new System.Drawing.Size(708, 20);
            this.uriBox2.TabIndex = 20;
            // 
            // Mercurio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 811);
            this.Controls.Add(this.uriBox2);
            this.Controls.Add(this.mediaTypeSelection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.payloadBox);
            this.Controls.Add(this.authenticationToggle);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.responseBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headersBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.InvokeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.responseBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(800, 850);
            this.MinimumSize = new System.Drawing.Size(800, 850);
            this.Name = "Mercurio";
            this.Text = "Mercurio - HTTP Messaging Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InvokeButton;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.RichTextBox headersBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox responseBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.CheckBox authenticationToggle;
        private System.Windows.Forms.RichTextBox payloadBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox mediaTypeSelection;
        private System.Windows.Forms.TextBox uriBox2;
    }
}

