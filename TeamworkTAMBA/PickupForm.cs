using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamworkTAMBA
{
    public partial class PickupForm : Form
    {
        private Coffee coffee;
        private Player player;
        private int coffeePrice = 2;
        private int colaPrice = 5;
        private int redbulPrice = 10;
        private int totoalPrice = 0;
        private int currentPlayerMoney;
        public PickupForm(Player player, Coffee coffee)
        {
            InitializeComponent();

            this.player = player;
            this.coffee = coffee;
            player.Health = 100;
            //player.Money = 5;
            currentPlayerMoney = player.Money;
            

            takeNotofication.Text = "What would you like!";

            playerMoneyLabel.Text = "You have: " + player.Money;
            totalPriceLabel.Text = "Total: " + totoalPrice;
            cofeePriceLabel.Text = coffeePrice.ToString();
            colaPriceLabel.Text = colaPrice.ToString();
            redbulPriceLabel.Text = redbulPrice.ToString();

            TotalCheck();
        }

        //private void PlayerMoneyCheck(CheckBox checkBox)
        //{
            
        //}


        

        private void shopCoffee_CheckedChanged(object sender, EventArgs e)
        {
            TotalCheck();
            if (shopCoffee.Checked)
            {
                player.Health += 25;
                player.Money -= coffeePrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                totoalPrice += coffeePrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }
            else
            {
                player.Health -= 25;
                player.Money += 2;
                playerMoneyLabel.Text = "You have: " + player.Money;
                totoalPrice -= coffeePrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }
        }

        private void shopCola_CheckedChanged(object sender, EventArgs e)
        {
            if (shopCola.Checked)
            {
                player.Health += 50;
                player.Money -= colaPrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                totoalPrice += colaPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }
            else
            {
                player.Health -= 50;
                player.Money += colaPrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                totoalPrice -= colaPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }
        }

        private void shopRedbul_CheckedChanged(object sender, EventArgs e)
        {
            
            if (shopRedbul.Checked)
            {
                player.Health += 100;
                player.Money -= redbulPrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                totoalPrice += redbulPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }
            else
            {
                player.Health -= 100;
                player.Money += 10;
                playerMoneyLabel.Text = "You have: " + player.Money;
                totoalPrice -= redbulPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }

        }

        private void TotalCheck()
        {
            if (this.player.Money < 0)
            {
                exitButton.Enabled = false;
            }
            else
            {
                exitButton.Enabled = true;
            }
        }

        private void CheckPlayerHealth()
        {
            if (player.Health > 100)
            {
                player.Health = 100;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            CheckPlayerHealth();
            this.Close();
        }
    }
}
