﻿#pragma checksum "C:\Users\v-caspch\Desktop\IntelligentKiosk\Views\ImageCollectionInsights\ImageCollectionInsights.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2A9E2858E629BCD7B56F13AB3EF80EF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views.ImageCollectionInsights
{
    partial class ImageCollectionInsights : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 1
                {
                    this.mainPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 22
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 40
                {
                    this.filterTab = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 4: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 106
                {
                    this.landingMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 108
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 6: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 83
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element6 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element6).Checked += this.TagFilterChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element6).Unchecked += this.TagFilterChanged;
                }
                break;
            case 7: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 68
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element7 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element7).Checked += this.EmotionFilterChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element7).Unchecked += this.EmotionFilterChanged;
                }
                break;
            case 8: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 52
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element8 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element8).Checked += this.FaceFilterChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element8).Unchecked += this.FaceFilterChanged;
                }
                break;
            case 9: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 25
                {
                    this.reprocessImagesButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.reprocessImagesButton).Click += this.ReProcessImagesClicked;
                }
                break;
            case 10: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 26
                {
                    this.limitProcessingToggleButton = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                }
                break;
            case 11: // Views\ImageCollectionInsights\ImageCollectionInsights.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.ProcessImagesClicked;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

