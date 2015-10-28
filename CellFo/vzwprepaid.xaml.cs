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
    public partial class vzwprepaid : PhoneApplicationPage
    {
        public vzwprepaid()
        {
            InitializeComponent();
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = "8882946804";
            phoneCallTask.DisplayName = "Verizon Prepaid Customer Service";

            phoneCallTask.Show();
        }

        

        private void Website_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("http://www.verizonwireless.com/wcms/consumer/shop/prepaid.html#", UriKind.Absolute);

            webBrowserTask.Show();
        }
    }
}