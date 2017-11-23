using CarrinhoDeCompras.Application.ViewModels;
using CarrinhoDeCompras.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace CarrinhoDeCompras.Application.Interfaces
{
    public interface IAppServiceCategories : IDisposable
    {
        //void Register(CategoriesViewModel customerViewModel);
        //IEnumerable<CategoriesViewModel> GetAll();
        //CategoriesViewModel GetById(int id);
        //void Update(CategoriesViewModel customerViewModel);
        //void Remove(int id);
        //void Remove(CategoriesViewModel id);

        void Register(Categories customerViewModel);
        IEnumerable<Categories> GetAll();
        Categories GetById(int id);
        void Update(Categories customerViewModel);
        void Remove(int id);
        void Remove(Categories id);
    }
}
