namespace LambdaSample.Core.Models.Responses
{
    public class ParentResponse
    {
        public Guid Id { get; init; }
        public decimal Buying_rate { get; init; } = default!;
        public decimal Selling_rate { get; init; } = default!;
        public string Text_updated_at { get; init; } = default!;
        public decimal Ibk_buying_rate { get; init; } = default!;
        public decimal Ibk_selling_rate { get; init; } = default!;
    }
}
