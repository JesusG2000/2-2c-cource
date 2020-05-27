﻿#pragma checksum "..\..\..\view\DialogsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D2B18CE14FD83FBF0D31E4A0819094DD979653DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Music.view;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Music.view {
    
    
    /// <summary>
    /// DialogsWindow
    /// </summary>
    public partial class DialogsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\view\DialogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.CheckComboBox registeredUsers;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\view\DialogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox dialogList;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\view\DialogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid userDialogGrid;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\view\DialogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox messageTextField;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\view\DialogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendTextButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\view\DialogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearDialogButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Music;component/view/dialogswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\DialogsWindow.xaml"
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
            this.registeredUsers = ((Xceed.Wpf.Toolkit.CheckComboBox)(target));
            return;
            case 2:
            this.dialogList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.userDialogGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 55 "..\..\..\view\DialogsWindow.xaml"
            this.userDialogGrid.Loaded += new System.Windows.RoutedEventHandler(this.loadInUserDialogGrid);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\view\DialogsWindow.xaml"
            this.userDialogGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.selectUserFoChat);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 61 "..\..\..\view\DialogsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goBack);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 62 "..\..\..\view\DialogsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addInDialogs);
            
            #line default
            #line hidden
            return;
            case 6:
            this.messageTextField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.sendTextButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\view\DialogsWindow.xaml"
            this.sendTextButton.Click += new System.Windows.RoutedEventHandler(this.sendMessage);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clearDialogButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\view\DialogsWindow.xaml"
            this.clearDialogButton.Click += new System.Windows.RoutedEventHandler(this.clearDiaolog);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

