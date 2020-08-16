namespace ItemFormatter
{
    partial class Main
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
            this.uxSaveItemButton = new System.Windows.Forms.Button();
            this.uxSavePathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.uxBonusesPathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.uxImportItemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uxChatLogPathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.uxBonusesPathButton = new System.Windows.Forms.Button();
            this.uxSavePathButton = new System.Windows.Forms.Button();
            this.uxChatLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSaveItemButton
            // 
            this.uxSaveItemButton.Location = new System.Drawing.Point(12, 261);
            this.uxSaveItemButton.Name = "uxSaveItemButton";
            this.uxSaveItemButton.Size = new System.Drawing.Size(206, 29);
            this.uxSaveItemButton.TabIndex = 0;
            this.uxSaveItemButton.Text = "Save Item from Clipboard";
            this.uxSaveItemButton.UseVisualStyleBackColor = true;
            this.uxSaveItemButton.Click += new System.EventHandler(this.uxSaveItemButton_Click);
            // 
            // uxSavePathLinkLabel
            // 
            this.uxSavePathLinkLabel.AutoSize = true;
            this.uxSavePathLinkLabel.Location = new System.Drawing.Point(54, 166);
            this.uxSavePathLinkLabel.Name = "uxSavePathLinkLabel";
            this.uxSavePathLinkLabel.Size = new System.Drawing.Size(145, 20);
            this.uxSavePathLinkLabel.TabIndex = 3;
            this.uxSavePathLinkLabel.TabStop = true;
            this.uxSavePathLinkLabel.Text = "uxSavePathLinkLabel";
            this.uxSavePathLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxSavePathLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOKI bonuses.xml:";
            // 
            // uxBonusesPathLinkLabel
            // 
            this.uxBonusesPathLinkLabel.AutoSize = true;
            this.uxBonusesPathLinkLabel.Location = new System.Drawing.Point(54, 36);
            this.uxBonusesPathLinkLabel.Name = "uxBonusesPathLinkLabel";
            this.uxBonusesPathLinkLabel.Size = new System.Drawing.Size(168, 20);
            this.uxBonusesPathLinkLabel.TabIndex = 5;
            this.uxBonusesPathLinkLabel.TabStop = true;
            this.uxBonusesPathLinkLabel.Text = "uxBonusesPathLinkLabel";
            this.uxBonusesPathLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxBonusesPathLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Save path:";
            // 
            // uxImportItemButton
            // 
            this.uxImportItemButton.Location = new System.Drawing.Point(12, 225);
            this.uxImportItemButton.Name = "uxImportItemButton";
            this.uxImportItemButton.Size = new System.Drawing.Size(201, 30);
            this.uxImportItemButton.TabIndex = 7;
            this.uxImportItemButton.Text = "Import Item from ChatLog";
            this.uxImportItemButton.UseVisualStyleBackColor = true;
            this.uxImportItemButton.Click += new System.EventHandler(this.uxImportItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chatlog path:";
            // 
            // uxChatLogPathLinkLabel
            // 
            this.uxChatLogPathLinkLabel.AutoSize = true;
            this.uxChatLogPathLinkLabel.Location = new System.Drawing.Point(54, 101);
            this.uxChatLogPathLinkLabel.Name = "uxChatLogPathLinkLabel";
            this.uxChatLogPathLinkLabel.Size = new System.Drawing.Size(169, 20);
            this.uxChatLogPathLinkLabel.TabIndex = 10;
            this.uxChatLogPathLinkLabel.TabStop = true;
            this.uxChatLogPathLinkLabel.Text = "uxChatLogPathLinkLabel";
            this.uxChatLogPathLinkLabel.Click += new System.EventHandler(this.uxChatLogPathLinkLabel_Click);
            // 
            // uxBonusesPathButton
            // 
            this.uxBonusesPathButton.Location = new System.Drawing.Point(12, 32);
            this.uxBonusesPathButton.Name = "uxBonusesPathButton";
            this.uxBonusesPathButton.Size = new System.Drawing.Size(36, 29);
            this.uxBonusesPathButton.TabIndex = 13;
            this.uxBonusesPathButton.Text = "...";
            this.uxBonusesPathButton.UseVisualStyleBackColor = true;
            this.uxBonusesPathButton.Click += new System.EventHandler(this.uxBonusesPathButton_Click);
            // 
            // uxSavePathButton
            // 
            this.uxSavePathButton.Location = new System.Drawing.Point(12, 162);
            this.uxSavePathButton.Name = "uxSavePathButton";
            this.uxSavePathButton.Size = new System.Drawing.Size(36, 29);
            this.uxSavePathButton.TabIndex = 13;
            this.uxSavePathButton.Text = "...";
            this.uxSavePathButton.UseVisualStyleBackColor = true;
            this.uxSavePathButton.Click += new System.EventHandler(this.uxSavePathButton_Click);
            // 
            // uxChatLogButton
            // 
            this.uxChatLogButton.Location = new System.Drawing.Point(12, 97);
            this.uxChatLogButton.Name = "uxChatLogButton";
            this.uxChatLogButton.Size = new System.Drawing.Size(36, 29);
            this.uxChatLogButton.TabIndex = 13;
            this.uxChatLogButton.Text = "...";
            this.uxChatLogButton.UseVisualStyleBackColor = true;
            this.uxChatLogButton.Click += new System.EventHandler(this.uxChatLogButton_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(810, 303);
            this.Controls.Add(this.uxImportItemButton);
            this.Controls.Add(this.uxChatLogButton);
            this.Controls.Add(this.uxChatLogPathLinkLabel);
            this.Controls.Add(this.uxSaveItemButton);
            this.Controls.Add(this.uxSavePathButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxSavePathLinkLabel);
            this.Controls.Add(this.uxBonusesPathButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxBonusesPathLinkLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Item Formatter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSaveItemButton;
        private System.Windows.Forms.LinkLabel uxSavePathLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel uxBonusesPathLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxImportItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel uxChatLogPathLinkLabel;
        private System.Windows.Forms.Button uxBonusesPathButton;
        private System.Windows.Forms.Button uxSavePathButton;
        private System.Windows.Forms.Button uxChatLogButton;
    }
}

