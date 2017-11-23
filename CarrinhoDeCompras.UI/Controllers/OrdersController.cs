using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarrinhoDeCompras.UI.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IAppServiceOrders _AppServiceOrders;
        private readonly IAppServiceCustomers _AppServiceCustomers;
        private readonly IAppServiceProducts _AppServiceProducts;
        private readonly int CustomerID = 85;
        public const string OrderIdSessionKey = "OrderId";

        public OrdersController(IAppServiceOrders appServiceOrders,
            IAppServiceProducts appServiceProducts,
            IAppServiceCustomers appServiceCustomers
            )
        {
            _AppServiceOrders = appServiceOrders;
            _AppServiceProducts = appServiceProducts;
            _AppServiceCustomers = appServiceCustomers;
        }

        // GET: Orders
        public ActionResult Index()
        {
            var OrdersViewModel = _AppServiceOrders.GetOrdersByCustomerID(CustomerID);
            return View(OrdersViewModel);
        }

        // GET: Orders/NovoPedido
        public ActionResult NovoPedido()
        {
            var produtos = _AppServiceProducts.GetAll();
            return View(produtos);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            var OrderDetailsViewModel = _AppServiceOrders.GetById(id);
            return View(OrderDetailsViewModel);
        }

        // GET: Orders/Create
        public ActionResult AddToCart()
        {
            var order = new Orders()
            {
                CustomerID = CustomerID,
                Freight = 12,
                RequiredDate = DateTime.Now,
            };
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddToCart(int id)
        {
            var produto = _AppServiceProducts.GetById(id);
            var order = new Orders()
            {
                CustomerID = CustomerID,
                Freight = 12,
                RequiredDate = DateTime.Now,
            };

            _AppServiceOrders.Add(order);
            return RedirectToAction("Index");

            //return View(orders);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            var ordersViewModel = _AppServiceOrders.GetById(id);
            return View(ordersViewModel);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Orders orders)
        {
            if (ModelState.IsValid)
            {
                _AppServiceOrders.Update(orders);

                return RedirectToAction("Index");
            }
            return View(orders);
        }

        private byte[] SetLogotipo(HttpPostedFileBase logotipo)
        {
            var bytesLogotipo = new byte[logotipo.ContentLength];
            logotipo.InputStream.Read(bytesLogotipo, 0, logotipo.ContentLength);
            return bytesLogotipo;
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            var categoriesViewModel = _AppServiceOrders.GetById(id);
            if (categoriesViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoriesViewModel);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _AppServiceOrders.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
