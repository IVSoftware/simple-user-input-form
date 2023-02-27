namespace simple_user_input_form
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowUserInput = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonShowUserInput
            // 
            this.buttonShowUserInput.Location = new System.Drawing.Point(21, 25);
            this.buttonShowUserInput.Name = "buttonShowUserInput";
            this.buttonShowUserInput.Size = new System.Drawing.Size(177, 34);
            this.buttonShowUserInput.TabIndex = 0;
            this.buttonShowUserInput.Text = "Show User Input";
            this.buttonShowUserInput.UseVisualStyleBackColor = true;
            this.buttonShowUserInput.Click += new System.EventHandler(this.buttonShowUserInput_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(236, 25);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(188, 176);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonShowUserInput);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowUserInput;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}
