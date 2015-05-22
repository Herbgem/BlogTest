using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogLogic;

namespace BlogTest
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        MasterBlog _masterBlog;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _masterBlog = new MasterBlog(Session["UserName"].ToString());
                LoadPosts();
            }
        }

        private void LoadPosts()
        {
            BlogsGrid.DataSource = _masterBlog.ReviewPosts();
            BlogsGrid.DataBind();
        }

        //protected void lblblogDescription_Click(object sender, EventArgs e)
        //{
        //    //HiddenField temp = BlogsGrid.Items. as HiddenField;
            
        //    Session["PostId"] = Convert.ToInt32((this.FindControl("hfPostId") as HiddenField).Value);
        //    Response.RedirectPermanent("/Account/BlogContent.aspx");
        //}

        protected void BlogsGrid_ItemCommand(object sender, DataListCommandEventArgs e)
        {
            Session["PostId"] = Convert.ToInt32(BlogsGrid.DataKeys[e.Item.ItemIndex]);
            Response.RedirectPermanent("/Account/BlogContent.aspx");
        }

        protected void BlogsGrid_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            Session["PostId"] = Convert.ToInt32(BlogsGrid.DataKeys[e.Item.ItemIndex]);
            Response.RedirectPermanent("/Account/BlogContent.aspx");
        }
    }
}