﻿#pragma checksum "..\..\Manager.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8B1CEF10E9D03838A963230FF9B15104C850989ECD19DA5F38C5435C8D8F418E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using demo;


namespace demo {
    
    
    /// <summary>
    /// Manager
    /// </summary>
    public partial class Manager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Manager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button A_Guard;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Manager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button R_Guard;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Manager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button P_Details;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Manager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button G_Details;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Manager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Manager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Change_Password;
        
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
            System.Uri resourceLocater = new System.Uri("/demo;component/manager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Manager.xaml"
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
            this.A_Guard = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Manager.xaml"
            this.A_Guard.Click += new System.Windows.RoutedEventHandler(this.A_Guard_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.R_Guard = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Manager.xaml"
            this.R_Guard.Click += new System.Windows.RoutedEventHandler(this.R_Guard_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.P_Details = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Manager.xaml"
            this.P_Details.Click += new System.Windows.RoutedEventHandler(this.P_Details_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.G_Details = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Manager.xaml"
            this.G_Details.Click += new System.Windows.RoutedEventHandler(this.G_Details_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Logout = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Manager.xaml"
            this.Logout.Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Change_Password = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Manager.xaml"
            this.Change_Password.Click += new System.Windows.RoutedEventHandler(this.ChangePassword_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

