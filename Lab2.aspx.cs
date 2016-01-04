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

namespace LandiLab4Se426
{
    public partial class Lab2 : System.Web.UI.Page
    {
        //global var stores str val that will be used in switch statment 
        private string buttonClicked;

        //gobal bool var that is used to help track if btn false has been clicked 
        //used for clearing function 
        private bool buttonAll = false;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //show all btn click event. sets btnclicked flag and calls the useXpath() 
        protected void btnshowAll_Click(object sender, EventArgs e)
        {
            buttonClicked = "btnSA";
            useXpath();
        }
        //show billing info only click event. 
        protected void btnBillInfo_Click(object sender, EventArgs e)
        {
            buttonClicked = "btnBI";
            useXpath();

        }

        //show only btn shipping info click event 
        protected void btnShipOnly_Click(object sender, EventArgs e)
        {
            buttonClicked = "btnSO";
            useXpath();

        }
        //show only btn  items info
        protected void btnItemOnly_Click(object sender, EventArgs e)
        {
            buttonClicked = "btnIO";
            useXpath();
        }
        //show only total  number om items 
        protected void btnTotalItems_Click(object sender, EventArgs e)
        {
            buttonClicked = "btnTI";
            useXpath();
        }
        //show only total cost of order
        protected void btnTotalCost_Click(object sender, EventArgs e)
        {
            buttonClicked = "btnTC";
            useXpath();
        }

        private void useXpath()
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            //Set path for xml inorder to open file 
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\orderDB.xml";
            docNav = new XPathDocument(strFilename);

            //nav to query with xpath
            nav = docNav.CreateNavigator();

            //onclick buttonClicked will be set then switch statement will go through cases looking for match and the execute
            switch (buttonClicked)
            {
                case "btnBI":
                    clearAll();
                    NodeIter = nav.Select("/Order/BillingInformation");
                    while (NodeIter.MoveNext())
                    {
                        XPathNodeIterator billInf = NodeIter.Current.SelectChildren(XPathNodeType.Element);
                        lblBinf.Text += billInf.Current.SelectSingleNode("Name") + "<br/>";
                        lblBinf.Text += billInf.Current.SelectSingleNode("Address") + "<br/>";
                        lblBinf.Text += billInf.Current.SelectSingleNode("City") + ", ";
                        lblBinf.Text += billInf.Current.SelectSingleNode("State") + "<br/>";
                        lblBinf.Text += billInf.Current.SelectSingleNode("ZipCode");
                    }
                    break;

                case "btnSO":
                    clearAll();
                    NodeIter = nav.Select("/Order/ShippingInformation");
                    while (NodeIter.MoveNext())
                    {
                        XPathNodeIterator shipInf = NodeIter.Current.SelectChildren(XPathNodeType.Element);
                        lblSi.Text += shipInf.Current.SelectSingleNode("Name") + "<br/>";
                        lblSi.Text += shipInf.Current.SelectSingleNode("Address") + "<br/>";
                        lblSi.Text += shipInf.Current.SelectSingleNode("City") + ", ";
                        lblSi.Text += shipInf.Current.SelectSingleNode("State") + "<br/>";
                        lblSi.Text += shipInf.Current.SelectSingleNode("ZipCode");
                    }
                    break;

                case "btnIO":
                    clearAll();
                    NodeIter = nav.Select("/Order/Items/Item");

                    while (NodeIter.MoveNext())
                    {
                        XPathNodeIterator itmInf = NodeIter.Current.SelectChildren(XPathNodeType.Element);
                        lblInf.Text += "Part #: " + itmInf.Current.SelectSingleNode("PartNo") + "<br/>";
                        lblInf.Text += "Desc: " + itmInf.Current.SelectSingleNode("Description") + "<br/>";
                        lblInf.Text += "UnitPrice: " + itmInf.Current.SelectSingleNode("UnitPrice") + "<br/>";
                        lblInf.Text += "Quantity: " + itmInf.Current.SelectSingleNode("Quantity") + "<br/>";
                        lblInf.Text += "TotalCost: " + itmInf.Current.SelectSingleNode("TotalCost") + "<br/>";
                        lblInf.Text += "----------" + "<br/>";
                        if (!itmInf.Current.SelectSingleNode("CustomerOptions").IsEmptyElement)
                        {
                            lblInf.Text += "Color Option: " + itmInf.Current.SelectSingleNode("CustomerOptions[(Color)]/Color") + "<br/>";
                            lblInf.Text += "Size Option: " + itmInf.Current.SelectSingleNode("CustomerOptions[(Size)]/Size") + "<br/>";
                        }

                    }

                    break;

                case "btnTI":
                    clearAll();
                    lblTip.Text = nav.Evaluate("sum(/Order/Items/Item/Quantity)").ToString() + " - total items on this order";
                    break;

                case "btnTC":
                    clearAll();
                    lblToc.Text = "$" + nav.Evaluate("sum(/Order/Items/Item/TotalCost)").ToString() + " - is the total amount due";
                    buttonAll = true;
                    break;

                //this case statement fires all btn click events in order to show all data. Because there is a clear all function that is called in each event
                //a flag gets set inorder to control when clear all function gets executed. 
                case "btnSA":
                    buttonAll = false;
                    clearAll();
                    buttonAll = true;
                    btnBillInfo_Click(null, EventArgs.Empty);
                    btnShipOnly_Click(null, EventArgs.Empty);
                    btnItemOnly_Click(null, EventArgs.Empty);
                    btnTotalItems_Click(null, EventArgs.Empty);
                    btnTotalCost_Click(null, EventArgs.Empty);
                    buttonAll = false;

                    break;
            }//end switch

        }//useXpath()

        //used to clear all data on btn click 
        private void clearAll()
        {
            if (buttonAll != true)
            {
                lblToc.Text = "";
                lblTip.Text = "";
                lblSi.Text = "";
                lblInf.Text = "";
                lblBinf.Text = "";
            }

        }
    }
}