﻿#pragma checksum "..\..\..\Admin\AddTypeDish.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E9982427A2CE2FD535EB075E54B0D0943B123841"
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
    /// AddTypeDish
    /// </summary>
    public partial class AddTypeDish : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Admin\AddTypeDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Admin\AddTypeDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock typeDishToAdd;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Admin\AddTypeDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTypeDishBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Admin\AddTypeDish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox typeDishTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/admin/addtypedish.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin\AddTypeDish.xaml"
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
            
            #line 11 "..\..\..\Admin\AddTypeDish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Change_User);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\Admin\AddTypeDish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Help_Item);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\Admin\AddTypeDish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.About_Item);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 14 "..\..\..\Admin\AddTypeDish.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Program);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.typeDishToAdd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.addTypeDishBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Admin\AddTypeDish.xaml"
            this.addTypeDishBtn.Click += new System.Windows.RoutedEventHandler(this.AddTypeDishBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.typeDishTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

