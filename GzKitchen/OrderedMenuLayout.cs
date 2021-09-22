using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GzKitchen
{
    public partial class OrderedMenuLayout : UserControl
    {
        public Menu menu;
        public List<OrderedMenu> listOrderedMenu = new List<OrderedMenu>();
        public int i = 0;
        public FormNavigationCashier navCashier = new FormNavigationCashier();

        public OrderedMenuLayout()
        {
            InitializeComponent();
        }

        private void OrderedMenuLayout_Load(object sender, EventArgs e)
        {
            using (var stream = new MemoryStream(menu.Picture))
            {
                picBoxOrderedMenu.Image = new Bitmap(stream);
            }
            lblOrderedMenuName.Text = menu.Name;
            lblOrderedMenuPrice.Text = menu.Price.ToString("C");
            lblOrderedMenuQty.Text = "x" + listOrderedMenu[i].Qty.ToString();
            lblOrderedMenuSubtotal.Text = (listOrderedMenu[i].Qty * menu.Price).ToString("C");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listOrderedMenu.Remove(listOrderedMenu[i]);
            navCashier.listOrderedMenu = listOrderedMenu;
            navCashier.LoadOrderedMenu();
        }
    }
}
