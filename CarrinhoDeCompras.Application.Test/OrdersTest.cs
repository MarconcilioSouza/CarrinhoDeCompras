using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Interfaces.Services;
using CarrinhoDeCompras.Domain.Services;
using CarrinhoDeCompras.Domain.Entidades;
using Moq;

namespace CarrinhoDeCompras.Application.Test
{
    [TestClass]
    public class OrdersTest
    {
        private readonly IAppServiceOrders _AppServiceOrders;
        private readonly IAppServiceCustomers _AppServiceCustomers;
        private readonly IAppServiceProducts _AppServiceProducts;
        private readonly int CustomerID = 85;
        [TestMethod]
        public void InclirPedidos()
        {
            var order = new Orders()
            {
                CustomerID = 85,
                Customer = "VINET",
                EmployeeID = 5,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                ShipVia = 3,
                Freight = 13,
                ShipName = "Vins et alcools Chevalier",
                ShipAddress = "59 rue de l'Abbaye",
                ShipCity = "Reims",
                ShipPostalCode = "51100",
                ShipCountry = "France",
            };

            var mockRepo = new Mock<IAppServiceOrders>();
            mockRepo.Setup(x => x.Add(order));


        }
    }
}
