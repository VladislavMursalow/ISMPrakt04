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
    public partial class DoWhileForm : Form
    {
        public DoWhileForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelOutput.Text = TasksMethods.DoWhileTask(TextInput).ToString();
        }
    }
}
