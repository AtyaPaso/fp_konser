﻿#pragma checksum "..\..\..\..\View\ParentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DD2D0D1A52A6A20558148A651E89EC785C2D2BE0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FP_Konser.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace FP_Konser.View {
    
    
    /// <summary>
    /// ParentWindow
    /// </summary>
    public partial class ParentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\ParentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel userInfo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\ParentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtUserName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\ParentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmMain;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\ParentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border menuTooltop;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\ParentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnProfile;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\ParentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel btnOrder;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\ParentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnLogout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FP_Konser;component/view/parentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ParentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.userInfo = ((System.Windows.Controls.StackPanel)(target));
            
            #line 18 "..\..\..\..\View\ParentWindow.xaml"
            this.userInfo.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.userInfo_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtUserName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.frmMain = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            this.menuTooltop = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.btnProfile = ((System.Windows.Controls.TextBlock)(target));
            
            #line 31 "..\..\..\..\View\ParentWindow.xaml"
            this.btnProfile.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnProfile_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnOrder = ((System.Windows.Controls.DockPanel)(target));
            
            #line 34 "..\..\..\..\View\ParentWindow.xaml"
            this.btnOrder.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnOrder_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnLogout = ((System.Windows.Controls.TextBlock)(target));
            
            #line 41 "..\..\..\..\View\ParentWindow.xaml"
            this.btnLogout.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnLogout_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
