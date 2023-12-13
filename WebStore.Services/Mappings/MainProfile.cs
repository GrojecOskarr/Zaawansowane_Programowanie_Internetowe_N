using AutoMapper;
using WebStore.Model.Entities;
using WebStore.ViewModels.VM;

namespace WebStore.Services.Mappings
{
    public class MainProfile : Profile
    {
        
        public MainProfile()
        {

           // CreateMap<Product, ProductVm>();
          //  CreateMap<ProductVm, Product>();
           /// CreateMap<Product, AddOrUpdateProductVm>();
          //  CreateMap<AddOrUpdateProductVm, Product>();

          //  CreateMap<Order,Order>();
            //CreateMap<OrderVm,Order>();

           // CreateMap<Address, Address>();
           // CreateMap<AddressVm, Address>();

         //  CreateMap<User,User>()
         //       .Include<Customer, Customer>()
          //      .Include<Supplier, Supplier>();
          //  CreateMap<Customer,Customer>();
          //  CreateMap<Supplier, Supplier>();

           // CreateMap<Invoice, Invoice>();
           // CreateMap<Invoice, Invoice>();

          //  CreateMap<StationaryStore, StationaryStore>();
         //   CreateMap<StationaryStore, StationaryStore>();

            //CreateMap<RegisterUserVm, User>();
           // CreateMap<User, RegisterUserVm>();
        }
    }
}