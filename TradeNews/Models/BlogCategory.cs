using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TradeNews.Models
{
    public class BlogCategory
    {
        public BlogCategory()
        {
            this.Status = BStatus.ACTIVE;
        }

        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public BStatus Status { get; set; }
    }

    public enum BStatus
    {
        DISABLED = 0,
        ACTIVE = 1
    }
}
