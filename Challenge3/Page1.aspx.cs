using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge3
{
    public partial class Page1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Set the session to say that the user is coming from Page1
            Session["PageNum"] = "Page1";
        }
    }
}