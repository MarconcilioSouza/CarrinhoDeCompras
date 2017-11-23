using AutoMapper;
using CarrinhoDeCompras.Application.ViewModels;
using CarrinhoDeCompras.Domain.Entidades;

namespace CarrinhoDeCompras.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Categories, CategoriesViewModel>();
            CreateMap<CustomerDemographics, CustomerDemographicsViewModel>();
            CreateMap<Customers, CustomersViewModel>();
            CreateMap<Employees, EmployeesViewModel>();
            CreateMap<OrderDetails, OrderDetailsViewModel>();
            CreateMap<Orders, OrdersViewModel>();
            CreateMap<Products, ProductsViewModel>();
            CreateMap<Region, RegionViewModel>();
            CreateMap<Shippers, ShippersViewModel>();
            CreateMap<Suppliers, SuppliersViewModel>();
            CreateMap<Territories, TerritoriesViewModel>();
        }
    }
}
