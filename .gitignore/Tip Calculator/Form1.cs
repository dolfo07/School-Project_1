///Rodolfo Aybar
///Tip Calculator
///POS/409
///Sept 25, 2017
///Lynn Thackeray

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.GhostWhite;//This is changing the App Background Color
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            double temp_charges = Convert.ToDouble(charges.Text);
            double temp = 0;
            double tip1 = .15;
            double tip2 = .20;


            if (radioButtonTip1.Checked == true)//percentage that will be calculated if checked. The .15% will be multiplied against the value provided on the Texbox "charges"
               temp= temp_charges * tip1;

            else if (radioButtonTip2.Checked == true)//percentage that will be calculated if checked. The .20% will be multiplied against the value provided on the Texbox "charges"
                temp = temp_charges * tip2;

            tip.Text = temp.ToString();//The result of multipliying the value on the field "charges" with any of these % options will be displayed here

            balance.Text = charges.Text + tip.Text;// Hello Professor, I got stuck in this portion of the assignment. 
            //I could not figure out how to add these two fields and the turn the value into numbers. 
            //My total balance came as a concatenation. Could you assist me with an example on how to proceed at this point?
        }

        private void textBoxCharges_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            charges.Text = "0";
            tip.Text = "0";
            balance.Text = "0";
            //The above lines of code will reset these two fields back to Zero
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void charges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void balance_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
