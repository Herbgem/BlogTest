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
    public partial class WebForm4 : System.Web.UI.Page
    {
        MasterBlog _masterBlog;
        IPost _oldPost;
        protected void Page_Load(object sender, EventArgs e)
        {
            _masterBlog = new MasterBlog(Session["UserName"].ToString());
            if (!IsPostBack)
            {
                LoadPosts();
            }
        }

        private void LoadPosts()
        {
            _oldPost = _masterBlog.ReviewPost(Convert.ToInt32(Session["PostId"]));
            BlogContent.DataSource = new List<IPost> {_masterBlog.ReviewPost(Convert.ToInt32(Session["PostId"]))};
            BlogContent.DataBind();
        }

        protected void BlogContent_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            
        }

        protected void BlogContent_ItemDeleting(object sender, FormViewDeleteEventArgs e)
        {
            _masterBlog.DeletePost(Convert.ToInt32(Session["PostId"]));
            Response.RedirectPermanent("/Account/UserHome.aspx");
        }

        protected void BlogContent_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            BlogContent.ChangeMode(e.NewMode);
            LoadPosts();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.RedirectPermanent("/Account/UserHome.aspx");
        }

        protected void btnSummit_Click(object sender, EventArgs e)
        {
            string newTitle = (BlogContent.FindControl("editPostTitle") as TextBox).Text;
            string newDescription = (BlogContent.FindControl("editPostDescription") as TextBox).Text;
            string newContent = (BlogContent.FindControl("editPostContent") as TextBox).Text;
            LoadPosts();
            _masterBlog.UpdatePost(Convert.ToInt32(Session["PostId"]), new Post(newTitle, newDescription, newContent, _oldPost.PostAuthor, _oldPost.PostCreated, DateTime.Now));
            Response.RedirectPermanent("/Account/UserHome.aspx");
        }
    }
}