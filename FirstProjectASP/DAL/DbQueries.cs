using FirstProjectASP.Models;
using System.Collections.Generic;
using System.Linq;
using static FirstProjectASP.Models.Article;
using static FirstProjectASP.Models.Header;

namespace FirstProjectASP.DAL
{
    public static class DbQueries
    {
        private static ArtDBContext db = new ArtDBContext();
        private static HeaderDBContext hdb = new HeaderDBContext();

        public static List<Article> GetArticles()
        {
            List<Article> articles = (from e in db.Article select e).ToList();
            return articles;
        }

        public static Header GetHeader()
        {
            Header header = (from h in hdb.Header select h).FirstOrDefault();
            return header;
        }
    }
}