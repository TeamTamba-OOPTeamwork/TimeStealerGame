namespace TeamworkTAMBA
{
    partial class DeadForm
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
            this.deadPicture = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // deadPicture
            // 
            this.deadPicture.Image = global::TeamworkTAMBA.Properties.Resources.DeadLabel;
            this.deadPicture.Location = new System.Drawing.Point(3, 2);
            this.deadPicture.Name = "deadPicture";
            this.deadPicture.Size = new System.Drawing.Size(759, 490);
            this.deadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deadPicture.TabIndex = 0;
            this.deadPicture.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(132, 421);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(200, 60);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Go to the Menu";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(462, 421);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 494);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.deadPicture);
            this.Name = "You are DONE!";
            this.Text = "You are DONE!";
            ((System.ComponentModel.ISupportInitialize)(this.deadPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox deadPicture;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
    }
}