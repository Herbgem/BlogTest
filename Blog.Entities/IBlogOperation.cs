using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public interface IBlogOperation
    {
        void AddPost(IPost post);
        IList<IPost> ReviewPosts();
        IPost ReviewPost(int postid);
        void UpdatePost(int postid, Post newpost);
        void DeletePost(int postid);
    }
}
