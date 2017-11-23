using System;
using System.Collections.Generic;
using AutoMapper;
using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;
using CarrinhoDeCompras.Application.ViewModels;
using CarrinhoDeCompras.Application.AutoMapper;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceCategories : IAppServiceCategories
    {
        private readonly IServiceCategories _repositorio;
        private readonly IMapper _mapper;

        public AppServiceCategories(IServiceCategories repositorio)
        {
            _repositorio = repositorio;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<Categories> GetAll()
        {
            return _repositorio.GetAll();
        }

        public Categories GetById(int id)
        {
            return _repositorio.GetById(id);
        }

        public void Register(Categories categoria)
        {
            _repositorio.Add(categoria);
        }

        public void Update(Categories categoria)
        {
            _repositorio.Update(categoria);
        }

        public void Remove(Categories categoria)
        {
            _repositorio.Remove(categoria);
        }

        public void Remove(int id)
        {
            _repositorio.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //public IEnumerable<CategoriesViewModel> GetAll()
        //{
        //    return _mapper.Map<IEnumerable<CategoriesViewModel>>(_repositorio.GetAll());
        //}

        //public CategoriesViewModel GetById(int id)
        //{
        //    return _mapper.Map<CategoriesViewModel>(_repositorio.GetById(id));
        //}

        //public void Register(CategoriesViewModel customerViewModel)
        //{
        //    var categoria = _mapper.Map<Categories>(customerViewModel);
        //    _repositorio.Add(categoria);
        //}

        //public void Update(CategoriesViewModel customerViewModel)
        //{
        //    var categoria = _mapper.Map<Categories>(customerViewModel);
        //    _repositorio.Update(categoria);
        //}

        //public void Remove(CategoriesViewModel customerViewModel)
        //{
        //    var categoria = _mapper.Map<Categories>(customerViewModel);
        //    _repositorio.Remove(categoria);
        //}

        //public void Remove(int id)
        //{
        //    _repositorio.Remove(id);
        //}

        //public void Dispose()
        //{
        //    GC.SuppressFinalize(this);
        //}        
    }
}
