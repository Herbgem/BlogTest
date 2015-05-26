using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogLogic;
using Blog.Entities;

namespace BlogTest
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        MasterBlog _masterBlog;
        protected void Page_Load(object sender, EventArgs e)
        {
            _masterBlog = new MasterBlog(Session["UserName"].ToString());
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string owner = Session["UserName"].ToString();
            _masterBlog.AddPost(new Post(txbTitle.Text, txbDescription.Text, txbContent.InnerText, Session["UserName"].ToString(), DateTime.Now, DateTime.Now, Convert.ToInt32(Session["BlogId"])));
            Response.RedirectPermanent("/Account/UserHome.aspx");
        }
    }
}