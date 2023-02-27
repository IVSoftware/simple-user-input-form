namespace simple_user_input_form
{
    partial class UserInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.labelV = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(349, 181);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 36);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.TabStop = false;
            this.buttonOk.Text = "OK";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(100, 93);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 31);
            this.textBoxH.TabIndex = 2;
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(100, 47);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 31);
            this.textBoxV.TabIndex = 1;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(51, 50);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(23, 25);
            this.labelV.TabIndex = 3;
            this.labelV.Text = "V";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(51, 96);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(25, 25);
            this.labelH.TabIndex = 3;
            this.labelH.Text = "H";
            // 
            // UserInputForm
            // 
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxV);
            this.Name = "UserInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //some other generated code omitted for brevity
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelH;
    }
}