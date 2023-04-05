using System.Data.Entity;

namespace RoboSelenium.Models
{
    public class ResultadoContext : DbContext
    {
        public ResultadoContext() : base("RoboSelenium")
        {
        }

        public DbSet<ResultadoBusca> ResultadosBusca { get; set; }
    }
}
