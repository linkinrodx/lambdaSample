namespace LambdaSample.Middleware.Models
{
    public class Parent
    {
        public Parent()
        {
            Campaigns = new List<Child>();
        }

        public decimal Buying_rate { get; set; }
        public decimal Selling_rate { get; set; }
        public string? Text_updated_at { get; set; }
        public decimal Ibk_buying_rate { get; set; }
        public decimal Ibk_selling_rate { get; set; }

        public List<Child> Campaigns { get; set; }
    }
}
