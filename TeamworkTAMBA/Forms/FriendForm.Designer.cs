namespace TeamworkTAMBA
{
    partial class HostesForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.speach = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerSolvedLabel = new System.Windows.Forms.Label();
            this.playerKnowledgeLabel = new System.Windows.Forms.Label();
            this.bribeBeerCheckbox = new System.Windows.Forms.CheckBox();
            this.beersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(67, 199);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(160, 50);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // speach
            // 
            this.speach.AutoSize = true;
            this.speach.Location = new System.Drawing.Point(28, 135);
            this.speach.Name = "speach";
            this.speach.Size = new System.Drawing.Size(50, 13);
            this.speach.TabIndex = 2;
            this.speach.Text = "Speach";
            this.speach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(13, 13);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(70, 13);
            this.playerHealthLabel.TabIndex = 3;
            this.playerHealthLabel.Text = "Player Health";
            // 
            // playerSolvedLabel
            // 
            this.playerSolvedLabel.AutoSize = true;
            this.playerSolvedLabel.Location = new System.Drawing.Point(13, 59);
            this.playerSolvedLabel.Name = "playerSolvedLabel";
            this.playerSolvedLabel.Size = new System.Drawing.Size(72, 13);
            this.playerSolvedLabel.TabIndex = 4;
            this.playerSolvedLabel.Text = "Player Solved";
            // 
            // playerKnowledgeLabel
            // 
            this.playerKnowledgeLabel.AutoSize = true;
            this.playerKnowledgeLabel.Location = new System.Drawing.Point(13, 36);
            this.playerKnowledgeLabel.Name = "playerKnowledgeLabel";
            this.playerKnowledgeLabel.Size = new System.Drawing.Size(92, 13);
            this.playerKnowledgeLabel.TabIndex = 5;
            this.playerKnowledgeLabel.Text = "Player Knowledge";
            // 
            // bribeBeerCheckbox
            // 
            this.bribeBeerCheckbox.AutoSize = true;
            this.bribeBeerCheckbox.Location = new System.Drawing.Point(31, 168);
            this.bribeBeerCheckbox.Name = "bribeBeerCheckbox";
            this.bribeBeerCheckbox.Size = new System.Drawing.Size(96, 17);
            this.bribeBeerCheckbox.TabIndex = 6;
            this.bribeBeerCheckbox.Text = "Bribe with beer";
            this.bribeBeerCheckbox.UseVisualStyleBackColor = true;
            this.bribeBeerCheckbox.CheckedChanged += new System.EventHandler(this.bribeBeerCheckbox_CheckedChanged);
            // 
            // beersLabel
            // 
            this.beersLabel.AutoSize = true;
            this.beersLabel.Location = new System.Drawing.Point(13, 83);
            this.beersLabel.Name = "beersLabel";
            this.beersLabel.Size = new System.Drawing.Size(71, 13);
            this.beersLabel.TabIndex = 7;
            this.beersLabel.Text = "Players Beers";
            // 
            // FriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.beersLabel);
            this.Controls.Add(this.bribeBeerCheckbox);
            this.Controls.Add(this.playerKnowledgeLabel);
            this.Controls.Add(this.playerSolvedLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.speach);
            this.Controls.Add(this.okButton);
            this.Name = "FriendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FriendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label speach;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label playerSolvedLabel;
        private System.Windows.Forms.Label playerKnowledgeLabel;
        private System.Windows.Forms.CheckBox bribeBeerCheckbox;
        private System.Windows.Forms.Label beersLabel;
    }
}