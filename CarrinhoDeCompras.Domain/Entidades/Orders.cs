using CarrinhoDeCompras.Domain.Interfaces.Validation;
using CarrinhoDeCompras.Domain.Validation;
using System;
using System.Collections.Generic;

namespace CarrinhoDeCompras.Domain.Entidades
{
    public partial class Orders : ISelfValidation
    {
        public Orders()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
            this.Employees = new Employees();
            this.Customers = new Customers();
            this.Shippers = new Shippers();
        }

        public int OrderID { get; set; }
        public int? CustomerID { get; set; }
        public string Customer { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual Shippers Shippers { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                return true;
                //var fiscal = new OrderIsValidValidation();
                //ValidationResult = fiscal.Valid(this);
                //return ValidationResult.IsValid;
            }
        }
    }
}