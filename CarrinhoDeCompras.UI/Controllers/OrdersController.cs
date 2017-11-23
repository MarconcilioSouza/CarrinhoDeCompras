using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using System.Web;
using System.Web.Mvc;

namespace CarrinhoDeCompras.UI.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IAppServiceOrders _AppServiceOrders;

        public OrdersController(IAppServiceOrders appService)
        {
            _AppServiceOrders = appService;
        }
       
        // GET: Orders
        public ActionResult Index()
        {
            var OrdersViewModel = _AppServiceOrders.GetAll();
            return View(OrdersViewModel);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            var OrderDetailsViewModel = _AppServiceOrders.GetById(id);
            return View(OrderDetailsViewModel);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Orders orders)
        {
            if (ModelState.IsValid)
            {
                _AppServiceOrders.Add(orders);

                return RedirectToAction("Index");
            }

            return View(orders);
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
