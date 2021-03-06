﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "958712F3629003E16F33FAE5222F9B238E83D7DCBA227923D9F07A4F75E329C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fish_Detector;
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


namespace Fish_Detector {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image originalImage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image resultImage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image preprocessingImage;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadImageButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveImageButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox adaptiveHistogramEqualizationCheckBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox adaptiveKernelSizeCheckBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox adaptiveSigmaCheckBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox adaptiveThresholdCheckBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kernelSizeTextBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sigmaXTextBox;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sigmaYTextBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox thresholdTextBox;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider kernelSizeSlider;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sigmaXSlider;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sigmaYSlider;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider thresholdSlider;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock preprocessingTimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock detectionTimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock objectPositionXTextBox;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock objectPositionYTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Fish_Detector;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.originalImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.resultImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.preprocessingImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.loadImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.loadImageButton.Click += new System.Windows.RoutedEventHandler(this.LoadImage);
            
            #line default
            #line hidden
            return;
            case 5:
            this.saveImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.saveImageButton.Click += new System.Windows.RoutedEventHandler(this.SaveImage);
            
            #line default
            #line hidden
            return;
            case 6:
            this.adaptiveHistogramEqualizationCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.adaptiveHistogramEqualizationCheckBox.Checked += new System.Windows.RoutedEventHandler(this.AdaptiveHistogramEqualizationChecked);
            
            #line default
            #line hidden
            
            #line 56 "..\..\MainWindow.xaml"
            this.adaptiveHistogramEqualizationCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.AdaptiveHistogramEqualizationUnchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.adaptiveKernelSizeCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.adaptiveKernelSizeCheckBox.Checked += new System.Windows.RoutedEventHandler(this.AdaptiveKernelSizeChecked);
            
            #line default
            #line hidden
            
            #line 57 "..\..\MainWindow.xaml"
            this.adaptiveKernelSizeCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.AdaptiveKernelSizeUnchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.adaptiveSigmaCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.adaptiveSigmaCheckBox.Checked += new System.Windows.RoutedEventHandler(this.AdaptiveSigmaChecked);
            
            #line default
            #line hidden
            
            #line 58 "..\..\MainWindow.xaml"
            this.adaptiveSigmaCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.AdaptiveSigmanUnchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.adaptiveThresholdCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.adaptiveThresholdCheckBox.Checked += new System.Windows.RoutedEventHandler(this.AdaptiveThresholdChecked);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.adaptiveThresholdCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.AdaptiveThresholdUnchecked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.kernelSizeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.sigmaXTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.sigmaYTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.thresholdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.kernelSizeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 89 "..\..\MainWindow.xaml"
            this.kernelSizeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.KernelSizeSliderChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.sigmaXSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 90 "..\..\MainWindow.xaml"
            this.sigmaXSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SigmaXSliderChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.sigmaYSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 91 "..\..\MainWindow.xaml"
            this.sigmaYSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SigmaYSliderChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.thresholdSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 92 "..\..\MainWindow.xaml"
            this.thresholdSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ThresholdSliderChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.preprocessingTimeTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 19:
            this.detectionTimeTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 20:
            this.objectPositionXTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 21:
            this.objectPositionYTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

