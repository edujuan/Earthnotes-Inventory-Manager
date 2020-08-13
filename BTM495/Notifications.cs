using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495
{
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void AvailableInventory_Load(object sender, EventArgs e)
        {
            DataCreator();
        }

        private void UpdateBinding()
        {
            products = CheckLowQuantity();
            notificationsListBox.DataSource = products;
        }

    


        //NOTIFICATIONS

        List<Product> products = new List<Product>();
        ListBox notificationsListBox = new ListBox();


        public List<Product> CheckLowQuantity()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Product>($"SELECT * FROM Products WHERE Quantity<5").ToList();
                return output;
            }
        }


        public void DataCreator()
        { 
            int n;

            n = products.Count();

            youlayOut.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                Label lblTitle = new Label();

                lblTitle.Text = products[i].FullInfo;
                lblTitle.Height = 30;
                lblTitle.Width = 100000;
                lblTitle.BackColor = Color.Gray;
                lblTitle.ForeColor = Color.White;
                lblTitle.Margin = new Padding(3);
                lblTitle.TextAlign = ContentAlignment.MiddleCenter;

                if (products[i].Quantity == 0)
                {
                    lblTitle.BackColor = Color.Red;
                    lblTitle.Text = products[i].Name + " has no units left";
                }
                else if (products[i].Quantity == 1) 
                {
                    lblTitle.Text = products[i].Name + " has 1 unit left";
                }
                 
            youlayOut.Controls.Add(lblTitle, 0, i);
                
            }
            
        }
    }
}
