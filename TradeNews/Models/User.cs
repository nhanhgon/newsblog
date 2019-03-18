using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TradeNews.Models
{
    public class User : IdentityUser
    {

        public User() : base()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Status = UserStatus.Pending;
        }

        public string FullName { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserStatus Status { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }

    public enum UserStatus
    {

        Deactive = 0,
        Active = 1,
        Pending = 2
    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
        Other = 2
    }
}
