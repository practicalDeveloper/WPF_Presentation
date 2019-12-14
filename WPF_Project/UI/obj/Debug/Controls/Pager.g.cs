﻿#pragma checksum "..\..\..\Controls\Pager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40FA87C7E020C60EC0DF3D2CDED240F81622991C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Core;
using Microsoft.Expression.Controls;
using Microsoft.Expression.Media;
using Microsoft.Expression.Media.Effects;
using Microsoft.Expression.Shapes;
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
using UI.Controls;


namespace UI.Controls {
    
    
    /// <summary>
    /// Pager
    /// </summary>
    public partial class Pager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 178 "..\..\..\Controls\Pager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Controls\Pager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FirstPageButton;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Controls\Pager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrevPageButton;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\Controls\Pager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox pagerList;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\Controls\Pager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPageButton;
        
        #line default
        #line hidden
        
        
        #line 282 "..\..\..\Controls\Pager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LastPageButton;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/controls/pager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\Pager.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.FirstPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\..\Controls\Pager.xaml"
            this.FirstPageButton.Click += new System.Windows.RoutedEventHandler(this.FirstPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PrevPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 206 "..\..\..\Controls\Pager.xaml"
            this.PrevPageButton.Click += new System.Windows.RoutedEventHandler(this.PrevPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pagerList = ((System.Windows.Controls.ListBox)(target));
            
            #line 222 "..\..\..\Controls\Pager.xaml"
            this.pagerList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pagerList_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 223 "..\..\..\Controls\Pager.xaml"
            this.pagerList.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pagerList_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NextPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 268 "..\..\..\Controls\Pager.xaml"
            this.NextPageButton.Click += new System.Windows.RoutedEventHandler(this.NextPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LastPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 282 "..\..\..\Controls\Pager.xaml"
            this.LastPageButton.Click += new System.Windows.RoutedEventHandler(this.LastPageButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

