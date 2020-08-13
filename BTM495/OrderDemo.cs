using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495
{
    public partial class OrderDemo : Form
    {
        public OrderDemo()
        {
            InitializeComponent();
        }

        private void OrderBtn_Click_1(object sender, EventArgs e)
        {
            DataAccess addOrder = new DataAccess();
            
            addOrder.AddOrder(int.Parse(QuantityTextBox.Text), int.Parse(ProductTypeTextBox.Text));

            QuantityTextBox.Text = "";
            ProductTypeTextBox.Text = "";

            MessageBox.Show("Order made!");
        }
    }
}
