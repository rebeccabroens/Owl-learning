﻿#pragma checksum "..\..\LeerlingForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F69B1A0375B78A768539C50138BD0205"
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
    /// LeerlingForm
    /// </summary>
    public partial class LeerlingForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\LeerlingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btTerug;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\LeerlingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUser;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\LeerlingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbVakken;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\LeerlingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btVerder;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\LeerlingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btToets;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\LeerlingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbLesOnderdelen;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\LeerlingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbLes;
        
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
            System.Uri resourceLocater = new System.Uri("/OWL-LEARN;component/leerlingform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LeerlingForm.xaml"
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
            
            #line 16 "..\..\LeerlingForm.xaml"
            this.btTerug.Click += new System.Windows.RoutedEventHandler(this.btTerug_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbUser = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbVakken = ((System.Windows.Controls.ListBox)(target));
            
            #line 50 "..\..\LeerlingForm.xaml"
            this.lbVakken.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbVakken_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btVerder = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\LeerlingForm.xaml"
            this.btVerder.Click += new System.Windows.RoutedEventHandler(this.btVerder_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btToets = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\LeerlingForm.xaml"
            this.btToets.Click += new System.Windows.RoutedEventHandler(this.btToets_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbLesOnderdelen = ((System.Windows.Controls.ListBox)(target));
            
            #line 102 "..\..\LeerlingForm.xaml"
            this.lbLesOnderdelen.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbLesOnderdelen_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbLes = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

