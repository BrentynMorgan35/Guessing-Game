﻿#pragma checksum "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55349CB8557C929F69D4B32C232A0149FE33C71C"
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
using Wilsons_challenge_Blinky;


namespace Wilsons_challenge_Blinky {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxEnterNumber;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonGo;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HighLowWin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label player1print;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label player3print;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label player2print;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxEasy;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxMedium;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxHard;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Wilsons challenge-Blinky;V1.0.0.0;component/guessing-game/wilsons%20challenge-bl" +
                    "inky/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textboxEnterNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.buttonGo = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\Guessing-Game\Wilsons challenge-Blinky\MainWindow.xaml"
            this.buttonGo.Click += new System.Windows.RoutedEventHandler(this.buttonGo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HighLowWin = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.player1print = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.player3print = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.player2print = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.checkBoxEasy = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.checkBoxMedium = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.checkBoxHard = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
