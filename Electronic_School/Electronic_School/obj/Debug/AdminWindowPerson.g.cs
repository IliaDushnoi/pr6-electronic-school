﻿#pragma checksum "..\..\AdminWindowPerson.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F182714F3AE2822DC8F63D163123C3DECEA0EB1BBC7DA6560EC1E0AC1C853F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Electronic_School;
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


namespace Electronic_School {
    
    
    /// <summary>
    /// AdminWindowPerson
    /// </summary>
    public partial class AdminWindowPerson : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\AdminWindowPerson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddPerson;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AdminWindowPerson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdminWindowClose;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AdminWindowPerson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgUsers;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AdminWindowPerson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditPass;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AdminWindowPerson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditData;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AdminWindowPerson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeletePerson;
        
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
            System.Uri resourceLocater = new System.Uri("/Electronic_School;component/adminwindowperson.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindowPerson.xaml"
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
            this.btnAddPerson = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AdminWindowPerson.xaml"
            this.btnAddPerson.Click += new System.Windows.RoutedEventHandler(this.btnAddPerson_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAdminWindowClose = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AdminWindowPerson.xaml"
            this.btnAdminWindowClose.Click += new System.Windows.RoutedEventHandler(this.btnAdminWindowClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgUsers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btnEditPass = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AdminWindowPerson.xaml"
            this.btnEditPass.Click += new System.Windows.RoutedEventHandler(this.btnEditPass_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEditData = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AdminWindowPerson.xaml"
            this.btnEditData.Click += new System.Windows.RoutedEventHandler(this.btnEditData_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDeletePerson = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AdminWindowPerson.xaml"
            this.btnDeletePerson.Click += new System.Windows.RoutedEventHandler(this.btnDeletePerson_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

