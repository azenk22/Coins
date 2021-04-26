using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            int coins = 0;
            int coins1 = 0;
            if(!InRange())
            {
                MessageBox.Show("Must enter an integer between 1 and 250", "Out of Range");
            }
            else
            {
                int value = int.Parse(IntegerTB.Text);

               
                coins  = NumberOfCoins(int.Parse(IntegerTB.Text));

                coins1 = NumOfCoins(int.Parse(IntegerTB.Text));

                if(coins < coins1)
                {
                    MessageBox.Show(IntegerTB.Text + " can be achieved with " + coins + " coins!");
                }
                else
                {
                    MessageBox.Show(IntegerTB.Text + " can be achieved with " + coins1 + " coins!");
                }
            }
        }

  
        private int NumOfCoins(int value)
        {
            int coins = 0;

            while(value > 0)
            {
                if(value >= 11)
                {
                    value -= 11;
                }
                else if(value >= 9)
                {
                    value -= 9;
                }
                else if(value >= 7)
                {
                    value -= 7;
                }
                else if(value >= 5)
                {
                    value -= 5;
                }
                else if(value >= 1)
                {
                    value -= 1;
                }

                coins++;

            }

            return coins;
        }

        private int NumberOfCoins(int value)
        {
            int coins = 0;

            while(value > 0)
            {
                if(value >= 11)
                {
                    value -= 11;
                    coins++;
                }
                if (value >= 9)
                {
                    value -= 9;
                    coins++;
                }
                if (value >= 7)
                {
                    value -= 7;
                    coins++;
                }
                if (value >= 5)
                {
                    value -= 5;
                    coins++;
                }
                if(value >= 1)
                {
                    value -= 1;
                    coins++;
                }

                
            }
            
            return coins;
        }

        private bool InRange()
        {
            bool valid = false;

            
            if(int.Parse(IntegerTB.Text) >= 1 && int.Parse(IntegerTB.Text) <= 250)
            {
                valid = true;
            }

            return valid;
        }
    }
}
