using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public interface IBlog
    {
        int BlogId { get; set; }
        string BlogTitle { get; set; }
        string BlogDescription { get; set; }
        string BlogOwner { get; set; }
        DateTime BlogCreatedTime { get; set; }
        DateTime BlogModifiedTime { get; set; }
        void CreatePost(IPost post);
        void ReviewPost(IPost post);
        void UpdatePost(IPost post);
        void DeletePost(IPost post);
    }
}
