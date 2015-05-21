using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities;
using System.Data;
using System.Data.SqlClient;

namespace BlogData
{
    public class BlogOperations : IBlogOperation
    {
        private BlogDb _blogDb;
        private DataConnection _dataConnection;
        private string _blogName;

        public BlogOperations(string blogowner)
        {
            DataConnection tempconnection = new DataConnection();
            tempconnection.Command.CommandText = string.Format("select {0} from {1} where {2} = {3}", _blogDb.Blogs.BlogIdColumn.ColumnName, _blogDb.Blogs.TableName, _blogDb.Blogs.BlogOwnerColumn.ColumnName, blogowner);
            tempconnection.Command.Connection.Open();
            int blogid = Convert.ToInt32(tempconnection.Command.ExecuteScalar());
            tempconnection.Command.Dispose();
            tempconnection.Command.Connection.Close();

            _dataConnection = new DataConnection(string.Format("select * from {0} where {1} = {2}", _blogDb.Posts.TableName, _blogDb.Posts.BlogIdColumn.ColumnName, blogid));
            _dataConnection.Adapter.Fill(_blogDb, _blogDb.Posts.TableName);
        }

        public void AddPost(IPost post)
        {
            _blogDb.Posts.AddPostsRow(post.PostId, post.PostTitle, post.PostDescription, post.PostContent, post.PostAuthor, post.PostCreated, post.PostModified, _blogDb.Blogs.FindByBlogId(post.BlogId));
            _dataConnection.Adapter.Update(_blogDb, _blogDb.Posts.TableName);
        }


        public IList<IPost> ReviewPosts()
        {
            List<IPost> posts = (from singlepost in _blogDb.Posts.Rows.Cast<BlogDb.PostsRow>()
                                select new Post
                                {
                                    PostId = singlepost.PostId,
                                    BlogId = singlepost.BlogId,
                                    PostAuthor = singlepost.PostAuthor,
                                    PostContent = singlepost.PostContent,
                                    PostDescription = singlepost.PostDescription,
                                    PostTitle = singlepost.PostTitle,
                                    PostCreated = singlepost.PostCreatedTime,
                                    PostModified = singlepost.PostModifiedTime
                                }).ToList<IPost>();
            return posts;
        }

        public IPost ReviewPost(int postid)
        {
            BlogDb.PostsRow post = _blogDb.Posts.FindById(postid);
            return new Post
            {
                PostId = post.PostId,
                BlogId = post.BlogId,
                PostAuthor = post.PostAuthor,
                PostContent = post.PostContent,
                PostDescription = post.PostDescription,
                PostTitle = post.PostTitle,
                PostCreated = post.PostCreatedTime,
                PostModified = post.PostModifiedTime
            };
        }

        public void UpdatePost(int postid, string content)
        {
            BlogDb.PostsRow post = _blogDb.Posts.FindById(postid);
            post.PostContent = content;
            post.PostCreatedTime = DateTime.Now;
            _dataConnection.Adapter.Update(_blogDb, _blogDb.Posts.TableName);
        }

        public void DeletePost(int postid)
        {
            _blogDb.Posts.FindById(postid).Delete();
            _dataConnection.Adapter.Update(_blogDb, _blogDb.Posts.TableName);
        }
    }
}
