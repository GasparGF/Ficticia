using Ficticia.Models;
using Microsoft.EntityFrameworkCore;

namespace Ficticia.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
