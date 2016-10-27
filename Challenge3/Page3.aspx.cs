using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge3
{
    public partial class Page3 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Try to retrieve these values. If any value throws an exception
            // (such as null pointer), redirect to the main form page
            try
            {
                // Set the inner text of the table cells for First Name and
                // Last Name to the values given in the query string
                FirstNameTD.InnerText = Request.QueryString["FirstName"];
                LastNameTD.InnerText = Request.QueryString["LastName"];
                
                // Set the inner text of the table cells for City and
                // State to the values from the Page2 form as POST data
                CityTD.InnerText = Request.Form.Get("CityHF");
                StateTD.InnerText = Request.Form.Get("StateHF");

                // Set the inner text of the table cell for Age to the
                // value set as a cookie in Page2
                AgeTD.InnerText = Request.Cookies.Get("Age").Value;

                // Set the inner text of the table cell for Phone to the
                // value set in the session variable in Page2
                PhoneTD.InnerText = (string)Session["Phone"];
            }
            catch (Exception)
            {
                // Redirect to the default page if data is missing
                Response.Redirect("~/");
            }
        }
    }
}