﻿#pragma checksum "..\..\ToetsKiezen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6FF5672B8BCAD8CA227742C85B298148"
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
    /// ToetsKiezen
    /// </summary>
    public partial class ToetsKiezen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUser;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btTerug;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbcontent;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent_Copy;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent_Copy1;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent_Copy2;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKiesVak;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKiesLesonderdeel;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\ToetsKiezen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btVerder;
        
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
            System.Uri resourceLocater = new System.Uri("/OWL-LEARN;component/toetskiezen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ToetsKiezen.xaml"
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
            this.lbUser = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btTerug = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ToetsKiezen.xaml"
            this.btTerug.Click += new System.Windows.RoutedEventHandler(this.btTerug_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbcontent = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbContent_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbContent_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbContent_Copy2 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cbKiesVak = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\ToetsKiezen.xaml"
            this.cbKiesVak.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbKiesVak_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbKiesLesonderdeel = ((System.Windows.Controls.ComboBox)(target));
            
            #line 67 "..\..\ToetsKiezen.xaml"
            this.cbKiesLesonderdeel.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbKiesLO_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btVerder = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\ToetsKiezen.xaml"
            this.btVerder.Click += new System.Windows.RoutedEventHandler(this.btVerder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

