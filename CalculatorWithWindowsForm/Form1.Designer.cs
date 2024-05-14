namespace CalculatorWithWindowsForm
{
    partial class Form1
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
            LoginLbl = new Label();
            PasswordLbl = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            PasswordButton = new Button();
            SuspendLayout();
            // 
            // LoginLbl
            // 
            LoginLbl.AutoSize = true;
            LoginLbl.Location = new Point(243, 127);
            LoginLbl.Name = "LoginLbl";
            LoginLbl.Size = new Size(46, 20);
            LoginLbl.TabIndex = 0;
            LoginLbl.Text = "Login";
            LoginLbl.Click += LoginLabel;
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(219, 170);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(70, 20);
            PasswordLbl.TabIndex = 1;
            PasswordLbl.Text = "Password";
            PasswordLbl.Click += PasswordLabel;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(297, 124);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(125, 27);
            LoginTextBox.TabIndex = 2;
            LoginTextBox.TextChanged += InputLogin;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(297, 167);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += InputPassword;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(268, 236);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginClick;
            // 
            // PasswordButton
            // 
            PasswordButton.Location = new Point(368, 236);
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Size = new Size(94, 29);
            PasswordButton.TabIndex = 5;
            PasswordButton.Text = "Register";
            PasswordButton.UseVisualStyleBackColor = true;
            PasswordButton.Click += RegisterClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 473);
            Controls.Add(PasswordButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(PasswordLbl);
            Controls.Add(LoginLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLbl;
        private Label PasswordLbl;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button PasswordButton;
    }
}
