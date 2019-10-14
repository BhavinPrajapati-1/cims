using System.Windows;
using System.Windows.Controls;

namespace CIMS.Views
{
    public partial class SupplierView : UserControl
    {
        private readonly MainWindowView main = (MainWindowView)Application.Current.MainWindow;
        public SupplierView()
        {
            InitializeComponent();
        }
    }
}
