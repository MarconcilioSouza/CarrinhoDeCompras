using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using System.Web;
using System.Web.Mvc;

namespace CarrinhoDeCompras.UI.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly IAppServiceCategories _AppServiceCategories;

        public CategoriasController(IAppServiceCategories appService)
        {
            _AppServiceCategories = appService;
        }
        // GET: Categoria
        public ActionResult Index()
        {
            var categoriesViewModel = _AppServiceCategories.GetAll();
            return View(categoriesViewModel);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var categoriesViewModel = _AppServiceCategories.GetById(id);
            return View(categoriesViewModel);
        }

        // GET: Categoria/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categories categoria)
        {
            if (ModelState.IsValid)
            {
                _AppServiceCategories.Register(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var categoriesViewModel = _AppServiceCategories.GetById(id);
            return View(categoriesViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categories categoria, HttpPostedFileBase logotipo = null, string chkRemoverImagem = null)
        {
            if (ModelState.IsValid)
            {
                categoria.Picture = SetLogotipo(logotipo);
                _AppServiceCategories.Update(categoria);

                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        private byte[] SetLogotipo(HttpPostedFileBase logotipo)
        {
            var bytesLogotipo = new byte[logotipo.ContentLength];
            logotipo.InputStream.Read(bytesLogotipo, 0, logotipo.ContentLength);
            return bytesLogotipo;
        }
        //// POST: Categoria/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(CategoriesViewModel categoria)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _AppServiceCategories.Update(categoria);

        //        return RedirectToAction("Index");
        //    }

        //    return View(categoria);
        //}

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var categoriesViewModel = _AppServiceCategories.GetById(id);
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
            _AppServiceCategories.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
