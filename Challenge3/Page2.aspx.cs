using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge3
{
    public partial class Page2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check that the user came from Page1
                if (Session["PageNum"] != null &&  Session["PageNum"].Equals("Page1"))
                {
                    // try-catch to catch any exceptions such as null pointers from
                    // bad data.
                    try
                    {
                        // Set the value of the City and State hidden fields
                        // to the post data from Page1
                        CityHF.Value = Request.Form.Get("City");
                        StateHF.Value = Request.Form.Get("State");

                        // Create a cooke for Age and set its value to the 
                        // the post data from Page1
                        HttpCookie ageCookie = new HttpCookie("Age");
                        ageCookie.Value = Request.Form.Get("Age");
                        ageCookie.Expires = DateTime.Now.AddDays(1);
                        Response.Cookies.Add(ageCookie);

                        // Create a session variable for Phone and set its
                        // value to the post data form Page1
                        Session["Phone"] = Request.Form.Get("Phone");

                        // Create a query string that navigates to Page3 and
                        // sets the FirstName and LastName variables to the
                        // post data from Page1
                        pageThreeButton.PostBackUrl = "~/Page3.aspx?FirstName=" + Request.Form.Get("FirstName") +
                                                      "&LastName=" + Request.Form.Get("LastName");

                        // Set the session to say the user is coming from Page2
                        Session["PageNum"] = "Page2";
                    }
                    // Redirect to the default page if any exceptions are thrown
                    catch (Exception)
                    {
                        Response.Redirect("~/");
                    }
                }
                else
                {
                    // Remove the PageNum session variable so the user has
                    // to reenter data
                    Session.Remove("PageNum");
                    // Redirect to the default page if data is missing
                    Response.Redirect("~/");
                }
            }
        }
    }
}