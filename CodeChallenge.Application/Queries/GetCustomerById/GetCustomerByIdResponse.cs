using CodeChallenge.Application.Models.Enums;
using CodeChallenge.Domain.Customers;

namespace CodeChallenge.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdResponse
    {
        public Customer Customer { get; private set; }

        public string ErrorMessage { get; private set; }

        public StatusCode StatusCode { get; private set; }

        public GetCustomerByIdResponse(string errorMessage, StatusCode statusCode)
        {
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
        }

        public GetCustomerByIdResponse(Customer customer)
        {
            Customer = customer;
        }
    }
}
