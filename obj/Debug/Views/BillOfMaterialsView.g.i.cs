#pragma checksum "..\..\..\Views\BillOfMaterialsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00BCD534D013C8DC302C8336AE989E8C5C03ABF1337264646E0563B87AEDF75F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CIMS.Views
{


    /// <summary>
    /// BillOfMaterialsView
    /// </summary>
    public partial class BillOfMaterialsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 22 "..\..\..\Views\BillOfMaterialsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel title;

#line default
#line hidden


#line 26 "..\..\..\Views\BillOfMaterialsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadHome;

#line default
#line hidden


#line 27 "..\..\..\Views\BillOfMaterialsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfileImage;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CIMS;component/views/billofmaterialsview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Views\BillOfMaterialsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.title = ((System.Windows.Controls.DockPanel)(target));
                    return;
                case 2:
                    this.LoadHome = ((System.Windows.Controls.Button)(target));
                    return;
                case 3:
                    this.ProfileImage = ((System.Windows.Controls.Image)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DockPanel Content;
        internal System.Windows.Controls.DockPanel LeftDock;
        internal System.Windows.Controls.WrapPanel Buttons;
        internal System.Windows.Controls.ComboBox Class1Names;
        internal System.Windows.Controls.ComboBox Class2Names;
        internal System.Windows.Controls.Button RefreshTable;
        internal System.Windows.Controls.Button DeleteData;
        internal System.Windows.Controls.Button SaveData;
        internal System.Windows.Controls.Button ClearFields;
    }
}

