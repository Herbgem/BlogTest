using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Post : IPost
    {
        public int Id
        {
            get;
            set;
        }
        public int PostId
        {
            get;
            set;
        }

        public string PostTitle
        {
            get;
            set;
        }

        public string PostDescription
        {
            get;
            set;
        }

        public string PostContent
        {
            get;
            set;
        }

        public string PostAuthor
        {
            get;
            set;
        }

        public DateTime PostCreated
        {
            get;
            set;
        }

        public DateTime PostModified
        {
            get;
            set;
        }

        public int BlogId
        {
            get;
            set;
        }

        public Post(string posttitle, string description, string content, string author, DateTime createdtime, DateTime modifiedtime, int blogid)
        {
            this.PostTitle = posttitle;
            this.PostDescription = description;
            this.PostContent = content;
            this.PostAuthor = author;
            this.PostCreated = createdtime;
            this.PostModified = modifiedtime;
            this.BlogId = blogid;
        }

        public Post() { }
    }
}
