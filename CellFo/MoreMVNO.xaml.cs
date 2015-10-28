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

namespace CellFo
{
    public partial class MoreMVNO : PhoneApplicationPage
    {
        public MoreMVNO()
        {
            InitializeComponent();
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton Previous = new ApplicationBarIconButton();
            ApplicationBarIconButton MoreMVNO = new ApplicationBarIconButton();
            Previous.IconUri = new Uri("/Images/questionmark.png", UriKind.Relative);
            MoreMVNO.IconUri = new Uri("/Images/add.png", UriKind.Relative);
            Previous.Text = "Previous";
            MoreMVNO.Text = "More";
            ApplicationBar.Buttons.Add(Previous);
            ApplicationBar.Buttons.Add(MoreMVNO);
            Previous.Click += new EventHandler(Previous_Click);
            MoreMVNO.Click += new EventHandler(MoreMVNO_Click);
        }

        private void MoreMVNO_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MoreMVNO2.xaml", UriKind.Relative));
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MVNOlist.xaml", UriKind.Relative));
        }


        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
            appBarButton.Text = AppResources.AppBarButtonText;
            ApplicationBar.Buttons.Add(appBarButton);

            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            ApplicationBar.MenuItems.Add(appBarMenuItem);
        }
    }
}