using Oracle.ManagedDataAccess.Client;
namespace SpravaObjednavek_GUI_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DatabaseConnection.GetConnection();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                statusLabel.Text = "DB connect successfull";
            }
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}