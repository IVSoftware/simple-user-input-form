using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace simple_user_input_form
{
    public partial class UserInputForm : Form
    {
        public UserInputForm()
        {
            InitializeComponent();
            textBoxV.TextChanged += onAnyTextChanged;
            textBoxH.TextChanged += onAnyTextChanged;
            VisibleChanged += onVisibleChanged;
        }

        // The public properties are available whether
        // the form is currently visible or not.
        public int V { get; private set; } = 1;
        public int H { get; private set; } = 1;

        // Whenever the form is shown, refresh the text boxes
        // with the last VALID values for V and H
        private void onVisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                textBoxV.Text = V.ToString();
                textBoxH.Text = H.ToString();
            }
        }
        private void onAnyTextChanged(object sender, EventArgs e)
        {
            int value;
            bool isValid = true;
            if(int.TryParse(textBoxV.Text, out value))
            {
                V = value;
                textBoxV.BackColor= Color.White;
            }
            else
            {
                isValid = false;
                textBoxV.BackColor = Color.LightSalmon;
            }
            if (int.TryParse(textBoxH.Text, out value))
            {
                H = value;
                textBoxH.BackColor = Color.White;
            }
            else
            {
                isValid = false;
                textBoxH.BackColor = Color.LightSalmon;
            }
            // Enable or disable the OK button based on
            // valid integer values of both textboxes.
            buttonOk.Enabled = isValid;
        }
    }
}
