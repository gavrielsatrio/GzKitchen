using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GzKitchen
{
    public class FieldsValidator
    {
        public bool IsAllTextBoxFilled(Control.ControlCollection controls)
        {
            bool isFilled = true;

            foreach (var control in controls)
            {
                if(control is TextBox txt)
                {
                    if(txt.Text == "")
                    {
                        isFilled = false;
                    }
                }
            }

            return isFilled;
        }
    }
}
