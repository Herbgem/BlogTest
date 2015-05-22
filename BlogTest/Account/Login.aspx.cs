using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogLogic;

namespace BlogTest
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (MasterBlog.ValidateUser(txtUserName.Text))
            {
                Session["UserName"] = txtUserName.Text;
                Response.RedirectPermanent(@"\Account\UserHome.aspx");
            }
            else
            {
                lblWarning.InnerText = "User does not exist";
            }
        }
    }
}