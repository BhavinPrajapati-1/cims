﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CIMS.View
{
    public partial class SupplierView : UserControl
    {
        private readonly MainWindow main = (MainWindow)Application.Current.MainWindow;
        public SupplierView()
        {
            InitializeComponent();
            this.DataContext = main.viewModel;
        }
    }
}
