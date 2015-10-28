using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace CellFo
{
    public partial class cricket : PhoneApplicationPage
    {
        public cricket()
        {
            InitializeComponent();
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = "18009753708";
            phoneCallTask.DisplayName = "Cricket Sales";

            phoneCallTask.Show();
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = " 18002742538";
            phoneCallTask.DisplayName = "Cricket Support";

            phoneCallTask.Show();
        }

        private void Website_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("http://mycricket.com", UriKind.Absolute);

            webBrowserTask.Show();
        }
    }
}