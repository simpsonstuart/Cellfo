using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Xml.Serialization;
using System.Xml.Linq;
namespace CellFo
{
    
    public partial class Prepaidlist : PhoneApplicationPage
    {
        public Prepaidlist()
        {
            InitializeComponent();
        }

        private void AT_T_GoPhone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/gophone.xaml", UriKind.Relative));
        }

        private void Cricket_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/cricket.xaml", UriKind.Relative));
        }

        private void Verizon__Prepaid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/vzwprepaid.xaml", UriKind.Relative));
        }

        private void T_Mobile_Prepaid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tmoprepaid.xaml", UriKind.Relative));
        }

        private void U_S_Cellular_Prepaid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/uscellprepaid.xaml", UriKind.Relative));
        }

        private void Uprepaid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Uprepaid.xaml", UriKind.Relative));
        }
    }
}