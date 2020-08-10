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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSaveItemButton
            // 
            this.uxSaveItemButton.Location = new System.Drawing.Point(0, 43);
            this.uxSaveItemButton.Name = "uxSaveItemButton";
            this.uxSaveItemButton.Size = new System.Drawing.Size(143, 29);
            this.uxSaveItemButton.TabIndex = 0;
            this.uxSaveItemButton.Text = "Save Item";
            this.uxSaveItemButton.UseVisualStyleBackColor = true;
            this.uxSaveItemButton.Click += new System.EventHandler(this.uxSaveItemButton_Click);
            // 
            // uxSavePathLinkLabel
            // 
            this.uxSavePathLinkLabel.AutoSize = true;
            this.uxSavePathLinkLabel.Location = new System.Drawing.Point(0, 20);
            this.uxSavePathLinkLabel.Name = "uxSavePathLinkLabel";
            this.uxSavePathLinkLabel.Size = new System.Drawing.Size(145, 20);
            this.uxSavePathLinkLabel.TabIndex = 3;
            this.uxSavePathLinkLabel.TabStop = true;
            this.uxSavePathLinkLabel.Text = "uxSavePathLinkLabel";
            this.uxSavePathLinkLabel.Click += new System.EventHandler(this.uxSavePathLinkLabel_Click);
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
            this.uxBonusesPathLinkLabel.Location = new System.Drawing.Point(12, 29);
            this.uxBonusesPathLinkLabel.Name = "uxBonusesPathLinkLabel";
            this.uxBonusesPathLinkLabel.Size = new System.Drawing.Size(168, 20);
            this.uxBonusesPathLinkLabel.TabIndex = 5;
            this.uxBonusesPathLinkLabel.TabStop = true;
            this.uxBonusesPathLinkLabel.Text = "uxBonusesPathLinkLabel";
            this.uxBonusesPathLinkLabel.Click += new System.EventHandler(this.uxBonusesPathLinkLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Save path:";
            // 
            // uxImportItemButton
            // 
            this.uxImportItemButton.Location = new System.Drawing.Point(0, 43);
            this.uxImportItemButton.Name = "uxImportItemButton";
            this.uxImportItemButton.Size = new System.Drawing.Size(143, 30);
            this.uxImportItemButton.TabIndex = 7;
            this.uxImportItemButton.Text = "Import Item";
            this.uxImportItemButton.UseVisualStyleBackColor = true;
            this.uxImportItemButton.Click += new System.EventHandler(this.uxImportItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chatlog path:";
            // 
            // uxChatLogPathLinkLabel
            // 
            this.uxChatLogPathLinkLabel.AutoSize = true;
            this.uxChatLogPathLinkLabel.Location = new System.Drawing.Point(0, 20);
            this.uxChatLogPathLinkLabel.Name = "uxChatLogPathLinkLabel";
            this.uxChatLogPathLinkLabel.Size = new System.Drawing.Size(169, 20);
            this.uxChatLogPathLinkLabel.TabIndex = 10;
            this.uxChatLogPathLinkLabel.TabStop = true;
            this.uxChatLogPathLinkLabel.Text = "uxChatLogPathLinkLabel";
            this.uxChatLogPathLinkLabel.Click += new System.EventHandler(this.uxChatLogPathLinkLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uxImportItemButton);
            this.panel1.Controls.Add(this.uxChatLogPathLinkLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 84);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uxSaveItemButton);
            this.panel2.Controls.Add(this.uxSavePathLinkLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 84);
            this.panel2.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1127, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uxBonusesPathLinkLabel);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Item Formatter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

