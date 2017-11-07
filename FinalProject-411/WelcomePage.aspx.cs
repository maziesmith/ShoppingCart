using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_411
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void shopBttn_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForms/ShoppingPlazaForm.aspx");
        }

        protected void exitBttn_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForms/ExitPage.aspx");
        }
    }
}