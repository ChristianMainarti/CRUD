using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace CRUD_SATS.Models
{
    class DbConfiguration : DbContext
    {
        public DbConfiguration()
        {
        }
    }
}
