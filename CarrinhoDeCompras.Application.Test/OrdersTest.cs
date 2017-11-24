using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Infra.Data.EF.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarrinhoDeCompras.Application.Test
{
    [TestClass]
    public class OrdersTest
    {
        private  IRepositorioOrders _repositorio;
        [TestMethod]
        public void IncluirPedidos()
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


            try
            {
                _repositorio = new RepositorioOrders();
                _repositorio.Add(order);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
