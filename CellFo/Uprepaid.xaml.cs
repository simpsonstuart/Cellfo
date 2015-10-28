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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Media;
using System.Windows.Documents;
namespace CellFo
{
    public partial class Uprepaid : PhoneApplicationPage
    {
        public Uprepaid()
        {
            InitializeComponent();
        }

        

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += RequestCompleted;
            webClient.DownloadStringAsync(new Uri("http://fusionfjord.com/ApnDatabase.xml"));
        }

        private void RequestCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                XDocument oXDocTemp = XDocument.Parse(e.Result);
                //Go to Carrier Level
                foreach (XElement oCarrierXElement in oXDocTemp.Root
                                .Elements("Carrier"))
                {   //Pick that Carrier
                    if ((string)oCarrierXElement.Attribute("Name").Value == "Go Phone")
                    {
                        // Get and add the Plan Info
                        XElement oPlanInfoXElement = oCarrierXElement.Element("PlanInfo");

                        

                        PanoramaItem oNewCarrierInfoItem = new PanoramaItem();
                        //set the background color and opacity of the Info
                        oNewCarrierInfoItem.Background = new SolidColorBrush(Color.FromArgb(127, 33, 31, 31));
                        // Set my new panorama item properties
                        oNewCarrierInfoItem.Header = oCarrierXElement.Attribute("Name").Value;
                        Carrier_Page.Items.Add(oNewCarrierInfoItem);
                        PanoramaGrid2 oGrid2 = new PanoramaGrid2();
                        oGrid2.Name = "PlanInfoGrid";
                        oNewCarrierInfoItem.Content = oGrid2;

                        //for pages with info
                        //string i = "";
                        string s = oPlanInfoXElement.Attribute("Retail_Stores").Value;
                        string t = oPlanInfoXElement.Attribute("Type").Value;
                        string n = oPlanInfoXElement.Attribute("Name").Value;
                        string p = oPlanInfoXElement.Attribute("ParentCO").Value;
                        string tel = oPlanInfoXElement.Attribute("TEL").Value;
                        string w = oPlanInfoXElement.Attribute("Website").Value;
                        //for pages with info
                        //i = (string)oChildElement.Attribute("Info").Value;

                        oGrid2.RetailAvail.Text = s;
                        oGrid2.Celltype.Text = t;
                        PlanInfo.Header = n;
                        oGrid2.ParentC.Text = p;
                        oGrid2.Telo1.Content = tel;
                        oGrid2.Website.Content = w;
                        //special sets the title from our own text for specific pages so we only load a generic page
                        //Carrier_Page.Title = "U Prepaid";
                        //for pages with info
                        //Infobox.Text = i;


                        int iCount = 0;
                        foreach (XElement oPlanXElement in oCarrierXElement.Elements("Plan"))
                        {
                            

                            iCount++;
                            //for pages with info
                            //string i = "";
                            string sName = oPlanXElement.Element("Name").Value;
                            string sData = oPlanXElement.Element("Data").Value;
                            string sInfo = oPlanXElement.Element("Info").Value;
                 
                            // Get and add the Plan Info
                 
                            PanoramaItem oNewItem = new PanoramaItem();
                           

                            //set the background color and opacity of all Panorama Items
                            oNewItem.Background = new SolidColorBrush(Color.FromArgb(127, 33, 31, 31));
                            // Header
                            oNewItem.Header = sName;

                            // Add Feature Text Block
                            PanoramaGrid oGrid = new PanoramaGrid();

                            oGrid.Name = "PlanGridDynamic" + iCount;
                            oNewItem.Content = oGrid;

                            
                            oGrid.Additional_Info.Text = sInfo;
                            oGrid.Data_Allotment.Text = sData;

                            // Get and add the Features Info
                            //XElement oFeaturesXElement = oPlanXElement.Element("Features");
                            foreach (XElement oFeaturesXElement in oPlanXElement.Elements("Features"))
                            {
                                string sPara = oFeaturesXElement.Element("Feature").Value;
                                FeaturesPara.Inlines.Add(new Run() { Text = sPara }); 
                                
                                //oGrid.FeaturesPara.Text = sPara;
                            }



                            // Set my new panorama item properties
                            try
                            {
                                Carrier_Page.Items.Add(oNewItem);
                            }
                            catch (Exception oEx)
                            {
                                string str = oEx.Message;
                            }

                            //special sets the title from our own text for specific pages so we only load a generic page
                            //Carrier_Page.Title = "U Prepaid";
                            //for pages with info
                            //Infobox.Text = i;
                        }
                    }
                }

            }
        }




    }
}