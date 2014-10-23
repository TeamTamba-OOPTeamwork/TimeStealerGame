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
        private int beerPrice = 10;
        private int totoalPrice = 0;
        private int currentPlayerMoney;
        private int currentPlayerHealth;
        private int coffeeTimeGive = 25;
        private int colaTimeGive = 50;
        private int redbulTimeGive = 100;
        public PickupForm(Player player, Coffee coffee)
        {
            InitializeComponent();

            this.player = player;
            this.coffee = coffee;
            currentPlayerMoney = player.Money;
            

            takeNotofication.Text = "What would you like!";

            playerMoneyLabel.Text = "You have: " + player.Money;
            totalPriceLabel.Text = "Total: " + totoalPrice;
            cofeePriceLabel.Text = coffeePrice.ToString();
            colaPriceLabel.Text = colaPrice.ToString();
            redbulPriceLabel.Text = redbulPrice.ToString();
            beerPriceLabel.Text = beerPrice.ToString();
            playerHealthLabel.Text = "Time: " + player.Health;
            bearsHaveLabel.Text = "You have: " + player.Beers + " beers.";

            TotalCheck();
        }

        private void shopCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (shopCoffee.Checked)
            {
                totoalPrice += coffeePrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                currentPlayerHealth = player.Health + coffeeTimeGive;
                playerHealthLabel.Text = "Time: " + currentPlayerHealth;
                TotalCheck();
            }
            else
            {
                totoalPrice -= coffeePrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                currentPlayerHealth = player.Health;
                playerHealthLabel.Text = "Time: " + currentPlayerHealth;
                TotalCheck();
            }
        }

        private void shopCola_CheckedChanged(object sender, EventArgs e)
        {
            if (shopCola.Checked)
            {
                totoalPrice += colaPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                currentPlayerHealth = player.Health + colaTimeGive;
                playerHealthLabel.Text = "Time: " + currentPlayerHealth;
                TotalCheck();
            }
            else
            {
                totoalPrice -= colaPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                currentPlayerHealth = player.Health;
                playerHealthLabel.Text = "Time: " + currentPlayerHealth;
                TotalCheck();
            }
        }

        private void shopRedbul_CheckedChanged(object sender, EventArgs e)
        {
            TotalCheck();
            if (shopRedbul.Checked)
            {
                totoalPrice += redbulPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                currentPlayerHealth = player.Health + redbulTimeGive;
                playerHealthLabel.Text = "Time: " + currentPlayerHealth;
                TotalCheck();
            }
            else
            {
                totoalPrice -= redbulPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                currentPlayerHealth = player.Health;
                playerHealthLabel.Text = "Time: " + currentPlayerHealth;
                TotalCheck();
            }
        }
        private void beerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TotalCheck();
            if (beerCheckbox.Checked)
            {
                totoalPrice += beerPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }
            else
            {
                totalPriceLabel.Text = "Total: " + totoalPrice;
                totoalPrice -= beerPrice;
                totalPriceLabel.Text = "Total: " + totoalPrice;
                TotalCheck();
            }
        }

        private void TotalCheck()
        {
            if (this.player.Money < 0 || totoalPrice > this.player.Money)
            {
                buyButton.Enabled = false;
            }
            else
            {
                buyButton.Enabled = true;
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

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (shopCoffee.Checked)
            {
                player.Health += 25;
                player.Money -= coffeePrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                TotalCheck();
            }

            if (shopCola.Checked)
            {
                player.Health += 50;
                player.Money -= colaPrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                TotalCheck();
            }
            if (shopRedbul.Checked)
            {
                player.Health += 100;
                player.Money -= redbulPrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                TotalCheck();
            }
            if (beerCheckbox.Checked)
            {
                player.Money -= beerPrice;
                playerMoneyLabel.Text = "You have: " + player.Money;
                player.Beers++;
                bearsHaveLabel.Text = "You have: " + player.Beers + " beers.";
                TotalCheck();
            }

            CheckPlayerHealth();
            playerHealthLabel.Text = "Time: " + player.Health;
        }
    }
}
