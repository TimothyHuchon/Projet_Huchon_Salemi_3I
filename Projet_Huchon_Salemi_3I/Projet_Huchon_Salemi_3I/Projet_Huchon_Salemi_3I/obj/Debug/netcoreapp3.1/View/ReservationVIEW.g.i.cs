﻿#pragma checksum "..\..\..\..\View\ReservationVIEW.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0F883970D4889BB356658B31BA2323B80CB85813"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Projet_Huchon_Salemi_3I.View;
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


namespace Projet_Huchon_Salemi_3I.View {
    
    
    /// <summary>
    /// ReservationVIEW
    /// </summary>
    public partial class ReservationVIEW : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\View\ReservationVIEW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txtCat;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\ReservationVIEW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txtBalade;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\ReservationVIEW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txtvelo;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\View\ReservationVIEW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txtPass;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\View\ReservationVIEW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock forfait;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\View\ReservationVIEW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock placeRest;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projet_Huchon_Salemi_3I;component/view/reservationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ReservationVIEW.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtCat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.txtBalade = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\..\View\ReservationVIEW.xaml"
            this.txtBalade.DropDownOpened += new System.EventHandler(this.txtBalade_DropDownOpened);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\..\View\ReservationVIEW.xaml"
            this.txtBalade.DropDownClosed += new System.EventHandler(this.txtBalade_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtvelo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\..\..\View\ReservationVIEW.xaml"
            this.txtvelo.DropDownOpened += new System.EventHandler(this.txtvelo_DropDownOpened);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtPass = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.forfait = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.placeRest = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 77 "..\..\..\..\View\ReservationVIEW.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 83 "..\..\..\..\View\ReservationVIEW.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_clear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

