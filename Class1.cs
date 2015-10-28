using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Net;

namespace WindowsFormsApplication1
{
    class Class1
    {

        Form1 moFormRef = null;

        private void RequestCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                XDocument oXDocTemp = XDocument.Parse(e.Result);

                foreach (XElement element in oXDocTemp.Root
                                .Elements("Operator"))
                {
                    if ((string)element.Attribute("name").Value == "Djezzy (Algeria)")
                    {
                        //List<XElement> oChildElements = element.Elements().ToList();

                        foreach (XElement oChildElement in element.Elements())
                        {
                            if (oChildElement.Name == "HardwareIdList")
                            {
                                string s = "";
                                try
                                {
                                    List<XElement> oGrandChildren = oChildElement.Elements().ToList();
                                    foreach (XElement oGrandChild in oGrandChildren)
                                    {
                                        if (oGrandChild.Name == "HardwareId")
                                        {
                                            s = (string)oGrandChild.Attribute("id").Value;
                                        }
                                    }

                                }
                                catch { }

                                moFormRef.TextBox1Property = s;

                            }
                        }

                    }
                }

            }
        }

        public void test(Form1 inout_oFormRef)
        {
            moFormRef = inout_oFormRef; 

            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += RequestCompleted;
            webClient.DownloadStringAsync(new Uri("http://localhost/webapplication1/apndatabase.xml"));
        }
    }
}
