using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GzKitchen
{
    public static class ExtensionForPanel
    {
        public static void SetSelectedState(this Panel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public static void SetUnselectedState(this Panel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
