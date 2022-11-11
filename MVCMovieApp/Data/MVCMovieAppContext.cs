using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MVCMovieApp.Data
{
    public class MVCMovieAppContext : DbContext
    {
        public MVCMovieAppContext (DbContextOptions<MVCMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
