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
    public partial class WebForm3 : System.Web.UI.Page
    {
        MasterBlog _masterBlog;

        protected void Page_Load(object sender, EventArgs e)
        {
            _masterBlog = new MasterBlog(Session["UserName"].ToString());
                LoadPosts();
        }

        private void LoadPosts()
        {
            //BlogsGrid.DataSource = null;
            IList<IPost> posts = _masterBlog.ReviewPosts();
            BlogsGrid.DataSource = posts;
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
            if (e.CommandName == "select")
            {
                Session["PostId"] = Convert.ToInt32(BlogsGrid.DataKeys[e.Item.ItemIndex]);
                Response.RedirectPermanent("/Account/BlogContent.aspx");
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.RedirectPermanent("/Account/AddNewPage.aspx");
        }


    }
}