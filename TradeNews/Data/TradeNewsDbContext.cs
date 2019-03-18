using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TradeNews.Models;

namespace TradeNews.Data
{
    public class TradeNewsDbContext : IdentityDbContext<User, Role, string>
    {
        public TradeNewsDbContext(DbContextOptions<TradeNewsDbContext> options)
            : base(options)
        {
        }
        public DbSet<TradeNews.Models.BlogCategory> PostCategory { get; set; }
        public DbSet<TradeNews.Models.Blog> Blog { get; set; }
        
    }
}
