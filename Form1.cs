//Programmer: Eva Zolotarev
//Project: Lab 2-1
//Date: 2/13/2020
//Description: Form for taking a carpet order.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_1
{
    public partial class formForm : Form
    {
        public formForm()
        {
            InitializeComponent();
        }

        //Perform calculations and display results
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Use Try-catch to handle any data entry exceptions
            try
            {
                //Declare local variables
                const decimal TAX_RATE = 0.07m;
                const decimal LABOR_RATE = 0.50m;

                //Declare local variables
                double length;           //Length of carpet
                double width;            //Width of carpet
                double area;             //Area of carpet
                decimal price;           //Price of carpet (per sq. ft.)
                decimal carpetCharge;    //Total price of carpet
                decimal tax;             //Tax on total price of carpet
                decimal laborCharge;     //Labor charge for installing carpet
                decimal orderTotal;      //Total charge for order (carpet and labor)

                //Get values from text boxes and assign to variables
                length = double.Parse(lengthTextBox.Text);
                width = double.Parse(widthTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);

                //Calculate and display area of carpet
                area = length * width;
                carpetAreaLabelInput.Text = area.ToString("n2");

                //Calculate and display carpet charge
                carpetCharge = (decimal)area * price; //Cast operator required
                carpetChargeLabelInput.Text = carpetCharge.ToString("c");

                //Calculate and display labor charge
                laborCharge = (decimal)area * LABOR_RATE;
                laborChargeLabelInput.Text = laborCharge.ToString("c");

                //Calculate and display tax on carpet charge
                tax = carpetCharge * TAX_RATE;
                salesTaxLabelInput.Text = laborCharge.ToString("c");

                //Calculate and display order total
                orderTotal = carpetCharge + tax + laborCharge;
                orderTotalLabelOutput.Text = orderTotal.ToString("c");
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            lengthTextBox.Text = "";
            widthTextBox.Text = "";
            priceTextBox.Text = "";
            carpetAreaLabelInput.Text = "";
            carpetChargeLabelInput.Text = "";
            salesTaxLabelInput.Text = "";
            laborChargeLabelInput.Text = "";
            orderTotalLabelOutput.Text = "";

            //Set focus to first input control on form
            lengthTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
