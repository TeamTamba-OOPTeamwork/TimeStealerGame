namespace TeamworkTAMBA
{
    partial class CombatForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.buttonDoIt = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            this.labelPlayersHealth = new System.Windows.Forms.Label();
            this.labelPlayerDmg = new System.Windows.Forms.Label();
            this.labelEnemyHealth = new System.Windows.Forms.Label();
            this.labelEnemyDmg = new System.Windows.Forms.Label();
            this.playerKnowledgeProgressbar = new System.Windows.Forms.ProgressBar();
            this.playerKnowlageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TeamworkTAMBA.Properties.Resources.monster;
            this.pictureBox2.Location = new System.Drawing.Point(500, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamworkTAMBA.Properties.Resources.Player;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "C#";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 243);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Java";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 266);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "HTML";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 289);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(47, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "CSS";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(15, 312);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(76, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "JavaScript";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(15, 335);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(48, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "PHP";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // buttonDoIt
            // 
            this.buttonDoIt.Location = new System.Drawing.Point(177, 313);
            this.buttonDoIt.Name = "buttonDoIt";
            this.buttonDoIt.Size = new System.Drawing.Size(266, 41);
            this.buttonDoIt.TabIndex = 8;
            this.buttonDoIt.Text = "Do it!";
            this.buttonDoIt.UseVisualStyleBackColor = true;
            this.buttonDoIt.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(177, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(266, 145);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 134);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(101, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(500, 134);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 11;
            this.progressBar2.Value = 100;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(177, 163);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(266, 144);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(88, 337);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(83, 17);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.Text = "Use all skills";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(177, 311);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(266, 43);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // labelPlayersHealth
            // 
            this.labelPlayersHealth.AutoSize = true;
            this.labelPlayersHealth.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelPlayersHealth.Location = new System.Drawing.Point(12, 118);
            this.labelPlayersHealth.Name = "labelPlayersHealth";
            this.labelPlayersHealth.Size = new System.Drawing.Size(72, 13);
            this.labelPlayersHealth.TabIndex = 15;
            this.labelPlayersHealth.Text = "PlayersHealth";
            // 
            // labelPlayerDmg
            // 
            this.labelPlayerDmg.AutoSize = true;
            this.labelPlayerDmg.Location = new System.Drawing.Point(12, 204);
            this.labelPlayerDmg.Name = "labelPlayerDmg";
            this.labelPlayerDmg.Size = new System.Drawing.Size(63, 13);
            this.labelPlayerDmg.TabIndex = 16;
            this.labelPlayerDmg.Text = "PlayersDmg";
            // 
            // labelEnemyHealth
            // 
            this.labelEnemyHealth.AutoSize = true;
            this.labelEnemyHealth.Location = new System.Drawing.Point(501, 118);
            this.labelEnemyHealth.Name = "labelEnemyHealth";
            this.labelEnemyHealth.Size = new System.Drawing.Size(70, 13);
            this.labelEnemyHealth.TabIndex = 17;
            this.labelEnemyHealth.Text = "EnemyHealth";
            // 
            // labelEnemyDmg
            // 
            this.labelEnemyDmg.AutoSize = true;
            this.labelEnemyDmg.Location = new System.Drawing.Point(501, 158);
            this.labelEnemyDmg.Name = "labelEnemyDmg";
            this.labelEnemyDmg.Size = new System.Drawing.Size(61, 13);
            this.labelEnemyDmg.TabIndex = 18;
            this.labelEnemyDmg.Text = "EnemyDmg";
            // 
            // playerKnowledgeProgressbar
            // 
            this.playerKnowledgeProgressbar.Location = new System.Drawing.Point(12, 174);
            this.playerKnowledgeProgressbar.Name = "playerKnowledgeProgressbar";
            this.playerKnowledgeProgressbar.Size = new System.Drawing.Size(100, 23);
            this.playerKnowledgeProgressbar.Step = 1;
            this.playerKnowledgeProgressbar.TabIndex = 19;
            // 
            // playerKnowlageLabel
            // 
            this.playerKnowlageLabel.AutoSize = true;
            this.playerKnowlageLabel.Location = new System.Drawing.Point(12, 158);
            this.playerKnowlageLabel.Name = "playerKnowlageLabel";
            this.playerKnowlageLabel.Size = new System.Drawing.Size(86, 13);
            this.playerKnowlageLabel.TabIndex = 20;
            this.playerKnowlageLabel.Text = "Player Knowlage";
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 366);
            this.Controls.Add(this.playerKnowlageLabel);
            this.Controls.Add(this.playerKnowledgeProgressbar);
            this.Controls.Add(this.labelEnemyDmg);
            this.Controls.Add(this.labelEnemyHealth);
            this.Controls.Add(this.labelPlayerDmg);
            this.Controls.Add(this.labelPlayersHealth);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonDoIt);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CombatForm";
            this.Text = "CombatForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button buttonDoIt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label labelPlayersHealth;
        private System.Windows.Forms.Label labelPlayerDmg;
        private System.Windows.Forms.Label labelEnemyHealth;
        private System.Windows.Forms.Label labelEnemyDmg;
        private System.Windows.Forms.ProgressBar playerKnowledgeProgressbar;
        private System.Windows.Forms.Label playerKnowlageLabel;

    }
}