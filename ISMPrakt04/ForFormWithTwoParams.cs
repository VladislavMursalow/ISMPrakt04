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
    public partial class ForFormWithTwoParams : Form
    {
        int A, B;
        private Tasks _taskNumber;
        public ForFormWithTwoParams(Tasks task)
        {
            InitializeComponent();
            _taskNumber = task;
            if (task == Tasks.Task3) BTextBox.Visible = false; else BTextBox.Visible = true;
            Text = "Task For" + ((int)task).ToString();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int resultInt;
            float resultF;

            CorrectInput.CIInt(ATextBox.Text, BTextBox.Text, out A, out B);

            switch (_taskNumber)
                {
                    case Tasks.Task1:
                        {
                        if (A >= B){
                            MessageBox.Show("A<=B", "Помилка",MessageBoxButtons.OK);
                            break;
                        }
                            resultInt = TasksMethods.MultiplyFromAtoB(A, B);
                            ResultTextBox.Text = resultInt.ToString();
                        }
                        break;
                    case Tasks.Task3:
                        {
                            resultF = TasksMethods.PowToN(A, (int)NNumericUpDown.Value);
                            ResultTextBox.Text = resultF.ToString();
                        }
                        break;
                    case Tasks.Task4:
                        {
                        if (A >= B)
                        {
                            MessageBox.Show("A<=B", "Помилка", MessageBoxButtons.OK);
                            break;
                        }
                        resultInt = TasksMethods.FindSumOfSqueresFromAtoB(A, B);
                            ResultTextBox.Text = resultInt.ToString();
                        }
                    break;
                }

        }
            

    }
}
