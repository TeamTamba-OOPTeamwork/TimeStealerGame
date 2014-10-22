namespace TeamworkTAMBA.Forms
{
    partial class AlexForm
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
            this.alexSpeach = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alexPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alexPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // alexSpeach
            // 
            this.alexSpeach.Location = new System.Drawing.Point(12, 108);
            this.alexSpeach.Name = "alexSpeach";
            this.alexSpeach.ReadOnly = true;
            this.alexSpeach.Size = new System.Drawing.Size(260, 136);
            this.alexSpeach.TabIndex = 0;
            this.alexSpeach.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alexPictureBox
            // 
            this.alexPictureBox.Image = global::TeamworkTAMBA.Properties.Resources.tedi;
            this.alexPictureBox.Location = new System.Drawing.Point(98, 2);
            this.alexPictureBox.Name = "alexPictureBox";
            this.alexPictureBox.Size = new System.Drawing.Size(100, 100);
            this.alexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alexPictureBox.TabIndex = 2;
            this.alexPictureBox.TabStop = false;
            // 
            // AlexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.alexPictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alexSpeach);
            this.Name = "AlexForm";
            this.Text = "AlexForm";
            ((System.ComponentModel.ISupportInitialize)(this.alexPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox alexSpeach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox alexPictureBox;

    }
}