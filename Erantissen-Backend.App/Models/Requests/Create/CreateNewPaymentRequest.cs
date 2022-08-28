using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Erantissen_Backend.App.Models.Requests.Create
{
    public class CreateNewPaymentRequest
    {
        [JsonPropertyName("cancel_url")]
        public string CancelUrl { get; set; }

        [JsonPropertyName("success_url")]
        public string SuccessUrl { get; set; }

        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; set; }
    }

    public class TaxRates
    {
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("inclusive")]
        public bool Inclusive { get; set; }

        [JsonPropertyName("percentage")]
        public int Percentage { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
    public class LineItem
    {
        [JsonPropertyName("price")]
        public Price Price { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("tax_rates")]
        public TaxRates TaxRates { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("product")]
        public string Product { get; set; }

        [JsonPropertyName("unit_amount")]
        public int UnitAmount { get; set; }
    }
}
