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
            this.takeNotofication = new System.Windows.Forms.Label();
            this.shopCoffee = new System.Windows.Forms.CheckBox();
            this.shopCola = new System.Windows.Forms.CheckBox();
            this.shopRedbul = new System.Windows.Forms.CheckBox();
            this.cofeePriceLabel = new System.Windows.Forms.Label();
            this.colaPriceLabel = new System.Windows.Forms.Label();
            this.redbulPriceLabel = new System.Windows.Forms.Label();
            this.playerMoneyLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(61, 198);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // takeNotofication
            // 
            this.takeNotofication.AutoSize = true;
            this.takeNotofication.Location = new System.Drawing.Point(114, 9);
            this.takeNotofication.Name = "takeNotofication";
            this.takeNotofication.Size = new System.Drawing.Size(64, 13);
            this.takeNotofication.TabIndex = 3;
            this.takeNotofication.Text = "Notofication";
            this.takeNotofication.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shopCoffee
            // 
            this.shopCoffee.AutoSize = true;
            this.shopCoffee.Location = new System.Drawing.Point(12, 93);
            this.shopCoffee.Name = "shopCoffee";
            this.shopCoffee.Size = new System.Drawing.Size(57, 17);
            this.shopCoffee.TabIndex = 4;
            this.shopCoffee.Text = "Coffee";
            this.shopCoffee.UseVisualStyleBackColor = true;
            this.shopCoffee.CheckedChanged += new System.EventHandler(this.shopCoffee_CheckedChanged);
            // 
            // shopCola
            // 
            this.shopCola.AutoSize = true;
            this.shopCola.Location = new System.Drawing.Point(12, 116);
            this.shopCola.Name = "shopCola";
            this.shopCola.Size = new System.Drawing.Size(47, 17);
            this.shopCola.TabIndex = 5;
            this.shopCola.Text = "Cola";
            this.shopCola.UseVisualStyleBackColor = true;
            this.shopCola.CheckedChanged += new System.EventHandler(this.shopCola_CheckedChanged);
            // 
            // shopRedbul
            // 
            this.shopRedbul.AutoSize = true;
            this.shopRedbul.Location = new System.Drawing.Point(12, 139);
            this.shopRedbul.Name = "shopRedbul";
            this.shopRedbul.Size = new System.Drawing.Size(60, 17);
            this.shopRedbul.TabIndex = 6;
            this.shopRedbul.Text = "Redbul";
            this.shopRedbul.UseVisualStyleBackColor = true;
            this.shopRedbul.CheckedChanged += new System.EventHandler(this.shopRedbul_CheckedChanged);
            // 
            // cofeePriceLabel
            // 
            this.cofeePriceLabel.AutoSize = true;
            this.cofeePriceLabel.Location = new System.Drawing.Point(82, 94);
            this.cofeePriceLabel.Name = "cofeePriceLabel";
            this.cofeePriceLabel.Size = new System.Drawing.Size(65, 13);
            this.cofeePriceLabel.TabIndex = 7;
            this.cofeePriceLabel.Text = "Coffee Price";
            // 
            // colaPriceLabel
            // 
            this.colaPriceLabel.AutoSize = true;
            this.colaPriceLabel.Location = new System.Drawing.Point(82, 117);
            this.colaPriceLabel.Name = "colaPriceLabel";
            this.colaPriceLabel.Size = new System.Drawing.Size(55, 13);
            this.colaPriceLabel.TabIndex = 8;
            this.colaPriceLabel.Text = "Cola Price";
            // 
            // redbulPriceLabel
            // 
            this.redbulPriceLabel.AutoSize = true;
            this.redbulPriceLabel.Location = new System.Drawing.Point(82, 140);
            this.redbulPriceLabel.Name = "redbulPriceLabel";
            this.redbulPriceLabel.Size = new System.Drawing.Size(68, 13);
            this.redbulPriceLabel.TabIndex = 9;
            this.redbulPriceLabel.Text = "Redbul Price";
            // 
            // playerMoneyLabel
            // 
            this.playerMoneyLabel.AutoSize = true;
            this.playerMoneyLabel.Location = new System.Drawing.Point(9, 61);
            this.playerMoneyLabel.Name = "playerMoneyLabel";
            this.playerMoneyLabel.Size = new System.Drawing.Size(70, 13);
            this.playerMoneyLabel.TabIndex = 10;
            this.playerMoneyLabel.Text = "Player money";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(82, 168);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(82, 13);
            this.totalPriceLabel.TabIndex = 11;
            this.totalPriceLabel.Text = "Total price label";
            // 
            // PickupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.playerMoneyLabel);
            this.Controls.Add(this.redbulPriceLabel);
            this.Controls.Add(this.colaPriceLabel);
            this.Controls.Add(this.cofeePriceLabel);
            this.Controls.Add(this.shopRedbul);
            this.Controls.Add(this.shopCola);
            this.Controls.Add(this.shopCoffee);
            this.Controls.Add(this.takeNotofication);
            this.Controls.Add(this.exitButton);
            this.Name = "PickupForm";
            this.Text = "PickupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label takeNotofication;
        private System.Windows.Forms.CheckBox shopCoffee;
        private System.Windows.Forms.CheckBox shopCola;
        private System.Windows.Forms.CheckBox shopRedbul;
        private System.Windows.Forms.Label cofeePriceLabel;
        private System.Windows.Forms.Label colaPriceLabel;
        private System.Windows.Forms.Label redbulPriceLabel;
        private System.Windows.Forms.Label playerMoneyLabel;
        private System.Windows.Forms.Label totalPriceLabel;

    }
}