using Oracle.ManagedDataAccess.Client;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpravaObjednavek_GUI_WPF
{
    public partial class MainWindow : Window
    {
        private OracleConnection? conn;
        private bool dbError = false;

        public MainWindow()
        {
            InitializeComponent();
            //conn = DatabaseConnection.GetConnection();
            //if (conn == null)
            //{
            //    MessageBox.Show("Navázání spojení s databází se nezdařilo.\nZkontrolujte internetové připojení a spusťte aplikaci znovu.", "Chyba přihlášení");
            //    dbError = true;
            //}
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (usernameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Přihlášení se nezdařilo. Zkontrolujte uživatelské jméno a heslo.", "Chyba přihlášení");
            }
            else
            {
                //Přihlášení uživatele
                //AppWindow appWindow = new AppWindow();
                //appWindow.Show();
            }
        }

        private void guestBtn_Click(object sender, RoutedEventArgs e)
        {
            MainView app = new MainView();
            app.Show();
            Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (dbError)
            {
                this.Close();
            }
        }
    }
}