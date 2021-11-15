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
    public partial class WhileForm : Form
    {
        private Tasks _taskNumber;

        public WhileForm(Tasks task)
        {
            _taskNumber = task;
            InitializeComponent();
            if (_taskNumber == Tasks.Task6) NNumericUpDown.Minimum = 1; else NNumericUpDown.Minimum = 2;
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int resultInt;
            float resultF;

            switch (_taskNumber) 
            {
                case Tasks.Task6: 
                    {
                        resultInt = TasksMethods.MapPowToN((int)NNumericUpDown.Value);
                        OutputTextBox.Text = resultInt.ToString();
                    };break; 
                case Tasks.Task7: 
                    {
                        resultF = TasksMethods.FindLessDegreeNum((int)NNumericUpDown.Value);
                        OutputTextBox.Text = resultF.ToString();
                    };break; 
            }
        }
    }
}
