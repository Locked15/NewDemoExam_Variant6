﻿#pragma checksum "..\..\..\..\Windows\EditWindows\OrderFormation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20EBACE1536C0A0C1E6CC2DAFCFC7F1930D9F9E2D7FA592BD756450E2B60DD1C"
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
    /// OrderFormation
    /// </summary>
    public partial class OrderFormation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserInfoDesc;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserInfo;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PickerPoint;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker SelectDeliveryDate;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OrderFinalCost;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OrderFinalDiscount;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductsInOrder_ListView;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CurrentProductCount;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GeneratePdfDocumentation;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveOrderInDb;
        
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
            System.Uri resourceLocater = new System.Uri("/41 размер;component/windows/editwindows/orderformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
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
            
            #line 11 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
            ((_41_размер.Windows.OrderFormation)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
            ((_41_размер.Windows.OrderFormation)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserInfoDesc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.UserInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.PickerPoint = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
            this.PickerPoint.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PickerPoint_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SelectDeliveryDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.OrderFinalCost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.OrderFinalDiscount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ProductsInOrder_ListView = ((System.Windows.Controls.ListView)(target));
            
            #line 57 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
            this.ProductsInOrder_ListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductsInOrder_ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CurrentProductCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
            this.CurrentProductCount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CurrentProductCount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GeneratePdfDocumentation = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
            this.GeneratePdfDocumentation.Click += new System.Windows.RoutedEventHandler(this.GeneratePdfDocumentation_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SaveOrderInDb = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\Windows\EditWindows\OrderFormation.xaml"
            this.SaveOrderInDb.Click += new System.Windows.RoutedEventHandler(this.SaveOrderInDb_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

