using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CellFo.Resources;
using Microsoft.Phone.Net.NetworkInformation;
namespace CellFo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            
        }

        private void Postpaid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Postpaidlist.xaml", UriKind.Relative));
        }

        private void Prepaid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Prepaidlist.xaml", UriKind.Relative));
        }

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Info.xaml", UriKind.Relative));
        }

        private void MVNO_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MVNOlist.xaml", UriKind.Relative));
        }

        private void Network_Loaded(object sender, RoutedEventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("Your Carrier:  ");
            sb.AppendLine(DeviceNetworkInformation.CellularMobileOperator);
            Network.Text = (sb.ToString());
        }

        
    }
}