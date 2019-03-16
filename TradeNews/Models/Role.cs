using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TradeNews.Models
{
    public class Role : IdentityRole
    {
        public Role() : base() { }

        public Role(string roleName) : base(roleName)
        {

        }

        public Role(string roleName, string description, DateTime createdAt) : base(roleName)
        {
            this.Description = description;
            this.CreatedAt = createdAt;
        }

        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
