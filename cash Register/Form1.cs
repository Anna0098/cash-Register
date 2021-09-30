using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash_Register
{
    public partial class form1 : Form
    {
        double milkPrice = 4.50;
        double eggPrice = 5.50;
        double breadPrice = 7.58;
        int numOfMilk = 0;
        int numOfEgg = 0;
        int numOfBread = 0;
        double totalPrice;
        double taxTotal;
        double tax = .13;

        public form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bread_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        
                 {

            numOfBread = Convert.ToInt32(breadInput.Text);
            numOfMilk = Convert.ToInt32(milkInput.Text);
            numOfEgg = Convert.ToInt32(eggInput.Text);


                totalPrice = numOfBread + numOfMilk + numOfEgg;
                taxTotal = numOfBread + numOfEgg + numOfMilk * tax;

                outputSub.Text = $"The price of your order without tax is {totalPrice.ToString("c")}";
                outputTax.Text = "Tax is 13%";
                outputTotal.Text = $"Your final price is {taxTotal.ToString("c")}";




            }
     

        
        private void boxB_TextChanged(object sender, EventArgs e)

            {


            }
        }
    }
