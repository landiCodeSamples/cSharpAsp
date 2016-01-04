using System;
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
using System.Text.RegularExpressions;
namespace LandiLab4Se426
{
    public partial class Lab4 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void btnGetResults_Click(object sender, EventArgs e)
        {
           
                
           

            get_xml();
            wsStock.StockQuote stock = new wsStock.StockQuote();
            txtAdminResults.Text = stock.GetQuote(txtInput.Text).ToString();

            XmlDocument xd = new XmlDocument();
            xd.Load("http://localhost:59728/products-string.xml");
            XmlNodeList itemNodes = xd.SelectNodes("//StockQuotes/Stock");

            foreach(XmlNode itemNode in itemNodes)
            {
                txtUserResults.Text = "Last Stock Price: " + itemNode.SelectSingleNode("Last").InnerText + Environment.NewLine;
                txtUserResults.Text += "High Stock Price: " + itemNode.SelectSingleNode("High").InnerText + Environment.NewLine;
                txtUserResults.Text += "Low Stock Price: " + itemNode.SelectSingleNode("Low").InnerText + Environment.NewLine;
                txtUserResults.Text += "The stock’s name: " + itemNode.SelectSingleNode("Name").InnerText + Environment.NewLine;
            }
            btnGetResults.Enabled = false;
            lblmessage.Text = "Please refresh page to enter new stock";
        
        }
        public void get_xml()
        {
            Regex xml_cant_handel_Ampersand = new Regex("&(?![a-zA-Z]{2,6};|#[0-9]{2,4};)");
            const string make_life_easy_Ampersand = "&amp;";
            wsStock.StockQuote stock = new wsStock.StockQuote();
            XmlDocument xd = new XmlDocument();
            string generate_ws_xml = Convert.ToString(stock.GetQuote(txtInput.Text));
            string xmlString = "<?xml version='1.0' encoding='UTF-8'?>";
            xmlString += xml_cant_handel_Ampersand.Replace(generate_ws_xml, make_life_easy_Ampersand);
            xd.LoadXml(xmlString);
            xd.Save(Server.MapPath("products-string.xml"));
        }

       
      
    }
}