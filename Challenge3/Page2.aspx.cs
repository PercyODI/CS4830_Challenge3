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
            
            if (Session["PageNum"] == null || !((int)Session["PageNum"]).Equals(2))
            {
                Response.Redirect("~/", );
            }
            if (!IsPostBack)
            {
                TextBox firstNameTextBox = (TextBox) PreviousPage.FindControl("FirstName");
                TextBox lastNameTextBox = (TextBox) PreviousPage.FindControl("LastName");
                TextBox cityTextBox = (TextBox) PreviousPage.FindControl("City");
                TextBox stateTextBox = (TextBox) PreviousPage.FindControl("State");
                TextBox ageTextBox = (TextBox) PreviousPage.FindControl("Age");
                TextBox phoneTextBox = (TextBox) PreviousPage.FindControl("Phone");

                CityHF.Value = cityTextBox.Text;
                StateHF.Value = stateTextBox.Text;

                HttpCookie ageCookie = new HttpCookie("Age");
                ageCookie.Value = ageTextBox.Text;
                ageCookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(ageCookie);

                Session["Phone"] = phoneTextBox.Text;

                _redirectUrl = "~/Page3.aspx?FirstName=" + firstNameTextBox.Text + "&LastName=" +
                                              lastNameTextBox.Text;
            }
        }


        protected void pageThreeButton_OnClick(object sender, EventArgs e)
        {
            Session["PageNum"] = 3;
            Response.Redirect(_redirectUrl);
        }
    }
}