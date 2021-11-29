using System;

namespace api.Models
{
    public class CommentModel
    {
        public string Author { get; set; }

        public string Content { get; set; }

        public ECommentState State { get; set; }

        public Guid Id { get; set; }
    }
}