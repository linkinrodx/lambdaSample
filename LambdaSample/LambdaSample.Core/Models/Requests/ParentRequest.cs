namespace LambdaSample.Core.Models.Requests
{
    public class ParentRequest
    {
        public decimal Buying_rate { get; init; } = default!;
        public decimal Selling_rate { get; init; } = default!;
        public string Text_updated_at { get; init; } = default!;
        public decimal Ibk_buying_rate { get; init; } = default!;
        public decimal Ibk_selling_rate { get; init; } = default!;
    }
}
