using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace GzKitchen
{
    public partial class FormManageAccount : UserControl
    {
        private GzKitchenEntities db = new GzKitchenEntities();
        private int selectedID = 0;
        private string saveButtonState = "add";

        public FormManageAccount()
        {
            InitializeComponent();
        }

        private void FormManageAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvAccount.Columns.Clear();

            var query = db.Accounts.Select(x => new
            {
                x.ID,
                x.Name,
                x.Email,
                x.Handphone,
                x.Role,
                x.Address
            }).ToList();

            dgvAccount.DataSource = query;
            dgvAccount.Columns["ID"].Visible = false;

            var btnEditColumn = new DataGridViewButtonColumn();
            btnEditColumn.Name = "Edit";
            btnEditColumn.HeaderText = "Edit";
            btnEditColumn.Text = "Edit";
            btnEditColumn.UseColumnTextForButtonValue = true;

            var btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.Name = "Delete";
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dgvAccount.Columns.Add(btnEditColumn);
            dgvAccount.Columns.Add(btnDeleteColumn);

            txtName.Text = "";
            txtEmail.Text = "";
            txtHandphone.Text = "";
            txtAddress.Text = "";
            saveButtonState = "add";
            selectedID = 0;
            comboRole.SelectedIndex = 0;

            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(new FieldsValidator().IsAllTextBoxFilled(Controls))
            {
                if(new EmailAddressAttribute().IsValid(txtEmail.Text))
                {
                    if(new PhoneAttribute().IsValid(txtHandphone.Text))
                    {
                        if(saveButtonState == "add")
                        {
                            db.Accounts.Add(new Account
                            {
                                Name = txtName.Text,
                                Email = txtEmail.Text,
                                Password = "default123",
                                Handphone = txtHandphone.Text,
                                Role = comboRole.Text,
                                Address = txtAddress.Text
                            });

                            db.SaveChanges();
                            LoadData();
                        }
                        else
                        {
                            var query = db.Accounts.Find(selectedID);
                            query.Name = txtName.Text;
                            query.Email = txtEmail.Text;
                            query.Handphone = txtHandphone.Text;
                            query.Role = comboRole.Text;
                            query.Address = txtAddress.Text;

                            db.SaveChanges();
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Handphone number is not valid ...");
                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid ...");
                }
            }
            else
            {
                MessageBox.Show("Fill all the fields ...");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dgvAccount.CurrentRow.Cells;

                if(e.ColumnIndex == dgvAccount.Columns["Edit"].Index)
                {
                    selectedID = int.Parse(row["ID"].Value.ToString());
                    txtName.Text = row["Name"].Value.ToString();
                    txtEmail.Text = row["Email"].Value.ToString();
                    txtHandphone.Text = row["Handphone"].Value.ToString();
                    comboRole.Text = row["Role"].Value.ToString();
                    txtAddress.Text = row["Address"].Value.ToString();

                    saveButtonState = "edit";
                }
                else if(e.ColumnIndex == dgvAccount.Columns["Delete"].Index)
                {
                    var confirmationDialog = MessageBox.Show("Are you sure want to delete ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(confirmationDialog == DialogResult.Yes)
                    {
                        selectedID = int.Parse(row["ID"].Value.ToString());
                        var query = db.Accounts.Find(selectedID);
                        db.Accounts.Remove(query);

                        db.SaveChanges();
                    }

                    LoadData();
                }
            }
        }
    }
}
