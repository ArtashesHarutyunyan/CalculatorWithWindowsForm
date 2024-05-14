using Calculator;
namespace CalculatorWithWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginLabel(object sender, EventArgs e)
        {

        }
        private void PasswordLabel(object sender, EventArgs e)
        {

        }

        private void InputLogin(object sender, EventArgs e)
        {

        }

        private void InputPassword(object sender, EventArgs e)
        {

        }



        private void LoginClick(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            bool loginSuccessful = CheckLogin(LoginTextBox.Text, PasswordTextBox.Text);
            if (loginSuccessful)
            {
                FormCalculator calculatorForm = new FormCalculator();
                calculatorForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials. Please try again.");
            }
        }
        private void RegisterClick(object sender, EventArgs e)
        {

        }
        private bool CheckLogin(string username, string password)
        {
           return true;
        }
    }


}

