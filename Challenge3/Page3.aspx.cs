using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge3
{
    public partial class Page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PageNum"] == null || !((int)Session["PageNum"]).Equals(3))
            {
                Response.Redirect("~/");
            }
            FirstNameTD.InnerText = Request.QueryString["FirstName"];
            LastNameTD.InnerText = Request.QueryString["LastName"];

            HiddenField cityTextBox = (HiddenField) PreviousPage.FindControl("CityHF");
            CityTD.InnerText = cityTextBox.Value;

            HiddenField stateTextBox = (HiddenField) PreviousPage.FindControl("StateHF");
            StateTD.InnerText = stateTextBox.Value;

            AgeTD.InnerText = Request.Cookies.Get("Age").Value;

            PhoneTD.InnerText = (string) Session["Phone"];

            Session.Remove("PageNum");
        }
    }
}