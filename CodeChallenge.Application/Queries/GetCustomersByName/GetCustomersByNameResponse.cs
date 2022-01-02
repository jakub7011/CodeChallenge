using CodeChallenge.Application.Models.Enums;
using CodeChallenge.Domain.Customers;
using System.Collections.Generic;

namespace CodeChallenge.Application.Queries.GetCustomersByName
{
    public class GetCustomersByNameResponse
    {
        public List<Customer> Customers { get; private set; }

        public string ErrorMessage { get; private set; }

        public StatusCode StatusCode { get; private set; }

        public GetCustomersByNameResponse(string errorMessage, StatusCode statusCode)
        {  
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
        }

        public GetCustomersByNameResponse(List<Customer> customers)
        {
            Customers = customers;
        }
    }
}
