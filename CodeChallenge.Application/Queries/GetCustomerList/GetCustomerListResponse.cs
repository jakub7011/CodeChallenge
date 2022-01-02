using CodeChallenge.Application.Models.Enums;
using CodeChallenge.Domain.Customers;
using System.Collections.Generic;

namespace CodeChallenge.Application.Queries.GetCustomerList
{
    public class GetCustomerListResponse
    {
        public List<Customer> Customers { get; private set; }

        public string ErrorMessage { get; private set; }

        public StatusCode StatusCode { get; private set; }

        public GetCustomerListResponse(string errorMessage, StatusCode statusCode)
        {
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
        }

        public GetCustomerListResponse(List<Customer> customers)
        {
            Customers = customers;
        }
    }
}
