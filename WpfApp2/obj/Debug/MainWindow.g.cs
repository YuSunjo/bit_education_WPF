﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D71871966A944FE17BFCD1EC5576C5D850E309B9F03874D1689A73300591E8EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 263 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstMessages;
        
        #line default
        #line hidden
        
        
        #line 264 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkHandle;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((WpfApp2.MainWindow)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 246 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 248 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 252 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 253 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.DockPanel)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 255 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 258 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            
            #line 258 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.SomeKeyPressed);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lstMessages = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.chkHandle = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            
            #line 265 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

