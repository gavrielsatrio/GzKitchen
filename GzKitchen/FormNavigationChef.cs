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
    public partial class FormNavigationChef : Form
    {
        private GzKitchenEntities db = new GzKitchenEntities();
        public int chefID = 0;
        private int menuCookedCount = 0;
        private int menuCookedCountNow = 0;
        private List<int> listUpdateOrderDetailID = new List<int>();
        private bool isAnyChangesMade = false;

        public FormNavigationChef()
        {
            InitializeComponent();
        }

        private void FormNavigationChef_Load(object sender, EventArgs e)
        {
            LoadChefInfo();
            LoadComboOrderAndTable();
        }

        private void LoadComboOrderAndTable()
        {
            var query = db.Orders.Where(x => x.OrderDetails.Where(y => y.IsCooked == false).Count() > 0).Select(x => new
            {
                OrderID = x.ID,
                OrderIDAndTableNo = x.ID + " - " + x.TableNo
            }).ToList();

            comboOrderAndTable.ValueMember = "OrderID";
            comboOrderAndTable.DisplayMember = "OrderIDAndTableNo";
            comboOrderAndTable.DataSource = query;
        }

        private void LoadChefInfo()
        {
            db = new GzKitchenEntities();

            var query = db.Accounts.Where(x => x.ID == chefID).ToList();
            lblChefName.Text = query[0].Name;
            lblChefEmail.Text = query[0].Email;
        }

        private void LoadData()
        {
            isAnyChangesMade = false;
            panelMenuToCook.Controls.Clear();
            //btnConfirmChanges.Visible = false;
            btnConfirmChanges.BackColor = Color.FromArgb(0, 204, 41, 62);
            listUpdateOrderDetailID.Clear();
            menuCookedCount = 0;
            menuCookedCountNow = 0;

            var orderID = int.Parse(comboOrderAndTable.SelectedValue.ToString());
            var orderMenus = db.OrderDetails.Where(x => x.OrderID == orderID).ToList();

            for (int i = 0; i < orderMenus.Count; i++)
            {
                var orderDetail = orderMenus[i];

                var checkOrderMenu = new CheckBox();
                checkOrderMenu.Name = orderDetail.ID.ToString();
                checkOrderMenu.AutoSize = true;
                checkOrderMenu.Text = orderDetail.Qty + " portion of " +  orderDetail.Menu.Name;
                checkOrderMenu.Location = new Point(12, 12 + (i * 20) + (i * 12));
                
                if(orderDetail.IsCooked == true)
                {
                    checkOrderMenu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Strikeout);
                    checkOrderMenu.Checked = true;
                    checkOrderMenu.Enabled = false;

                    menuCookedCount++;
                    menuCookedCountNow++;
                }
                else
                {
                    checkOrderMenu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                    checkOrderMenu.ForeColor = Color.FromArgb(204, 41, 62);
                }

                checkOrderMenu.CheckedChanged += CheckOrderMenu_CheckedChanged;

                panelMenuToCook.Controls.Add(checkOrderMenu);
            }
        }

        private void CheckOrderMenu_CheckedChanged(object sender, EventArgs e)
        {
            var checkOrderMenu = (CheckBox)sender;
            var orderDetailID = int.Parse(checkOrderMenu.Name);

            if(checkOrderMenu.Checked)
            {
                menuCookedCountNow++;
                listUpdateOrderDetailID.Add(orderDetailID);
            }
            else
            {
                menuCookedCountNow--;
                listUpdateOrderDetailID.Remove(orderDetailID);
            }


            if(menuCookedCountNow > menuCookedCount)
            {
                //btnConfirmChanges.Visible = true;
                isAnyChangesMade = true;
                timerShowBtnConfirmChanges.Start();
            }
            else
            {
                isAnyChangesMade = false;
                timerShowBtnConfirmChanges.Start();
                //btnConfirmChanges.Visible = false;
            }
        }

        private void lblChefName_Click(object sender, EventArgs e)
        {
            new FormEditProfile()
            {
                accountID = chefID
            }.ShowDialog();

            LoadChefInfo();
        }

        private void comboOrderAndTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            var confirmationDialog = MessageBox.Show("Are you sure you want to change the cooking status ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(confirmationDialog == DialogResult.Yes)
            {
                for (int i = 0; i < listUpdateOrderDetailID.Count; i++)
                {
                    var orderDetailID = listUpdateOrderDetailID[i];
                    var query = db.OrderDetails.Find(orderDetailID);
                    query.IsCooked = true;

                    db.SaveChanges();
                }

                var checkAllCooked = db.OrderDetails.ToList().Where(x => x.OrderID == int.Parse(comboOrderAndTable.SelectedValue.ToString()) && x.IsCooked == false).ToList();
                if(checkAllCooked.Count > 0)
                {
                    // Not all ordered menu are cooked
                    LoadData();
                }
                else
                {
                    // All ordered menu are cooked
                    LoadComboOrderAndTable();
                }
            }
        }

        private void timerShowBtnConfirmChanges_Tick(object sender, EventArgs e)
        {
            if (isAnyChangesMade)
            {
                if (btnConfirmChanges.BackColor != Color.FromArgb(255, 204, 41, 62))
                {
                    btnConfirmChanges.BackColor = Color.FromArgb(btnConfirmChanges.BackColor.A + 15, 204, 41, 62);
                }
                else
                {
                    timerShowBtnConfirmChanges.Stop();
                }
            }
            else
            {
                if (btnConfirmChanges.BackColor != Color.FromArgb(0, 204, 41, 62))
                {
                    btnConfirmChanges.BackColor = Color.FromArgb(btnConfirmChanges.BackColor.A - 15, 204, 41, 62);
                }
                else
                {
                    timerShowBtnConfirmChanges.Stop();
                }
            }
        }

        private void lblChefEmail_Click(object sender, EventArgs e)
        {
            lblChefName_Click(sender, e);
        }

        private void picBoxChef_Click(object sender, EventArgs e)
        {
            lblChefName_Click(sender, e);
        }

        private void FormNavigationChef_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormLogin().Show();
        }
    }
}
