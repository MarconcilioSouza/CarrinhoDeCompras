using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarrinhoDeCompras.Application.ViewModels
{
    public class CustomersViewModel
    {
        [Key]
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        //public virtual ICollection<OrdersViewModel> Orders { get; set; }
       // public virtual ICollection<CustomerDemographicsViewModel> CustomerDemographics { get; set; }
    }
}