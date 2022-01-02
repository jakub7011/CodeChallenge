using CodeChallenge.Application.Models.Enums;
using CodeChallenge.Application.Models.Interfaces;
using System;
using System.Linq;

namespace CodeChallenge.Application.Queries.GetCustomersByName
{
    public class GetCustomersByNameHandler
    {
        private readonly ICustomerService customerService;

        public GetCustomersByNameHandler(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public GetCustomersByNameResponse Handle(GetCustomersByNameQuery query)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(query.Name))
                    throw new Exception($"Customer name is required.");

                var customers = customerService.GetCustomersByName(query.Name)
                                               .ToList();

                if (customers == null)
                    throw new Exception($"Could not load customer list.");

                return new GetCustomersByNameResponse(customers);
            }
            catch (Exception ex)
            {
                return new GetCustomersByNameResponse(ex.Message, StatusCode.InternalServerError);
            }
        }
    }
}
