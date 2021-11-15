using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMPrakt04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void For2Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new ForFormWithOneParam(Tasks.Task2));

        }

        private void For5Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new ForFormWithOneParam(Tasks.Task5));
        }

        private void For1Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new ForFormWithTwoParams(Tasks.Task1));
        }

        private void For3Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new ForFormWithTwoParams(Tasks.Task3));
        }

        private void For4Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new ForFormWithTwoParams(Tasks.Task4));
        }

        private void While1Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new WhileForm(Tasks.Task6));
        }

        private void While2Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new WhileForm(Tasks.Task7));
        }

        private void ShowDialogFunk(Form form)
        {
            form.ShowDialog();
            form.Close();
        }

        private void While3Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new While3TaskForm());
        }

        private void DoWhile1Button_Click(object sender, EventArgs e)
        {
            ShowDialogFunk(new DoWhileForm());
        }
    }
}
