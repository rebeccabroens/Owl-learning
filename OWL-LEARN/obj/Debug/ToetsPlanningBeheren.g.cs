﻿#pragma checksum "..\..\ToetsPlanningBeheren.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D64BD89FC30D63BF75EC78C8F4B2B4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OWL_LEARN;
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
    /// ToetsPlanningBeheren
    /// </summary>
    public partial class ToetsPlanningBeheren : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btTerug;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbVak;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent_Copy;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvLeerlingen;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbContent_Copy1;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPlanningen;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btVerwijder;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\ToetsPlanningBeheren.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAddToetsPlanning;
        
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
            System.Uri resourceLocater = new System.Uri("/OWL-LEARN;component/toetsplanningbeheren.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ToetsPlanningBeheren.xaml"
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
            
            #line 25 "..\..\ToetsPlanningBeheren.xaml"
            this.btTerug.Click += new System.Windows.RoutedEventHandler(this.btTerug_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbVak = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbContent_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lvLeerlingen = ((System.Windows.Controls.ListView)(target));
            
            #line 59 "..\..\ToetsPlanningBeheren.xaml"
            this.lvLeerlingen.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvLeerlingen_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lbContent = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbContent_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lvPlanningen = ((System.Windows.Controls.ListView)(target));
            
            #line 76 "..\..\ToetsPlanningBeheren.xaml"
            this.lvPlanningen.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvPlanningen_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btVerwijder = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\ToetsPlanningBeheren.xaml"
            this.btVerwijder.Click += new System.Windows.RoutedEventHandler(this.btVerwijder_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btAddToetsPlanning = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\ToetsPlanningBeheren.xaml"
            this.btAddToetsPlanning.Click += new System.Windows.RoutedEventHandler(this.btAddToetsPlanning_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

