using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogTest.BlogUserControl
{
    public partial class BlogHeader : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                this.liLogout.Visible = false;
            }
            else
            {
                this.liLogin.Visible = false;
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.RedirectPermanent("/Account/Login.aspx");
        }
    }
}