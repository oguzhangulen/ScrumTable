﻿#pragma checksum "..\..\UCHistoryView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284535B394733FA48DE9837C0D6462AFA3C732D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using Oguzhan.Scrum.WPF;
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


namespace Oguzhan.Scrum.WPF {
    
    
    /// <summary>
    /// UCHistoryView
    /// </summary>
    public partial class UCHistoryView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\UCHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ElementList;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UCHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Value;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UCHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_NotStarted;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UCHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_InProgress;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UCHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Done;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UCHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Delete;
        
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
            System.Uri resourceLocater = new System.Uri("/Oguzhan.Scrum.WPF;component/uchistoryview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UCHistoryView.xaml"
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
            this.ElementList = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txt_Value = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btn_NotStarted = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\UCHistoryView.xaml"
            this.btn_NotStarted.Click += new System.Windows.RoutedEventHandler(this.btn_NotStarted_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_InProgress = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\UCHistoryView.xaml"
            this.btn_InProgress.Click += new System.Windows.RoutedEventHandler(this.btn_InProgress_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Done = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\UCHistoryView.xaml"
            this.btn_Done.Click += new System.Windows.RoutedEventHandler(this.btn_Done_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\UCHistoryView.xaml"
            this.btn_Delete.Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

