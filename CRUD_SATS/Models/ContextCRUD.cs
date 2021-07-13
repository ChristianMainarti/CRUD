using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace CRUD_SATS.Models
{
    class ContextCRUD: DbContext
    {
        public ContextCRUD() : base("crud_sats")
        {

        }
        public DbSet<Ponto> Pontos { get; set; }
        public DbSet<Macro> Macros { get; set; }
        public DbSet<Tipo_Ponto> Tipo_Pontos { get; set; }
        public DbSet<ConfigVaz> ConfigVazs { get; set; }
        public DbSet<ConfigNv> ConfigNvs { get; set; }
        public DbSet<ConfigBomba> ConfigBombas { get; set; }
        public DbSet<Leitura> Leituras { get; set; }
        public DbSet<LeituraVazão> LeituraVazãos { get; set; }
        public DbSet<LeituraNível> LeituraNívels { get; set; }
        public DbSet<LeituraBomba> LeituraBombas { get; set; }
    }
}
