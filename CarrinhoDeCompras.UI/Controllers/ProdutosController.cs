using CarrinhoDeCompras.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarrinhoDeCompras.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IAppServiceProducts _AppServiceProducts;

        public ProdutosController(IAppServiceProducts appService)
        {
            _AppServiceProducts = appService;
        }

        // GET: Produtos
        public ActionResult Index()
        {
            var productsViewModel = _AppServiceProducts.GetAll();
            return View(productsViewModel);
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            var productsViewModel = _AppServiceProducts.GetById(id);
            return View(productsViewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
