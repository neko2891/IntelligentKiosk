﻿#pragma checksum "C:\Users\v-caspch\Desktop\IntelligentKiosk\Views\VideoInsights\VideoInsightsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7091D3521715B71224A00321DCB09FB5"
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
    partial class VideoInsightsPage : 
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
            case 1: // Views\VideoInsights\VideoInsightsPage.xaml line 1
                {
                    this.mainPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // Views\VideoInsights\VideoInsightsPage.xaml line 18
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\VideoInsights\VideoInsightsPage.xaml line 26
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 4: // Views\VideoInsights\VideoInsightsPage.xaml line 169
                {
                    this.debugText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Views\VideoInsights\VideoInsightsPage.xaml line 161
                {
                    this.peopleListView = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6: // Views\VideoInsights\VideoInsightsPage.xaml line 162
                {
                    this.tagsListView = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // Views\VideoInsights\VideoInsightsPage.xaml line 153
                {
                    this.timelineTipHost = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8: // Views\VideoInsights\VideoInsightsPage.xaml line 154
                {
                    this.timelineRectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.timelineRectangle).Tapped += this.TimelineTapped;
                }
                break;
            case 9: // Views\VideoInsights\VideoInsightsPage.xaml line 155
                {
                    this.timelineTip = (global::Windows.UI.Xaml.Shapes.Polyline)(target);
                }
                break;
            case 10: // Views\VideoInsights\VideoInsightsPage.xaml line 85
                {
                    this.tagFilterPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11: // Views\VideoInsights\VideoInsightsPage.xaml line 69
                {
                    this.overallStatsControl = (global::IntelligentKioskSample.Controls.OverallStatsControl)(target);
                }
                break;
            case 12: // Views\VideoInsights\VideoInsightsPage.xaml line 71
                {
                    this.ageGenderDistributionControl = (global::IntelligentKioskSample.Controls.AgeGenderDistributionControl)(target);
                }
                break;
            case 13: // Views\VideoInsights\VideoInsightsPage.xaml line 53
                {
                    this.peopleVisualizationComboBoxItem = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 14: // Views\VideoInsights\VideoInsightsPage.xaml line 54
                {
                    this.tagVisualizationComboBoxItem = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 15: // Views\VideoInsights\VideoInsightsPage.xaml line 45
                {
                    this.videoPlayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 16: // Views\VideoInsights\VideoInsightsPage.xaml line 27
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element16 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element16).Click += this.FromFileClick;
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

