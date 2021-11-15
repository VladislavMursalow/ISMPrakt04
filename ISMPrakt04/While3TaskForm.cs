using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLib;

namespace ISMPrakt04
{
    public partial class While3TaskForm : Form
    {
        public While3TaskForm()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int days = 0;
            float S = TasksMethods.FindTaskParameters((float)PnumericUpDown.Value, 10f, out days);

            OutputTextBox.Text = "к-сть днів: " + days.ToString() + "\n Сумарний пробіг:" + S.ToString();
        }
    }
}
