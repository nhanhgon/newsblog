using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
