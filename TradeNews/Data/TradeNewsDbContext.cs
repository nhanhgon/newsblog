using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TradeNews.Data
{
    public class TradeNewsDbContext : IdentityDbContext
    {
        public TradeNewsDbContext(DbContextOptions<TradeNewsDbContext> options)
            : base(options)
        {
        }
    }
}
