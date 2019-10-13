using MahApps.Metro.Controls;
using System.Windows;

namespace CIMS
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.LoadHome.Visibility = Visibility.Hidden;
            this.profileButton.Visibility = Visibility.Hidden;
            this.Height = 600;
            this.Width = 600;
        }
    }

}

