using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Erantissen_Backend.App.Models.Requests.Create
{
    public class CreateNewPaymentRequest
    {
        [JsonPropertyName("locale")]
        public string Locale { get; set; }
        [JsonPropertyName("payment_methods")]
        public List<string> PaymentMethods { get; set; }

        [JsonPropertyName("order")]
        public Order Order { get; set; }
    }

    public class Order
    {
        [JsonPropertyName("handle")]
        public string Handle { get; set; }
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        [JsonPropertyName("order_lines")]
        public List<OrderLine> OrderLines { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }

    public class Customer
    {
        [JsonPropertyName("handle")]
        public string Handle { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }

    public class OrderLine
    {
        [JsonPropertyName("ordertext")]
        public string Ordertext { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("vat")]
        public double Vat { get; set; }

        [JsonPropertyName("amount_incl_vat")]
        public bool AmountInclVat { get; set; }
    }
}
