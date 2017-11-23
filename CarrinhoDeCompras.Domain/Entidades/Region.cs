using System.Collections.Generic;

namespace CarrinhoDeCompras.Domain.Entidades
{
    public partial class Region
    {
        public Region()
        {
            this.Territories = new HashSet<Territories>();
        }

        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territories> Territories { get; set; }
    }
}