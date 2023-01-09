using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmBlog.Models.Class
{
    public class Anasayfa
    {
        [Key]
        public int id { get; set; }
        public string resim { get; set; }
    }
}