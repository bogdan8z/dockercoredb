using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql;
using Npgsql.NameTranslation;

namespace ProductsApi.Models
{
    public partial class MyDbContext : DbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            FixSnakeCaseNames(modelBuilder);
        }

        private void FixSnakeCaseNames(ModelBuilder modelBuilder)
        {
            var mapper = new NpgsqlSnakeCaseNameTranslator();
            foreach (var table in modelBuilder.Model.GetEntityTypes())
            {
                ConvertToSnake(mapper, table);
                foreach (var property in table.GetProperties())
                {
                    ConvertToSnake(mapper, property);
                }
            }
        }

        private void ConvertToSnake(INpgsqlNameTranslator mapper, object entity)
        {
            switch (entity)
            {
                case IMutableEntityType table:
                    table.SetTableName(table.GetTableName().ToLowerInvariant());
                    break;
                case IMutableProperty property:
                    property.SetColumnName(property.GetColumnName().ToLowerInvariant()); 
                    break;
            }
        }

    }
}
