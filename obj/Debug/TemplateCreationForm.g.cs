﻿#pragma checksum "..\..\TemplateCreationForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92AB706A3773DA1D70326981DC25468B8981F6EBFFC8FBB61777E283795615B2"
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


namespace Spicy {
    
    
    /// <summary>
    /// TemplateCreationForm
    /// </summary>
    public partial class TemplateCreationForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\TemplateCreationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Spicy.TemplateCreationForm TemplateCreationWindow;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TemplateCreationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TemplateName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TemplateCreationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListOfSounds;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TemplateCreationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListOfIncluded;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\TemplateCreationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateTemplateButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\TemplateCreationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SoundVolumeSlider;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\TemplateCreationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SoundRepetitionRateTextbox;
        
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
            System.Uri resourceLocater = new System.Uri("/Spicy;component/templatecreationform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TemplateCreationForm.xaml"
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
            this.TemplateCreationWindow = ((Spicy.TemplateCreationForm)(target));
            return;
            case 2:
            this.TemplateName = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\TemplateCreationForm.xaml"
            this.TemplateName.KeyUp += new System.Windows.Input.KeyEventHandler(this.TemplateName_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListOfSounds = ((System.Windows.Controls.ListBox)(target));
            
            #line 21 "..\..\TemplateCreationForm.xaml"
            this.ListOfSounds.Loaded += new System.Windows.RoutedEventHandler(this.ListOfSounds_Loaded);
            
            #line default
            #line hidden
            
            #line 21 "..\..\TemplateCreationForm.xaml"
            this.ListOfSounds.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListOfSounds_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\TemplateCreationForm.xaml"
            this.ListOfSounds.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListOfSounds_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 21 "..\..\TemplateCreationForm.xaml"
            this.ListOfSounds.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ListOfSounds_MouseLeave);
            
            #line default
            #line hidden
            
            #line 21 "..\..\TemplateCreationForm.xaml"
            this.ListOfSounds.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListOfSounds_PreviewMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 21 "..\..\TemplateCreationForm.xaml"
            this.ListOfSounds.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.ListOfSounds_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 21 "..\..\TemplateCreationForm.xaml"
            this.ListOfSounds.Drop += new System.Windows.DragEventHandler(this.ListOfSounds_Drop);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListOfIncluded = ((System.Windows.Controls.ListBox)(target));
            
            #line 22 "..\..\TemplateCreationForm.xaml"
            this.ListOfIncluded.Drop += new System.Windows.DragEventHandler(this.ListOfIncluded_Drop);
            
            #line default
            #line hidden
            
            #line 22 "..\..\TemplateCreationForm.xaml"
            this.ListOfIncluded.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListOfIncluded_PreviewMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 22 "..\..\TemplateCreationForm.xaml"
            this.ListOfIncluded.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListOfIncluded_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\TemplateCreationForm.xaml"
            this.ListOfIncluded.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListOfIncluded_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 22 "..\..\TemplateCreationForm.xaml"
            this.ListOfIncluded.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.ListOfIncluded_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 22 "..\..\TemplateCreationForm.xaml"
            this.ListOfIncluded.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ListOfIncluded_MouseLeave);
            
            #line default
            #line hidden
            
            #line 22 "..\..\TemplateCreationForm.xaml"
            this.ListOfIncluded.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListOfIncluded_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreateTemplateButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\TemplateCreationForm.xaml"
            this.CreateTemplateButton.Click += new System.Windows.RoutedEventHandler(this.CreateTemplateButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SoundVolumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 38 "..\..\TemplateCreationForm.xaml"
            this.SoundVolumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SoundVolumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SoundRepetitionRateTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\TemplateCreationForm.xaml"
            this.SoundRepetitionRateTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SoundRepetitionRateTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

