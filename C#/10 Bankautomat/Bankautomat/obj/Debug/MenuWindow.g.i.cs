﻿#pragma checksum "..\..\MenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B64003B770E39086649DA48E0C7418CC5A6C83230D0F12DF91823E91355459C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Bankautomat;
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


namespace Bankautomat {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKontostandAbfragen;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEinzahlen;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAuszahlen;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtBegruessung;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbmelden;
        
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
            System.Uri resourceLocater = new System.Uri("/Bankautomat;component/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuWindow.xaml"
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
            this.btnKontostandAbfragen = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\MenuWindow.xaml"
            this.btnKontostandAbfragen.Click += new System.Windows.RoutedEventHandler(this.btnKontostandAbfragen_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnEinzahlen = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\MenuWindow.xaml"
            this.BtnEinzahlen.Click += new System.Windows.RoutedEventHandler(this.BtnEinzahlen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnAuszahlen = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MenuWindow.xaml"
            this.BtnAuszahlen.Click += new System.Windows.RoutedEventHandler(this.BtnAuszahlen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtBegruessung = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnAbmelden = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MenuWindow.xaml"
            this.btnAbmelden.Click += new System.Windows.RoutedEventHandler(this.btnAbmelden_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
