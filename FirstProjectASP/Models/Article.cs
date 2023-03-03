using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FirstProjectASP.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime ArticleDate { get; set; }
        public string Image { get; set; }
        public string ImageFull { get; set; }

        public class ArtDBContext : DbContext
        {
            public ArtDBContext()
            { }
            public DbSet<Article> Article { get; set; }
        }
    }
}