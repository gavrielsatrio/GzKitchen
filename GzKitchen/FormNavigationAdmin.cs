using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GzKitchen
{
    public partial class FormNavigationAdmin : Form
    {
        private GzKitchenEntities db = new GzKitchenEntities();

        private UserControl formManageMenu = new FormManageMenu()
        {
            Dock = DockStyle.Fill
        };

        private UserControl formManageAccount = new FormManageAccount()
        {
            Dock = DockStyle.Fill
        };

        public int adminID = 0;

        public FormNavigationAdmin()
        {
            InitializeComponent();
        }

        private void FormNavigationAdmin_Load(object sender, EventArgs e)
        {
            LoadSideBar();
            panelContent.Controls.Add(formManageAccount);
            formManageAccount.Focus();

            LoadAdminInfo();
        }

        private void LoadAdminInfo()
        {
            db = new GzKitchenEntities();

            var query = db.Accounts.Where(x => x.ID == adminID).ToList();
            lblAdminEmail.Text = query[0].Email;
            lblAdminName.Text = query[0].Name;
        }

        private void lblAdminName_Click(object sender, EventArgs e)
        {
            new FormEditProfile()
            { 
                accountID = adminID
            }.ShowDialog();

            LoadAdminInfo();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ClearSelectedStateOnSideBarButton();
            btnManageAccount.Tag = "btnSideBar-Selected";
            LoadSideBar();

            panelContent.Controls.Clear();
            panelContent.Controls.Add(formManageAccount);
            formManageAccount.Focus();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            ClearSelectedStateOnSideBarButton();
            btnManageMenu.Tag = "btnSideBar-Selected";
            LoadSideBar();

            panelContent.Controls.Clear();
            panelContent.Controls.Add(formManageMenu);
            formManageMenu.Focus();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void FormNavigationAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void LoadSideBar()
        {
            foreach (var control in panelSideBar.Controls)
            {
                if (control is Panel panelButton)
                {
                    if (panelButton.Tag != null)
                    {
                        if (panelButton.Tag.ToString() == "btnSideBar-Selected")
                        {
                            panelButton.SetSelectedState();
                        }
                        else
                        {
                            panelButton.SetUnselectedState();
                        }
                    }
                }
            }
        }

        private void ClearSelectedStateOnSideBarButton()
        {
            foreach (var control in panelSideBar.Controls)
            {
                if (control is Panel panelButton)
                {
                    panelButton.Tag = "btnSideBar-NotSelected";
                }
            }
        }

        private void picBoxManageAccount_Click(object sender, EventArgs e)
        {
            btnManageAccount_Click(sender, e);
        }

        private void lblManageAccount_Click(object sender, EventArgs e)
        {
            btnManageAccount_Click(sender, e);
        }

        private void picBoxManageMenu_Click(object sender, EventArgs e)
        {
            btnManageMenu_Click(sender, e);
        }

        private void lblManageMenu_Click(object sender, EventArgs e)
        {
            btnManageMenu_Click(sender, e);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void picBoxLogout_Click(object sender, EventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void lblAdminEmail_Click(object sender, EventArgs e)
        {
            lblAdminName_Click(sender, e);
        }

        private void picBoxAdmin_Click(object sender, EventArgs e)
        {
            lblAdminName_Click(sender, e);
        }
    }
}
