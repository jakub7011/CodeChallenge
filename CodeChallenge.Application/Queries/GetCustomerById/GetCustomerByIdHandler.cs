using CodeChallenge.Application.Models.Enums;
using CodeChallenge.Application.Models.Interfaces;
using System;

namespace CodeChallenge.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdHandler
    {
        private readonly ICustomerService customerService;

        public GetCustomerByIdHandler(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public GetCustomerByIdResponse Handle(GetCustomerByIdQuery query)
        {
            try
            {
                if (query.Id <= 0)
                    throw new Exception("Customer Id must be greater than zero.");

                var customer = customerService.GetCustomerById(query.Id);
                if (customer == null)
                    throw new Exception($"Could not find Customer with Id '{query.Id}'.");

                return new GetCustomerByIdResponse(customer);
            }
            catch (Exception ex)
            {
                return new GetCustomerByIdResponse(ex.Message, StatusCode.InternalServerError);
            }
        }
    }
}
