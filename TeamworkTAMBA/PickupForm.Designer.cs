namespace TeamworkTAMBA
{
    partial class PickupForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.caffeePictureBox = new System.Windows.Forms.PictureBox();
            this.takeNotofication = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caffeePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(61, 198);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "OK";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // caffeePictureBox
            // 
            this.caffeePictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.caffeePictureBox.Image = global::TeamworkTAMBA.Properties.Resources.coffee;
            this.caffeePictureBox.Location = new System.Drawing.Point(89, 22);
            this.caffeePictureBox.Name = "caffeePictureBox";
            this.caffeePictureBox.Size = new System.Drawing.Size(100, 100);
            this.caffeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caffeePictureBox.TabIndex = 2;
            this.caffeePictureBox.TabStop = false;
            // 
            // takeNotofication
            // 
            this.takeNotofication.AutoSize = true;
            this.takeNotofication.Location = new System.Drawing.Point(12, 151);
            this.takeNotofication.Name = "takeNotofication";
            this.takeNotofication.Size = new System.Drawing.Size(64, 13);
            this.takeNotofication.TabIndex = 3;
            this.takeNotofication.Text = "Notofication";
            this.takeNotofication.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PickupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.takeNotofication);
            this.Controls.Add(this.caffeePictureBox);
            this.Controls.Add(this.exitButton);
            this.Name = "PickupForm";
            this.Text = "PickupForm";
            ((System.ComponentModel.ISupportInitialize)(this.caffeePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox caffeePictureBox;
        private System.Windows.Forms.Label takeNotofication;

    }
}