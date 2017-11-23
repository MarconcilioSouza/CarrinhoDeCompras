
using CarrinhoDeCompras.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CarrinhoDeCompras.Infra.Data.EF.EntityConfig
{

    public class TerritoriesConfiguration : EntityTypeConfiguration<Territories>
    {
        public TerritoriesConfiguration()
        {
            HasKey(p => p.TerritoryID);
            Property(p => p.TerritoryDescription).HasMaxLength(50).IsRequired();
        }
    }
}
