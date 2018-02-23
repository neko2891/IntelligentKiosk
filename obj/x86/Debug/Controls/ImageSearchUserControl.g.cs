﻿#pragma checksum "C:\Users\v-caspch\Desktop\IntelligentKiosk\Controls\ImageSearchUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE363DE8DE4529724B30F57EA81D364A"
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
    partial class ImageSearchUserControl : 
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
            case 1: // Controls\ImageSearchUserControl.xaml line 1
                {
                    this.SearchControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2: // Controls\ImageSearchUserControl.xaml line 66
                {
                    this.imageResultsGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.imageResultsGrid).SelectionChanged += this.OnImageResultSelectionChanged;
                }
                break;
            case 3: // Controls\ImageSearchUserControl.xaml line 74
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 4: // Controls\ImageSearchUserControl.xaml line 77
                {
                    this.addSelectedPhotosButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.addSelectedPhotosButton).Click += this.OnAcceptButtonClicked;
                }
                break;
            case 5: // Controls\ImageSearchUserControl.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element5 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element5).Click += this.OnCancelButtonClicked;
                }
                break;
            case 6: // Controls\ImageSearchUserControl.xaml line 33
                {
                    this.autoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggestBox).QuerySubmitted += this.onQuerySubmitted;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggestBox).TextChanged += this.onTextChanged;
                }
                break;
            case 7: // Controls\ImageSearchUserControl.xaml line 37
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.LoadImagesFromFileClicked;
                }
                break;
            case 8: // Controls\ImageSearchUserControl.xaml line 43
                {
                    this.cameraCaptureFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.cameraCaptureFlyout).Opened += this.OnCameraFlyoutOpened;
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.cameraCaptureFlyout).Closed += this.OnCameraFlyoutClosed;
                }
                break;
            case 9: // Controls\ImageSearchUserControl.xaml line 51
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                    ((global::IntelligentKioskSample.Controls.CameraControl)this.cameraControl).ImageCaptured += this.OnCameraImageCaptured;
                }
                break;
            case 10: // Controls\ImageSearchUserControl.xaml line 54
                {
                    this.autoCaptureToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.autoCaptureToggle).Toggled += this.OnCameraAutoCaptureToggleChanged;
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

