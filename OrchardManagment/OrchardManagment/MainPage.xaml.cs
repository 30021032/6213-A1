using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace OrchardManagment
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MainPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ApplicationView.GetForCurrentView().TryResizeView(new Size(1000, 800));
        }

        private void navigate_actions(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AllActions));
        }


        private void navigate_harvest(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AllHarvests));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddSection));
        }

        private void btnEditSections_Click(object sender, RoutedEventArgs e)
        {
            if (btnEditSections.Content.ToString() == "Edit Section")
            {
                btnEditSections.Content = "Finish";

                btnEdit1.Visibility = Visibility.Visible;
                btnEdit2.Visibility = Visibility.Visible;
                btnEdit3.Visibility = Visibility.Visible;
                btnEdit4.Visibility = Visibility.Visible;
                btnEdit5.Visibility = Visibility.Visible;
                btnEdit6.Visibility = Visibility.Visible;

                btnActions1.Visibility = Visibility.Collapsed;
                btnActions2.Visibility = Visibility.Collapsed;
                btnActions3.Visibility = Visibility.Collapsed;
                btnActions4.Visibility = Visibility.Collapsed;
                btnActions5.Visibility = Visibility.Collapsed;
                btnActions6.Visibility = Visibility.Collapsed;

                btnHarvests1.Visibility = Visibility.Collapsed;
                btnHarvests2.Visibility = Visibility.Collapsed;
                btnHarvests3.Visibility = Visibility.Collapsed;
                btnHarvests4.Visibility = Visibility.Collapsed;
                btnHarvests5.Visibility = Visibility.Collapsed;
                btnHarvests6.Visibility = Visibility.Collapsed;
            } else
            {
                btnEditSections.Content = "Edit Section";

                btnEdit1.Visibility = Visibility.Collapsed;
                btnEdit2.Visibility = Visibility.Collapsed;
                btnEdit3.Visibility = Visibility.Collapsed;
                btnEdit4.Visibility = Visibility.Collapsed;
                btnEdit5.Visibility = Visibility.Collapsed;
                btnEdit6.Visibility = Visibility.Collapsed;

                btnActions1.Visibility = Visibility.Visible;
                btnActions2.Visibility = Visibility.Visible;
                btnActions3.Visibility = Visibility.Visible;
                btnActions4.Visibility = Visibility.Visible;
                btnActions5.Visibility = Visibility.Visible;
                btnActions6.Visibility = Visibility.Visible;

                btnHarvests1.Visibility = Visibility.Visible;
                btnHarvests2.Visibility = Visibility.Visible;
                btnHarvests3.Visibility = Visibility.Visible;
                btnHarvests4.Visibility = Visibility.Visible;
                btnHarvests5.Visibility = Visibility.Visible;
                btnHarvests6.Visibility = Visibility.Visible;
            }
        }
        private void btnEdit_section(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EditSection));
        }
    }
}
