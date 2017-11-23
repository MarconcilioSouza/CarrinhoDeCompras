using AutoMapper;
using CarrinhoDeCompras.Application.ViewModels;
using CarrinhoDeCompras.Domain.Entidades;

namespace CarrinhoDeCompras.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriesViewModel, Categories>();
            CreateMap<CustomerDemographicsViewModel, CustomerDemographics>();
            CreateMap<CustomersViewModel, Customers>();
            CreateMap<EmployeesViewModel, Employees>();
            CreateMap<OrderDetailsViewModel, OrderDetails>();
            CreateMap<OrdersViewModel, Orders>();
            CreateMap<ProductsViewModel, Products>();
            CreateMap<RegionViewModel, Region>();
            CreateMap<ShippersViewModel, Shippers>();
            CreateMap<SuppliersViewModel, Suppliers>();
            CreateMap<TerritoriesViewModel, Territories>();
        }
    }
}
