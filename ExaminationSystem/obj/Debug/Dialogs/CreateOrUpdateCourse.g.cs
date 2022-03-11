﻿#pragma checksum "..\..\..\Dialogs\CreateOrUpdateCourse.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC16708E95B72C0A7827B6B6352F210821B0668B70BF18491D42AD8499FC20DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExaminationSystem;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Command;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
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


namespace ExaminationSystem {
    
    
    /// <summary>
    /// CreateOrUpdateCourse
    /// </summary>
    public partial class CreateOrUpdateCourse : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 15 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Basic_Details;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox txtcourseName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox txtDuration;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox txtTopics;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.ComboBox ComboInstructor;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.ComboBox ComboDepartment;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/ExaminationSystem;component/dialogs/createorupdatecourse.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
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
            
            #line 12 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Basic_Details = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txtcourseName = ((HandyControl.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDuration = ((HandyControl.Controls.TextBox)(target));
            return;
            case 5:
            this.txtTopics = ((HandyControl.Controls.TextBox)(target));
            return;
            case 6:
            this.ComboInstructor = ((HandyControl.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            this.ComboInstructor.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.ComboInstructor_DataContextChanged);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            this.ComboInstructor.Loaded += new System.Windows.RoutedEventHandler(this.ComboInstructor_Loaded);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboDepartment = ((HandyControl.Controls.ComboBox)(target));
            
            #line 40 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            this.ComboDepartment.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.ComboDepartment_DataContextChanged);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            this.ComboDepartment.Loaded += new System.Windows.RoutedEventHandler(this.ComboDepartment_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 34 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.chkInstructor_Checked);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 43 "..\..\..\Dialogs\CreateOrUpdateCourse.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.chkDepartment_Checked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

