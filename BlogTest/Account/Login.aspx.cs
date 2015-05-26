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
            int blogId = MasterBlog.ValidateUser(txtUserName.Text);
            if (blogId > 0)
            {
                Session["UserName"] = txtUserName.Text;
                Session["BlogId"] = blogId;
                Response.RedirectPermanent(@"\Account\UserHome.aspx");
            }
            else
            {
                lblWarning.InnerText = "User does not exist";
            }
        }
    }
}