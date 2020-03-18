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
    public sealed partial class SingleAction : Page
    {
        public SingleAction()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AllActions));
        }

        private void SingleAction_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ApplicationView.GetForCurrentView().TryResizeView(new Size(400, 500));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(btnEdit.Content.ToString() == "Edit")
            {
                btnEdit.Content = "Save";
                txtType.IsEnabled = true;
                txtHoursInvested.IsEnabled = true;
                txtDate.IsEnabled = true;
                txtComment.IsEnabled = true;
            } else
            {
                btnEdit.Content = "Edit";
                txtType.IsEnabled = false;
                txtHoursInvested.IsEnabled = false;
                txtDate.IsEnabled = false;
                txtComment.IsEnabled = false;
            }
        }
    }
}
