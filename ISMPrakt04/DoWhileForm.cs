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
        List<int> numbers;
        int number = 0;
        public DoWhileForm()
        {
            numbers = new List<int>();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(int.TryParse((sender as TextBox).Text, out number)) 
            {
                numbers.Add(number);
                (sender as TextBox).Text = "";
            }
           (sender as TextBox).Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelOutput.Text = TasksMethods.DoWhileTask(numbers).ToString();
            numbers.Clear();
        }
    }
}
