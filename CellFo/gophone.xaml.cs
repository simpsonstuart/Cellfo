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
    public partial class gophone : PhoneApplicationPage
    {
        public gophone()
        {
            InitializeComponent();
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = "18009019878";
            phoneCallTask.DisplayName = "Gophone";

            phoneCallTask.Show();
        }

       

        private void Website_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("http://www.att.com/shop/wireless/gophone.html", UriKind.Absolute);

            webBrowserTask.Show();
        }
    }
}