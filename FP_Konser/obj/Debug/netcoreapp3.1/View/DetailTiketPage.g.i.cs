﻿#pragma checksum "..\..\..\..\View\DetailTiketPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D6142F20B76027ED950ABF82D3E010AA8157D591"
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
    /// DetailTiketPage
    /// </summary>
    public partial class DetailTiketPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtNamaTiket;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBannerTiket;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image iconExit;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtLokasi;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtOpengate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtJam;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTanggal;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\View\DetailTiketPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border btnPesan;
        
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
            System.Uri resourceLocater = new System.Uri("/FP_Konser;component/view/detailtiketpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\DetailTiketPage.xaml"
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
            this.txtNamaTiket = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.imgBannerTiket = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.iconExit = ((System.Windows.Controls.Image)(target));
            
            #line 24 "..\..\..\..\View\DetailTiketPage.xaml"
            this.iconExit.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.iconExit_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtLokasi = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtOpengate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtJam = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtTanggal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnPesan = ((System.Windows.Controls.Border)(target));
            
            #line 60 "..\..\..\..\View\DetailTiketPage.xaml"
            this.btnPesan.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnPesan_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

