using AutoMapper;
using CustomerAgenda.Api.ViewModels;
using CustomerAgenda.Business.Interfaces;
using CustomerAgenda.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CustomerAgenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IAddressService _addressService;
        private readonly IPhoneContactService _phoneContactService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IAddressService addressService, 
            IPhoneContactService phoneContactService, IMapper mapper)
        {
            _customerService = customerService;
            _addressService = addressService;
            _phoneContactService = phoneContactService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Insert(CustomerViewModel customerViewModel)
        {
            var customerModel = _mapper.Map<Customer>(customerViewModel);
            _customerService.Insert(customerModel);

            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerViewModel> Read(Guid id)
        {
            var customer = _customerService.Read(id);
            customer.Addresses = _addressService.GetAll(customer.Id, customer.HostelKey).ToList();
            customer.PhoneContacts = _phoneContactService.GetAll(customer.Id, customer.HostelKey).ToList();

            return _mapper.Map<CustomerViewModel>(customer);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var customer = _customerService.Read(id);
            var CustomerViewModel = _mapper.Map<CustomerViewModel>(customer);

            if (CustomerViewModel == null)
                return NotFound();

            _customerService.Delete(id);

            return Ok(CustomerViewModel);
        }
    }
}
