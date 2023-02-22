﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62986942EF86B3073E88185ACC87B2C74B0FF13646F87F9652B5C99703902C3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
using Tic_Tac_Toe;


namespace Tic_Tac_Toe {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPointsA;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPointsB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgTopLeft;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgTopMiddle;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgTopRight;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgMiddleLeft;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgMiddleMiddle;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgMiddleRight;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBottomRight;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBottomMiddle;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBottomLeft;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlayAgain;
        
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
            System.Uri resourceLocater = new System.Uri("/Tic Tac Toe;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.lblPointsA = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblPointsB = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.imgTopLeft = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.imgTopLeft.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgTopLeft_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgTopMiddle = ((System.Windows.Controls.Image)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.imgTopMiddle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgTopMiddle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgTopRight = ((System.Windows.Controls.Image)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.imgTopRight.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgTopRight_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imgMiddleLeft = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.imgMiddleLeft.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgMiddleLeft_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.imgMiddleMiddle = ((System.Windows.Controls.Image)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.imgMiddleMiddle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgMiddleMiddle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.imgMiddleRight = ((System.Windows.Controls.Image)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.imgMiddleRight.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgMiddleRight_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.imgBottomRight = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.imgBottomRight.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgBottomRight_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.imgBottomMiddle = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.imgBottomMiddle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgBottomMiddle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.imgBottomLeft = ((System.Windows.Controls.Image)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.imgBottomLeft.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgBottomLeft_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnPlayAgain = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.btnPlayAgain.Click += new System.Windows.RoutedEventHandler(this.btnPlayAgain_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

