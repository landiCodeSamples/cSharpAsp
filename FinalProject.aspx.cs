using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;



namespace LandiLab4Se426
{
    public partial class FinalProject : System.Web.UI.Page
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("http://localhost:59728", "*", "*");
            config.EnableCors(cors);
        } 
        protected void Page_Load(object sender, EventArgs e)
        {
     

        }
        
    }
}