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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OrchardManagment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SingleHarvest : Page
    {
        public SingleHarvest()
        {
            this.InitializeComponent();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (btnEdit.Content.ToString() == "Edit")
            {
                btnEdit.Content = "Save";
                txtHarvested.IsEnabled = true;
                txtDate.IsEnabled = true;
                txtPriceKg.IsEnabled = true;
                txtTotalIncome.IsEnabled = true;
                txtComment.IsEnabled = true;
            }
            else
            {
                btnEdit.Content = "Edit";
                txtHarvested.IsEnabled = false;
                txtDate.IsEnabled = false;
                txtPriceKg.IsEnabled = false;
                txtTotalIncome.IsEnabled = false;
                txtComment.IsEnabled = false;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AllHarvests));
        }

        private void SingleHarvest_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ApplicationView.GetForCurrentView().TryResizeView(new Size(400, 500));
        }
    }
}
