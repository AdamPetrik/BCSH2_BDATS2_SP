using Oracle.ManagedDataAccess.Client;
namespace SpravaObjednavek_GUI_App
{
    public partial class LoginForm : Form
    {
        private OracleConnection? conn;
        private bool dbError = false;

        public LoginForm()
        {
            InitializeComponent();
            conn = DatabaseConnection.GetConnection();
            if (conn == null)
            {
                MessageBox.Show("Navázání spojení s databází se nezdaøilo.\nZkontrolujte internetové pøipojení a spuste aplikaci znovu.", "Chyba pøihlášení", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbError = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Pøihlášení se nezdaøilo. Zkontrolujte uivatelské jméno a heslo.", "Chyba pøihlášení", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Pøihlášení uivatele
                
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if(dbError)
            {
                this.Close();
            }
        }
    }
}