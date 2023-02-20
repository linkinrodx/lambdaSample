using System.Text.Json.Serialization;

namespace LambdaSample.Core.Models
{
    public class Parent
    {
        [JsonPropertyName("pk")]
        public string Pk => Id;

        [JsonPropertyName("sk")]
        public string Sk => Pk;

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        [JsonPropertyName("buying_rate")]
        public decimal Buying_rate { get; init; } = default!;

        [JsonPropertyName("selling_rate")]
        public decimal Selling_rate { get; init; } = default!;

        [JsonPropertyName("text_updated_at")]
        public string? Text_updated_at { get; init; } = default!;

        [JsonPropertyName("ibk_buying_rate")]
        public decimal Ibk_buying_rate { get; init; } = default!;

        [JsonPropertyName("ibk_selling_rate")]
        public decimal Ibk_selling_rate { get; init; } = default!;
    }
}
