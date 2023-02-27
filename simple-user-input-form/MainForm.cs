using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_user_input_form
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        UserInputForm _userInputForm= new UserInputForm();
        private void buttonShowUserInput_Click(object sender, EventArgs e)
        {
            // Make sure the dialog hasn't been cancelled by [X]
            if(DialogResult.OK.Equals(_userInputForm.ShowDialog()))
            {
                richTextBox.Clear();
                richTextBox.SelectionColor= Color.Navy;
                richTextBox.AppendText($"V={_userInputForm.V}{Environment.NewLine}");
                richTextBox.SelectionColor = Color.DarkGreen;
                richTextBox.AppendText($"H={_userInputForm.H}{Environment.NewLine}");
            }
            else
            {
                richTextBox.Clear();
                richTextBox.SelectionColor = Color.Red;
                richTextBox.AppendText($"CANCELLED{Environment.NewLine}");
            }
        }
    }
}
