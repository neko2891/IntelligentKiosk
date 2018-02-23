﻿#pragma checksum "C:\Users\v-caspch\Desktop\IntelligentKiosk\Views\BingVisualSearch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E16C8EC563056253D1928F59328F849F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views
{
    partial class BingVisualSearch : 
        global::Windows.UI.Xaml.Controls.Page, 
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
            case 1: // Views\BingVisualSearch.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).SizeChanged += this.OnPageSizeChanged;
                }
                break;
            case 2: // Views\BingVisualSearch.xaml line 80
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3: // Views\BingVisualSearch.xaml line 115
                {
                    this.landingMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Views\BingVisualSearch.xaml line 149
                {
                    this.resultsDetails = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 5: // Views\BingVisualSearch.xaml line 151
                {
                    this.resultsGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 6: // Views\BingVisualSearch.xaml line 152
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 7: // Views\BingVisualSearch.xaml line 153
                {
                    this.searchErrorTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\BingVisualSearch.xaml line 142
                {
                    this.resultTypeComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.resultTypeComboBox).SelectionChanged += this.OnResultTypeSelectionChanged;
                }
                break;
            case 9: // Views\BingVisualSearch.xaml line 143
                {
                    this.celebrityResultType = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 10: // Views\BingVisualSearch.xaml line 144
                {
                    this.similarImagesResultType = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 11: // Views\BingVisualSearch.xaml line 145
                {
                    this.similarProductsResultType = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 12: // Views\BingVisualSearch.xaml line 131
                {
                    this.webCamHostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13: // Views\BingVisualSearch.xaml line 136
                {
                    this.imageWithFacesControl = (global::IntelligentKioskSample.Controls.ImageWithFaceBorderUserControl)(target);
                }
                break;
            case 14: // Views\BingVisualSearch.xaml line 132
                {
                    this.imageFromCameraWithFaces = (global::IntelligentKioskSample.Controls.ImageWithFaceBorderUserControl)(target);
                }
                break;
            case 15: // Views\BingVisualSearch.xaml line 133
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                }
                break;
            case 16: // Views\BingVisualSearch.xaml line 96
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element16 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element16).Click += this.OnWebCamButtonClicked;
                }
                break;
            case 17: // Views\BingVisualSearch.xaml line 98
                {
                    this.PicturesAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 18: // Views\BingVisualSearch.xaml line 100
                {
                    this.imageSearchFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 19: // Views\BingVisualSearch.xaml line 101
                {
                    global::IntelligentKioskSample.Controls.ImageSearchUserControl element19 = (global::IntelligentKioskSample.Controls.ImageSearchUserControl)(target);
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)element19).OnImageSearchCompleted += this.OnImageSearchCompleted;
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)element19).OnImageSearchCanceled += this.OnImageSearchCanceled;
                }
                break;
            case 20: // Views\BingVisualSearch.xaml line 84
                {
                    this.favoriteImagePickerFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 21: // Views\BingVisualSearch.xaml line 85
                {
                    this.favoritePhotosGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.favoritePhotosGridView).SelectionChanged += this.OnFavoriteSelectionChanged;
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

