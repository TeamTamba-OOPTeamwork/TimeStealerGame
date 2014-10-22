namespace TeamworkTAMBA
{
    partial class MainMenuForm
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
            this.startBtn = new System.Windows.Forms.Button();
            this.storyBtn = new System.Windows.Forms.Button();
            this.hotToPlayBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(212, 270);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(184, 38);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // storyBtn
            // 
            this.storyBtn.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storyBtn.Location = new System.Drawing.Point(212, 323);
            this.storyBtn.Name = "storyBtn";
            this.storyBtn.Size = new System.Drawing.Size(184, 38);
            this.storyBtn.TabIndex = 1;
            this.storyBtn.Text = "Story";
            this.storyBtn.UseVisualStyleBackColor = true;
            this.storyBtn.Click += new System.EventHandler(this.storyBtn_Click);
            // 
            // hotToPlayBtn
            // 
            this.hotToPlayBtn.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotToPlayBtn.Location = new System.Drawing.Point(212, 377);
            this.hotToPlayBtn.Name = "hotToPlayBtn";
            this.hotToPlayBtn.Size = new System.Drawing.Size(184, 38);
            this.hotToPlayBtn.TabIndex = 2;
            this.hotToPlayBtn.Text = "How to play";
            this.hotToPlayBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(212, 432);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 38);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.hotToPlayBtn);
            this.Controls.Add(this.storyBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button storyBtn;
        private System.Windows.Forms.Button hotToPlayBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}