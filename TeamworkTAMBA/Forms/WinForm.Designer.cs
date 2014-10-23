namespace TeamworkTAMBA
{
    partial class WinForm
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
            this.winPicture = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.winPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // deadPicture
            // 
            this.winPicture.Image = global::TeamworkTAMBA.Properties.Resources.WinLabel;
            this.winPicture.Location = new System.Drawing.Point(3, 2);
            this.winPicture.Name = "winPicture";
            this.winPicture.Size = new System.Drawing.Size(759, 490);
            this.winPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winPicture.TabIndex = 0;
            this.winPicture.TabStop = false;
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
            this.Controls.Add(this.winPicture);
            this.Name = "You won!";
            this.Text = "You won! You saved your Private Life";
            ((System.ComponentModel.ISupportInitialize)(this.winPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox winPicture;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
    }
}