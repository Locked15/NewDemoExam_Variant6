﻿#pragma checksum "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A7A366A225262079374C35486EF042C185A2B7C3B333265A0FC5417E5D55EA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using _41_размер.Windows;


namespace _41_размер.Windows {
    
    
    /// <summary>
    /// OrdersWindow
    /// </summary>
    public partial class OrdersWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectOrdersSort;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectOrdersFilter;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AllOrdersList;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoToPreviousPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/41 размер;component/windows/displaywindows/orderswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
            ((_41_размер.Windows.OrdersWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
            ((_41_размер.Windows.OrdersWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
            ((_41_размер.Windows.OrdersWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SelectOrdersSort = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.SelectOrdersFilter = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.AllOrdersList = ((System.Windows.Controls.ListView)(target));
            
            #line 59 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
            this.AllOrdersList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.AllOrdersList_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GoToPreviousPage = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Windows\DisplayWindows\OrdersWindow.xaml"
            this.GoToPreviousPage.Click += new System.Windows.RoutedEventHandler(this.GoToPreviousPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

