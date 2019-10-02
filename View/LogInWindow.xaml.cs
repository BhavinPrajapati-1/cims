using CIMS.ViewModel.DBConnection;
using MahApps.Metro.Controls;
using System.Windows;
using System.Data;

namespace CIMS
{
    public partial class LogInWindow : MetroWindow
    {
        private DataQueryParameters queryParam = new DataQueryParameters();
        private DataTable user = new DataTable();
        public LogInWindow()
        {
            InitializeComponent();
        }
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.userID.Text == "" && this.password.Password.ToString() == "") return;
            user = queryParam.CurrentUser(this.userID.Text, this.password.Password);
            if (user==null || user.Rows.Count==0)
            {
                this.logInMessage.Visibility = Visibility.Visible;
                this.userID.Text = "";
                this.password.Password = "";
                return;
            }
            this.logInMessage.Visibility = Visibility.Hidden;
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
