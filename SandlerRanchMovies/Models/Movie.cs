using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SandlerRanchMovies.Models
{
    /* Movie Details 
     */ 
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Desciption { get; set; }
    }
    /* MovieDBContext class represents the Entity Framework movie database context, 
     * which handles fetching, storing, and updating Movie class instances in a database*/
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}