using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace CRUD_SATS.Models
{
    class ContextCRUD: DbContext
    {
        public ContextCRUD() : base()
        {

        }
        public DbSet<Ponto> Pontos { get; set; }
        public DbSet<Macro> Macros { get; set; }
        public DbSet<Tipo_Ponto> Tipo_Pontos { get; set; }
        public DbSet<ConfigVaz> ConfigVazs { get; set; }
        public DbSet<ConfigNv> ConfigNvs { get; set; }
        public DbSet<ConfigBomba> ConfigBombas { get; set; }

    }
}
