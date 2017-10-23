using System.Data.Entity;

namespace WebApplication1.Models.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto(): base("strConn")
        {

        }

        public System.Data.Entity.DbSet<WebApplication1.Models.TipoItem> TipoItems { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.item> items { get; set; }
    }
}