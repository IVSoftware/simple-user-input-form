Your intuition is good here:
>I suspect my declaration of the text boxes as Public may not be the best approach.

It is more correct to keep UI elements `private` and expose the necessary value as a `public property` after making sure the input is valid.
***
**Properties**

Objectives for the user-input form:
- Provide two integer values V and H
- Make sure the public information is always valid (even if the internal UI state is not).

_Subscribe to text changed and visible changed events. This can be done either in the Designer view or in the form constructor as shown here._

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
        .
        .
        .
    }

***
**Text Changes**

Validate the form when changes are made to the UI. For example, this simple scheme looks at both textboxes any time the text changes in either one. If invalid text input is present, the `OK` button will be disabled.

[![user form validation][1]][1]

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
            textBoxV.BackColor = Color.White;
        }
        else
        {
            isValid = false;
            textBoxV.BackColor = Color.LightSalmon;
        }
        // Enable or disable the OK button based on
        // valid integer values of both textboxes.
        buttonOk.Enabled = isValid;
    }

 ***
 **Main Form**

Chances are, you want the user-input form to "remember" its previous values every time it is shown. For this reason, the main form will declare the dialog as a member variable and will be able to retrieve the integer values for `_userInputForm.V` and `_userInputForm.H` after first making sure that the input operation has not been cancelled.

[![main form][2]][2]

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


  [1]: https://i.stack.imgur.com/L5nqX.png
  [2]: https://i.stack.imgur.com/uMXmL.png