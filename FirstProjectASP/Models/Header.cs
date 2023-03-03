using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FirstProjectASP.Models
{
    public class Header
    {
        [Key]
        public int IdHeader { get; set; }
        public string TitleHeader { get; set; }
        public string DescriptionHeader { get; set; }

        public class HeaderDBContext : DbContext
        {
            public HeaderDBContext()
            { }
            public DbSet<Header> Header { get; set; }
        }
    }
}