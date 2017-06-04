//15.9 (Restaurant Bill Calculator) A restaurant wants an app that calculates a table’s bill. The app should display all 
//the menu items in four ComboBoxes. Each ComboBox should contain a category of food offered by the restaurant 
//(Beverage, Appetizer, Main Course and Dessert). The user can choose from one of these ComboBoxes to add an item to a table’s bill. 
//As each item is selected in the ComboBoxes, add the price of that item to the bill. 
//The user can click the Clear Bill Button to restore the Subtotal:, Tax: and Total: fields to $0.00.
//***************************************************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_9_RestaurantBillCalculator
{   

    public partial class Form1 : Form
    {

        public struct Orders
        {
            public string item ;
            public double price;
        }
        const double TAX = 0.06; //6% tax
        Orders order = new Orders();
        string finalBill = " FINAL BILL:" + Environment.NewLine;
        static double subtotal;
        static double total;
        static double totalTaxes;

        public Form1()
        {
            InitializeComponent();
        }        

        private void getValues(string custOrder)
        {
            order.item = custOrder.Split('$')[0];
            order.price = Convert.ToDouble(custOrder.Split('$')[1]);
            lstOutput.Items.Add("Price: " + order.price);
            finalBill += "\nOrdered Item: " + order.item + "\nPrice: " + order.price.ToString("C2") + "\n ";
            updateBill();
        }

        private void updateBill()
        {
            subtotal += order.price;
            total += order.price + (order.price * TAX);
            totalTaxes += order.price * TAX;
            lstOutput.Items.Clear();
            lstOutput.Items.AddRange(finalBill.Split('\n'));
            lstOutput.Items.Add("Subtotal: " + subtotal.ToString("C2"));
            lstOutput.Items.Add("Tax: " + totalTaxes.ToString("C2"));
            lstOutput.Items.Add("Total: " + total.ToString("C2"));            
        }

        private void changingDropdown(object sender, EventArgs e)
        {
            if (sender == cmbDrinks)
                getValues(cmbDrinks.SelectedItem.ToString());
            else if (sender == cmbMeals)
                getValues(cmbMeals.SelectedItem.ToString());
            else if (sender == cmbAppetizers)
                getValues(cmbAppetizers.SelectedItem.ToString());
            else
                getValues(cmbDesserts.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
