using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge3
{
    public partial class Page2 : System.Web.UI.Page
    {
        private string _redirectUrl = "~/";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    CityHF.Value = Request.Form.Get("City");
                    StateHF.Value = Request.Form.Get("State");

                    HttpCookie ageCookie = new HttpCookie("Age");
                    ageCookie.Value = Request.Form.Get("Age");
                    ageCookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(ageCookie);

                    Session["Phone"] = Request.Form.Get("Phone");

                    pageThreeButton.PostBackUrl = "~/Page3.aspx?FirstName=" + Request.Form.Get("FirstName") +
                                                  "&LastName=" + Request.Form.Get("LastName");
                }
                catch (Exception)
                {
                    Response.Redirect("~/");
                }
            }
        }
    }
}