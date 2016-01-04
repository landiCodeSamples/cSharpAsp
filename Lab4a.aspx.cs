using System;
using System.Net;
using System.IO;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;


namespace LandiLab4Se426
{
    public partial class Lab4a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet7Day_Click(object sender, EventArgs e)
        {
            string get_xml = "";
            string url_for_xml = "";
            string api_key = "";
            txtDisplayResults.Text = "";

            //create url needed to query webservice.  url contains address + my api key + options + location
            api_key = "1ff6c50505a74dff";
            url_for_xml = "http://api.wunderground.com/api/" + api_key + "/forecast10day/q/MA/Boston.xml";

            //HttpWebRequest class, which contains a request for the resource; and the HttpWebResponse class, which provides a container for the incoming response.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url_for_xml);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Implements a TextReader that reads characters from a byte stream in a particular encoding
            StreamReader resStream = new StreamReader(response.GetResponseStream());

            XmlDocument doc = new XmlDocument();
            get_xml = "<?xml version='1.0' encoding='UTF-8'?>";
            get_xml += resStream.ReadToEnd();
            doc.LoadXml(get_xml);

            XmlNodeList itmNodes = doc.SelectNodes("//forecast/txt_forecast/forecastdays/forecastday");
           
            foreach (XmlNode itmNode in itmNodes)
            {
                txtDisplayResults.Text += itmNode.SelectSingleNode("title").InnerText + Environment.NewLine + Environment.NewLine;

                txtDisplayResults.Text += itmNode.SelectSingleNode("fcttext").InnerText + Environment.NewLine;
                txtDisplayResults.Text += "................................................." + Environment.NewLine;

            }

        }

        protected void getGeo_Click(object sender, EventArgs e)
        {
            string user_zip = "";
            string url_for_xml = "";
            string xml_str = "";
            string api_key = "";
            txtDisplayGeoResults.Text = "";

            user_zip = Convert.ToString(txtUserZip.Text);
            api_key = "djlandi";
            url_for_xml = "http://api.geonames.org/postalCodeSearch?postalcode="+user_zip+"&username="+api_key;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url_for_xml);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader resStream = new StreamReader(response.GetResponseStream());

            XmlDocument doc = new XmlDocument();
            xml_str = resStream.ReadToEnd();
            doc.LoadXml(xml_str);
            //txtDisplayGeoResults.Text = xml_str;

            XmlNodeList itmNodes = doc.SelectNodes("//geonames/code");
            foreach (XmlNode itmNode in itmNodes)
            {
                txtDisplayGeoResults.Text += itmNode.SelectSingleNode("postalcode").InnerText + " - ";
                txtDisplayGeoResults.Text += itmNode.SelectSingleNode("name").InnerText;
            }
        }

        protected void btnGetNearBy_Click(object sender, EventArgs e)
        {
            string user_zip = "";
            string url_for_xml = "";
            string xml_str = "";
            string api_key = "";
            txtDisplayGeoResults.Text = "";

            user_zip = Convert.ToString(txtUserZip.Text);
            api_key = "djlandi";
            url_for_xml = "http://api.geonames.org/findNearbyPostalCodes?postalcode=" + user_zip + "&country=US" + "&username=" + api_key;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url_for_xml);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader resStream = new StreamReader(response.GetResponseStream());

            XmlDocument doc = new XmlDocument();
            xml_str = resStream.ReadToEnd();
            doc.LoadXml(xml_str);
            //txtDisplayGeoResults.Text = xml_str;

            XmlNodeList itmNodes = doc.SelectNodes("//geonames/code");
            foreach (XmlNode itmNode in itmNodes)
            {
                txtDisplayGeoResults.Text += itmNode.SelectSingleNode("postalcode").InnerText + " - ";
                txtDisplayGeoResults.Text += itmNode.SelectSingleNode("name").InnerText + Environment.NewLine;
            }
        }
    }
}