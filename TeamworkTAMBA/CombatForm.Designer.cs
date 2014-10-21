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
            this.CSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.javaCheckBox = new System.Windows.Forms.CheckBox();
            this.htmlCheckBox = new System.Windows.Forms.CheckBox();
            this.cssCheckBox = new System.Windows.Forms.CheckBox();
            this.javascriptCheckBox = new System.Windows.Forms.CheckBox();
            this.phpCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonDoIt = new System.Windows.Forms.Button();
            this.playerTextBox = new System.Windows.Forms.RichTextBox();
            this.playerHealthProgressBar = new System.Windows.Forms.ProgressBar();
            this.enemyHealthProgressBar = new System.Windows.Forms.ProgressBar();
            this.EnemyTextBox = new System.Windows.Forms.RichTextBox();
            this.checkAllBox = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            this.labelPlayersTime = new System.Windows.Forms.Label();
            this.labelPlayerDmg = new System.Windows.Forms.Label();
            this.labelEnemyHealth = new System.Windows.Forms.Label();
            this.labelEnemyDmg = new System.Windows.Forms.Label();
            this.playerKnowledgeProgressbar = new System.Windows.Forms.ProgressBar();
            this.labelPlayerKnowlage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
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
            // CSharpCheckBox
            // 
            this.CSharpCheckBox.AutoSize = true;
            this.CSharpCheckBox.Checked = true;
            this.CSharpCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CSharpCheckBox.Location = new System.Drawing.Point(15, 220);
            this.CSharpCheckBox.Name = "CSharpCheckBox";
            this.CSharpCheckBox.Size = new System.Drawing.Size(40, 17);
            this.CSharpCheckBox.TabIndex = 2;
            this.CSharpCheckBox.Text = "C#";
            this.CSharpCheckBox.UseVisualStyleBackColor = true;
            this.CSharpCheckBox.CheckedChanged += new System.EventHandler(this.CSharpCheckBox_CheckedChanged);
            // 
            // javaCheckBox
            // 
            this.javaCheckBox.AutoSize = true;
            this.javaCheckBox.Location = new System.Drawing.Point(15, 243);
            this.javaCheckBox.Name = "javaCheckBox";
            this.javaCheckBox.Size = new System.Drawing.Size(49, 17);
            this.javaCheckBox.TabIndex = 3;
            this.javaCheckBox.Text = "Java";
            this.javaCheckBox.UseVisualStyleBackColor = true;
            this.javaCheckBox.CheckedChanged += new System.EventHandler(this.javaCheckBox_CheckedChanged);
            // 
            // htmlCheckBox
            // 
            this.htmlCheckBox.AutoSize = true;
            this.htmlCheckBox.Location = new System.Drawing.Point(15, 266);
            this.htmlCheckBox.Name = "htmlCheckBox";
            this.htmlCheckBox.Size = new System.Drawing.Size(56, 17);
            this.htmlCheckBox.TabIndex = 4;
            this.htmlCheckBox.Text = "HTML";
            this.htmlCheckBox.UseVisualStyleBackColor = true;
            this.htmlCheckBox.CheckedChanged += new System.EventHandler(this.htmlCheckBox_CheckedChanged);
            // 
            // cssCheckBox
            // 
            this.cssCheckBox.AutoSize = true;
            this.cssCheckBox.Location = new System.Drawing.Point(15, 289);
            this.cssCheckBox.Name = "cssCheckBox";
            this.cssCheckBox.Size = new System.Drawing.Size(47, 17);
            this.cssCheckBox.TabIndex = 5;
            this.cssCheckBox.Text = "CSS";
            this.cssCheckBox.UseVisualStyleBackColor = true;
            this.cssCheckBox.CheckedChanged += new System.EventHandler(this.cssCheckBox_CheckedChanged);
            // 
            // javascriptCheckBox
            // 
            this.javascriptCheckBox.AutoSize = true;
            this.javascriptCheckBox.Location = new System.Drawing.Point(15, 312);
            this.javascriptCheckBox.Name = "javascriptCheckBox";
            this.javascriptCheckBox.Size = new System.Drawing.Size(76, 17);
            this.javascriptCheckBox.TabIndex = 6;
            this.javascriptCheckBox.Text = "JavaScript";
            this.javascriptCheckBox.UseVisualStyleBackColor = true;
            this.javascriptCheckBox.CheckedChanged += new System.EventHandler(this.javascriptCheckBox_CheckedChanged);
            // 
            // phpCheckBox
            // 
            this.phpCheckBox.AutoSize = true;
            this.phpCheckBox.Location = new System.Drawing.Point(15, 335);
            this.phpCheckBox.Name = "phpCheckBox";
            this.phpCheckBox.Size = new System.Drawing.Size(48, 17);
            this.phpCheckBox.TabIndex = 7;
            this.phpCheckBox.Text = "PHP";
            this.phpCheckBox.UseVisualStyleBackColor = true;
            this.phpCheckBox.CheckedChanged += new System.EventHandler(this.phpCheckBox_CheckedChanged);
            // 
            // buttonDoIt
            // 
            this.buttonDoIt.Location = new System.Drawing.Point(177, 313);
            this.buttonDoIt.Name = "buttonDoIt";
            this.buttonDoIt.Size = new System.Drawing.Size(266, 41);
            this.buttonDoIt.TabIndex = 8;
            this.buttonDoIt.Text = "Do it!";
            this.buttonDoIt.UseVisualStyleBackColor = true;
            this.buttonDoIt.Click += new System.EventHandler(this.buttonDoIt_Click);
            // 
            // playerTextBox
            // 
            this.playerTextBox.Location = new System.Drawing.Point(177, 12);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.ReadOnly = true;
            this.playerTextBox.Size = new System.Drawing.Size(266, 145);
            this.playerTextBox.TabIndex = 9;
            this.playerTextBox.Text = "";
            this.playerTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // playerHealthProgressBar
            // 
            this.playerHealthProgressBar.Location = new System.Drawing.Point(12, 134);
            this.playerHealthProgressBar.Name = "playerHealthProgressBar";
            this.playerHealthProgressBar.Size = new System.Drawing.Size(101, 23);
            this.playerHealthProgressBar.Step = 1;
            this.playerHealthProgressBar.TabIndex = 10;
            this.playerHealthProgressBar.Value = 100;
            // 
            // enemyHealthProgressBar
            // 
            this.enemyHealthProgressBar.Location = new System.Drawing.Point(500, 134);
            this.enemyHealthProgressBar.Name = "enemyHealthProgressBar";
            this.enemyHealthProgressBar.Size = new System.Drawing.Size(100, 23);
            this.enemyHealthProgressBar.Step = 1;
            this.enemyHealthProgressBar.TabIndex = 11;
            this.enemyHealthProgressBar.Value = 100;
            // 
            // EnemyTextBox
            // 
            this.EnemyTextBox.Location = new System.Drawing.Point(177, 163);
            this.EnemyTextBox.Name = "EnemyTextBox";
            this.EnemyTextBox.ReadOnly = true;
            this.EnemyTextBox.Size = new System.Drawing.Size(266, 144);
            this.EnemyTextBox.TabIndex = 12;
            this.EnemyTextBox.Text = "";
            // 
            // checkAllBox
            // 
            this.checkAllBox.AutoSize = true;
            this.checkAllBox.Location = new System.Drawing.Point(88, 337);
            this.checkAllBox.Name = "checkAllBox";
            this.checkAllBox.Size = new System.Drawing.Size(83, 17);
            this.checkAllBox.TabIndex = 13;
            this.checkAllBox.Text = "Use all skills";
            this.checkAllBox.UseVisualStyleBackColor = true;
            this.checkAllBox.CheckedChanged += new System.EventHandler(this.checkAllBox_CheckedChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(177, 313);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(266, 43);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // labelPlayersTime
            // 
            this.labelPlayersTime.AutoSize = true;
            this.labelPlayersTime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelPlayersTime.Location = new System.Drawing.Point(12, 118);
            this.labelPlayersTime.Name = "labelPlayersTime";
            this.labelPlayersTime.Size = new System.Drawing.Size(64, 13);
            this.labelPlayersTime.TabIndex = 15;
            this.labelPlayersTime.Text = "PlayersTime";
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
            // labelPlayerKnowlage
            // 
            this.labelPlayerKnowlage.AutoSize = true;
            this.labelPlayerKnowlage.Location = new System.Drawing.Point(12, 158);
            this.labelPlayerKnowlage.Name = "labelPlayerKnowlage";
            this.labelPlayerKnowlage.Size = new System.Drawing.Size(86, 13);
            this.labelPlayerKnowlage.TabIndex = 20;
            this.labelPlayerKnowlage.Text = "Player Knowlage";
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 366);
            this.Controls.Add(this.labelPlayerKnowlage);
            this.Controls.Add(this.playerKnowledgeProgressbar);
            this.Controls.Add(this.labelEnemyDmg);
            this.Controls.Add(this.labelEnemyHealth);
            this.Controls.Add(this.labelPlayerDmg);
            this.Controls.Add(this.labelPlayersTime);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.checkAllBox);
            this.Controls.Add(this.EnemyTextBox);
            this.Controls.Add(this.enemyHealthProgressBar);
            this.Controls.Add(this.playerHealthProgressBar);
            this.Controls.Add(this.playerTextBox);
            this.Controls.Add(this.buttonDoIt);
            this.Controls.Add(this.phpCheckBox);
            this.Controls.Add(this.javascriptCheckBox);
            this.Controls.Add(this.cssCheckBox);
            this.Controls.Add(this.htmlCheckBox);
            this.Controls.Add(this.javaCheckBox);
            this.Controls.Add(this.CSharpCheckBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CombatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CombatForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox CSharpCheckBox;
        private System.Windows.Forms.CheckBox javaCheckBox;
        private System.Windows.Forms.CheckBox htmlCheckBox;
        private System.Windows.Forms.CheckBox cssCheckBox;
        private System.Windows.Forms.CheckBox javascriptCheckBox;
        private System.Windows.Forms.CheckBox phpCheckBox;
        private System.Windows.Forms.Button buttonDoIt;
        private System.Windows.Forms.RichTextBox playerTextBox;
        private System.Windows.Forms.ProgressBar playerHealthProgressBar;
        private System.Windows.Forms.ProgressBar enemyHealthProgressBar;
        private System.Windows.Forms.RichTextBox EnemyTextBox;
        private System.Windows.Forms.CheckBox checkAllBox;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label labelPlayersTime;
        private System.Windows.Forms.Label labelPlayerDmg;
        private System.Windows.Forms.Label labelEnemyHealth;
        private System.Windows.Forms.Label labelEnemyDmg;
        private System.Windows.Forms.ProgressBar playerKnowledgeProgressbar;
        private System.Windows.Forms.Label labelPlayerKnowlage;

    }
}