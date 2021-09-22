using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace GzKitchen
{
    public partial class FormEditProfile : Form
    {
        private GzKitchenEntities db = new GzKitchenEntities();
        public int accountID = 0;

        public FormEditProfile()
        {
            InitializeComponent();
        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            var account = db.Accounts.Where(x => x.ID == accountID).ToList()[0];
            txtName.Text = account.Name;
            txtEmail.Text = account.Email;
            txtPassword.Text = account.Password;
            txtHandphone.Text = account.Handphone;
            txtAddress.Text = account.Address;
            lblRole.Text = account.Role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(new FieldsValidator().IsAllTextBoxFilled(Controls))
            {
                if(new EmailAddressAttribute().IsValid(txtEmail.Text))
                {
                    if(txtPassword.Text.Any(char.IsDigit) && txtPassword.Text.Any(char.IsLetter) && txtPassword.Text.Length >= 8)
                    {
                        if(new PhoneAttribute().IsValid(txtHandphone.Text))
                        {
                            var query = db.Accounts.Find(accountID);
                            query.Name = txtName.Text;
                            query.Email = txtEmail.Text;
                            query.Password = txtPassword.Text;
                            query.Handphone = txtHandphone.Text;
                            query.Address = txtAddress.Text;

                            db.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Handphone number is not valid ...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must be at least 8 characters long and contains number ...");
                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid ...");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
