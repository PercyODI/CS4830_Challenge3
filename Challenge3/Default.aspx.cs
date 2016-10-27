using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge3
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitButton_OnClick(object sender, EventArgs e)
        {
            Session["PageNum"] = 2;
        }
    }
}