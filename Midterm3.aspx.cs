using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Web;
using System.Web.Services;

namespace LandiLab4Se426
{
    public partial class Midterm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGetResults_Click(object sender, EventArgs e)
        {
            string xml_query = "";
            txtShowResults.Text = "";

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\Nutrition.xml";
            docNav = new XPathDocument(strFilename);

            nav = docNav.CreateNavigator();
            xml_query = "//food[vitamins/a > 10]";
            NodeIter = nav.Select(xml_query);

            txtShowResults.Text = "****Food that has more than 10 of Vitamin A**** " + Environment.NewLine;
            while (NodeIter.MoveNext())
            {
                txtShowResults.Text += "Name: " + NodeIter.Current.SelectSingleNode("name").Value + Environment.NewLine;
                txtShowResults.Text += "Total Calories: " + NodeIter.Current.SelectSingleNode("calories/@total").Value + Environment.NewLine;
                txtShowResults.Text += "............................." + Environment.NewLine;
            }
            txtShowResults.Text += "==================================" + Environment.NewLine;
            txtShowResults.Text += "****Food that has a meat type**** " + Environment.NewLine;

            xml_query = "//food[@type = 'meat']";
            NodeIter = nav.Select(xml_query);

            while (NodeIter.MoveNext())
            {
                txtShowResults.Text += "Name: " + NodeIter.Current.SelectSingleNode("name").Value + Environment.NewLine;
            }
        }
    }
}