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
            try
            {
                FirstNameTD.InnerText = Request.QueryString["FirstName"];
                LastNameTD.InnerText = Request.QueryString["LastName"];

                HiddenField cityTextBox = (HiddenField)PreviousPage.FindControl("CityHF");
                CityTD.InnerText = Request.Form.Get("CityHF");

                HiddenField stateTextBox = (HiddenField)PreviousPage.FindControl("StateHF");
                StateTD.InnerText = Request.Form.Get("StateHF");

                AgeTD.InnerText = Request.Cookies.Get("Age").Value;

                PhoneTD.InnerText = (string)Session["Phone"];
            }
            catch (Exception)
            {
                Response.Redirect("~/");
            }
        }
    }
}