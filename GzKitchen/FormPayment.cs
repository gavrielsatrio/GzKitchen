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
    public partial class FormPayment : Form
    {
        private GzKitchenEntities db = new GzKitchenEntities();
        public List<OrderedMenu> listOrderedMenu = new List<OrderedMenu>();
        public int totalPayment = 0;
        public bool isPaymentValid = false;
        public string paymentFormClosedWith = "none";
        public bool isPaymentSuccess = false;

        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            txtTotalPayment.Text = totalPayment.ToString("C");
        }

        private void txtAmountTendered_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtAmountTendered.Text != "")
            {
                if(txtAmountTendered.Text.All(char.IsDigit))
                {
                    var amountTendered = int.Parse(txtAmountTendered.Text);

                    if(amountTendered - totalPayment >= 0)
                    {
                        txtChange.Text = (amountTendered - totalPayment).ToString("C");
                        isPaymentValid = true;
                    }
                    else
                    {
                        txtChange.Text = 0.ToString("C");
                        isPaymentValid = false;
                    }
                }
                else
                {
                    txtChange.Text = 0.ToString("C");
                    isPaymentValid = false;
                }
            }
            else
            {
                txtChange.Text = 0.ToString("C");
                isPaymentValid = false;
            }
        }

        private void btnProceedPayment_Click(object sender, EventArgs e)
        {
            if(txtTableNo.Text != "")
            {
                if(isPaymentValid == true)
                {
                    var orderIDThatUseTheTableNo = db.Orders.Where(x => x.TableNo == txtTableNo.Text).OrderByDescending(x => x.ID).Select(x => x.ID).ToArray();
                    if(orderIDThatUseTheTableNo.Length > 0)
                    {
                        var isThereMenuThatNotCooked = db.OrderDetails.ToList().Where(x => x.OrderID == orderIDThatUseTheTableNo[0] && x.IsCooked == false).ToList();
                        if(isThereMenuThatNotCooked.Count > 0)
                        {
                            MessageBox.Show(txtTableNo.Text + " table is still occupied ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    db.Orders.Add(new Order
                    {
                        TableNo = txtTableNo.Text
                    });
                    db.SaveChanges();

                    var insertedOrderID = db.Orders.OrderByDescending(x => x.ID).Select(x => x.ID).ToArray()[0];
                    for (int i = 0; i < listOrderedMenu.Count; i++)
                    {
                        db.OrderDetails.Add(new OrderDetail
                        {
                            OrderID = insertedOrderID,
                            MenuID = listOrderedMenu[i].MenuID,
                            Qty = listOrderedMenu[i].Qty,
                            IsCooked = false
                        });
                        db.SaveChanges();
                    }

                    MessageBox.Show("Payment Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    paymentFormClosedWith = "successPayment";
                    isPaymentSuccess = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Payment is not valid ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill up Table No ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!isPaymentSuccess)
            {
                paymentFormClosedWith = "buttonX";
            }
        }
    }
}
