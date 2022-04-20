using Ficticia.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ficticia
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ClienteContext>(options => options.UseSqlServer(Configuration.GetConnectionString("@Data Source=LAPTOP-O45LS83J\\SQLEXPRESS;Initial Catalog=dbVisual;Integrated Security=True")));
        
            }

        
    }
}