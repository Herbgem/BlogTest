using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public interface IPost
    {
        int Id { get; set; }
         int PostId { get; set; }
         string PostTitle { get; set; }
         string PostDescription { get; set; }
         string PostContent { get; set; }
         string PostAuthor { get; set; }
         DateTime PostCreated { get; set; }
         DateTime PostModified { get; set; }
         int BlogId { get; set; }
    }
}
