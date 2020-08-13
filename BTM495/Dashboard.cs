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
    public partial class Dashboard : Form 
    {

        //Fields
        private Button currentButton;
        
        
        public Dashboard()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }



        #region Button Classes

        private void CustomizeDesign()
        {
            SubMenuPanel.Visible = false;
        }


        private void hideSubMenu()
        {
            if (SubMenuPanel.Visible == true)
                SubMenuPanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
            //to open and close the submenu
        }


        private void ActivateButton (object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = Color.FromArgb(4, 87, 13);

                    currentButton = (Button)btnSender;

                    currentButton.BackColor = color;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    
                    previousBtn.BackColor = Color.FromName("Pink");
                }
            }
        }

        #endregion

        
        
        
        //OPEN OTHER FORM

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            //to transfer childForm to activeForm and thus uodate the activeForm

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            //now we add the childForm
            panelChildForm.Tag = childForm;
            childForm.Show();

        }



        #region Buttons
        private void inventoryButton_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenuPanel);

            ActivateButton(sender);


            openChildForm(new AvailableInventory());
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AddProduct());
        }

        private void orderDemoButton_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderDemo());
        }

        private void notificationsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hideSubMenu();
            openChildForm(new Notifications());
        }

        private void missingButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            openChildForm(new MissingProducts());

            hideSubMenu();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Close();
        }
        #endregion 
    }
}
