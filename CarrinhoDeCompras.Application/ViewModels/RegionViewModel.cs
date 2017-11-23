using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarrinhoDeCompras.Application.ViewModels
{
    public class RegionViewModel
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
       // public virtual ICollection<TerritoriesViewModel> Territories { get; set; }
    }
}