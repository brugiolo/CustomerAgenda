using AutoMapper;
using CustomerAgenda.Api.ViewModels;
using CustomerAgenda.Business.Models;

namespace CustomerAgenda.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
            CreateMap<Hostel, HostelViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<PhoneContact, PhoneContacViewModel>().ReverseMap();
        }
    }
}
