using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmBlog.Models.Class
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; } //Adminin vt karsiligi admins olacak
        public DbSet<Anasayfa> Anasayfas { get; set; }

    }
}