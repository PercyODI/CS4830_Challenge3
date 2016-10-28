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
            Session.Add("PageNum", "Page1");
        }
    }
}