using System.Windows;
using System.Windows.Controls;

namespace CIMS.View
{
    public partial class SupplierView : UserControl
    {
        private readonly MainWindow main = (MainWindow)Application.Current.MainWindow;
        public SupplierView()
        {
            InitializeComponent();
        }
    }
}
