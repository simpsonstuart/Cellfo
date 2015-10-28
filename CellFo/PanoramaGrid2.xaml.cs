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
    public partial class PanoramaGrid2 : UserControl
    {
        public PanoramaGrid2()
        {
            InitializeComponent();
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = "18558722123";
            phoneCallTask.DisplayName = "Uprepaid Customer Service";

            phoneCallTask.Show();
        }

        private void Website_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("http://uprepaid.net", UriKind.Absolute);

            webBrowserTask.Show();
        }

        private void Press_Hold_Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //colapse items on grid so we can load ussd items
            Features5.Visibility = System.Windows.Visibility.Collapsed;
            Celltype.Visibility = System.Windows.Visibility.Collapsed;
            Data5.Visibility = System.Windows.Visibility.Collapsed;
            Website.Visibility = System.Windows.Visibility.Collapsed;
            Info5.Visibility = System.Windows.Visibility.Collapsed;
            RetailAvail.Visibility = System.Windows.Visibility.Collapsed;
            Parent_Title.Visibility = System.Windows.Visibility.Collapsed;
            ParentC.Visibility = System.Windows.Visibility.Collapsed;
            P_Number.Visibility = System.Windows.Visibility.Collapsed;
            Telo1.Visibility = System.Windows.Visibility.Collapsed;
            Press_Hold_Button.Visibility = System.Windows.Visibility.Collapsed;
            Press_Hold_Button_Back.Visibility = System.Windows.Visibility.Visible;
            USSD_Grid.Visibility = System.Windows.Visibility.Visible;
            //for special pages
            //Telo2.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Press_Hold_Button_Back_Click(object sender, RoutedEventArgs e)
        {
            //uncollapse items on grid so we can load ussd items
            USSD_Grid.Visibility = System.Windows.Visibility.Collapsed;
            Features5.Visibility = System.Windows.Visibility.Visible;
            Celltype.Visibility = System.Windows.Visibility.Visible;
            Data5.Visibility = System.Windows.Visibility.Visible;
            Website.Visibility = System.Windows.Visibility.Visible;
            Info5.Visibility = System.Windows.Visibility.Visible;
            RetailAvail.Visibility = System.Windows.Visibility.Visible;
            Parent_Title.Visibility = System.Windows.Visibility.Visible;
            ParentC.Visibility = System.Windows.Visibility.Visible;
            P_Number.Visibility = System.Windows.Visibility.Visible;
            Telo1.Visibility = System.Windows.Visibility.Visible;
            Press_Hold_Button.Visibility = System.Windows.Visibility.Visible;
            Press_Hold_Button_Back.Visibility = System.Windows.Visibility.Collapsed;
            //for special pages
            //Telo2.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
