﻿#pragma checksum "..\..\LesonderwerpToevoegen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D291CE7E609D7AFF320AF1D37FA80675"
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


namespace OWL_LEARN {
    
    
    /// <summary>
    /// LesonderwerpToevoegen
    /// </summary>
    public partial class LesonderwerpToevoegen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\LesonderwerpToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btTerug;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\LesonderwerpToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btOpslaan;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\LesonderwerpToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNaam;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\LesonderwerpToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbVoegin;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\LesonderwerpToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\LesonderwerpToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/OWL-LEARN;component/lesonderwerptoevoegen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LesonderwerpToevoegen.xaml"
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
            this.btTerug = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\LesonderwerpToevoegen.xaml"
            this.btTerug.Click += new System.Windows.RoutedEventHandler(this.btTerug_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btOpslaan = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\LesonderwerpToevoegen.xaml"
            this.btOpslaan.Click += new System.Windows.RoutedEventHandler(this.btOpslaan_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lbVoegin = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbContent = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbContent_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

