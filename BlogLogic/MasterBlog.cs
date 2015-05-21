using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogData;
using Blog.Entities;

namespace BlogLogic
{
    public class MasterBlog
    {
        private IBlogOperation _blogOperation;
        private string _owner;

        public MasterBlog(string blogowner)
        {
            _owner = blogowner;
            _blogOperation = new BlogOperations(blogowner);
        }

        public void AddPost(IPost post)
        {
            _blogOperation.AddPost(post);
        }

        public IList<IPost> ReviewPosts()
        {
            return _blogOperation.ReviewPosts();
        }

        public IPost ReviewPost(int postid)
        {
            return _blogOperation.ReviewPost(postid);
        }

        public void UpdatePost(int postid, string content)
        {
            _blogOperation.UpdatePost(postid, content);
        }

        public void DeletePost(int postid)
        {
            _blogOperation.DeletePost(postid);
        }
    }
}
