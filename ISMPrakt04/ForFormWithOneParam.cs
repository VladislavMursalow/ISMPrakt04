using System;
using System.Windows.Forms;
using TaskLib;
namespace ISMPrakt04
{
    public enum Tasks : int
    {
        Task1 = 1,
        Task2 = 2,
        Task3 = 3,
        Task4 = 4,
        Task5 = 5,
        Task6 = 6,
        Task7 = 7,
        Task8 = 8,
        Task9 = 9
    }

    public partial class ForFormWithOneParam : Form
    {
        private Tasks _taskNumber;

        public ForFormWithOneParam(Tasks task)
        {
            InitializeComponent();
            _taskNumber = task;
            this.Text = "Task For"+ ((int)task).ToString();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int resultInt;
            float resultF;

            switch (_taskNumber) 
            {
                case Tasks.Task2: {
                        resultF = TasksMethods.MapSumToN((int)UpDownForN.Value);
                        ResultTextBox.Text = resultF.ToString();
                    } break;
                case Tasks.Task5: {
                        resultInt = TasksMethods.MapFactorialSummToN((int)UpDownForN.Value);
                        ResultTextBox.Text = resultInt.ToString();
                    } break;
            }
        }

    }
}
