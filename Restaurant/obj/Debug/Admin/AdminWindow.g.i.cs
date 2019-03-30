﻿#pragma checksum "..\..\..\Admin\AdminWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AFFA277838E010823DCBA43FF62F1A7788565EAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Restaurant.Admin;
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


namespace Restaurant.Admin {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl adminMenu;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem types_dishes;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTypeDish;
        
        #line default
        #line hidden
        
        /// <summary>
        /// typesDishesGrid Name Field
        /// </summary>
        
        #line 20 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.DataGrid typesDishesGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem statuses;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStatus;
        
        #line default
        #line hidden
        
        /// <summary>
        /// statusesGrid Name Field
        /// </summary>
        
        #line 51 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.DataGrid statusesGrid;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem WaitersTab;
        
        #line default
        #line hidden
        
        /// <summary>
        /// waitersGrid Name Field
        /// </summary>
        
        #line 86 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.DataGrid waitersGrid;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddWaiterBtn;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logOutButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/admin/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin\AdminWindow.xaml"
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
            this.adminMenu = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.types_dishes = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.AddTypeDish = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Admin\AdminWindow.xaml"
            this.AddTypeDish.Click += new System.Windows.RoutedEventHandler(this.AddTypeDish_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.typesDishesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.statuses = ((System.Windows.Controls.TabItem)(target));
            return;
            case 8:
            this.AddStatus = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Admin\AdminWindow.xaml"
            this.AddStatus.Click += new System.Windows.RoutedEventHandler(this.AddStatus_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.statusesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.WaitersTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 13:
            this.waitersGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 16:
            this.AddWaiterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\Admin\AdminWindow.xaml"
            this.AddWaiterBtn.Click += new System.Windows.RoutedEventHandler(this.AddWaiterBtn_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.logOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\Admin\AdminWindow.xaml"
            this.logOutButton.Click += new System.Windows.RoutedEventHandler(this.LogOutButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 32 "..\..\..\Admin\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.updateTypeDishBtn_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 33 "..\..\..\Admin\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteTypeBtn_Click);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 63 "..\..\..\Admin\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.updateStatusBtn_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 64 "..\..\..\Admin\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteStatusBtn_Click);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 104 "..\..\..\Admin\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.updateWaiterBtn_Click);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 105 "..\..\..\Admin\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteWaiterBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

