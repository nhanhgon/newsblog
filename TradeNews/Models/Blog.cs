using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradeNews.Models
{
    public class Blog
    {
        public Blog()
        {

        }

        public Blog(string title, string content, string thumbnail)
        {
            this.CreatedAt = DateTime.Now;
            this.Status = BlogStatus.PENDING;
        }

        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        public string Content { get; set; }
        [MaxLength(500)]
        public string Thumbnail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public BlogStatus Status { get; set; }
        public BlogCategory Category { get; set; }
        public string AuthorId { get; set; }
        public User Author { get; set; }
    }
    public enum BlogStatus
    {
        PUBLISH = 0,
        PRIVATE = 1,
        TRASH = 2,
        PENDING = 3
    }
}
