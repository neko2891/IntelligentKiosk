﻿#pragma checksum "C:\Users\v-caspch\Desktop\IntelligentKiosk\Controls\ImageWithFaceBorderUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A6B7B21ACD4D9C633155459D617ED91"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls
{
    partial class ImageWithFaceBorderUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Controls\ImageWithFaceBorderUserControl.xaml line 1
                {
                    this.userControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                    ((global::Windows.UI.Xaml.Controls.UserControl)this.userControl).DataContextChanged += this.OnDataContextChanged;
                }
                break;
            case 2: // Controls\ImageWithFaceBorderUserControl.xaml line 15
                {
                    this.hostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.hostGrid).SizeChanged += this.OnImageSizeChanged;
                }
                break;
            case 3: // Controls\ImageWithFaceBorderUserControl.xaml line 23
                {
                    this.progressIndicator = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 4: // Controls\ImageWithFaceBorderUserControl.xaml line 16
                {
                    this.imageControl = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imageControl).SizeChanged += this.OnImageSizeChanged;
                }
                break;
            case 5: // Controls\ImageWithFaceBorderUserControl.xaml line 18
                {
                    this.bitmapImage = (global::Windows.UI.Xaml.Media.Imaging.BitmapImage)(target);
                    ((global::Windows.UI.Xaml.Media.Imaging.BitmapImage)this.bitmapImage).ImageOpened += this.OnBitmapImageOpened;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

