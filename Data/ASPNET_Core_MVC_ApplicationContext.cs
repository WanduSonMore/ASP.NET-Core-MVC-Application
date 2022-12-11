using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_MVC_Application.Models;

namespace ASP.NET_Core_MVC_Application.Data
{
    public class ASPNET_Core_MVC_ApplicationContext : DbContext
    {
        public ASPNET_Core_MVC_ApplicationContext (DbContextOptions<ASPNET_Core_MVC_ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_Core_MVC_Application.Models.Movie> Movie { get; set; } = default!;
    }
}
