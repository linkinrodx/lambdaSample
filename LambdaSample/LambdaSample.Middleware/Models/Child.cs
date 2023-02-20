namespace LambdaSample.Middleware.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int Bank_id_sending_from { get; set; }
        public string? Bank_name_sending_from { get; set; }
        public string? Bank_short_name_sending_from { get; set; }
        public int Bank_id_sending_to { get; set; }
        public string? Bank_name_sending_to { get; set; }
        public string? Bank_short_name_sending_to { get; set; }
        public string? Type { get; set; }
        public string? Exchange_rate { get; set; }
        public string? Min_amount { get; set; }
        public decimal Max_amount { get; set; }
        public string? Stock { get; set; }
        public decimal Remaining_amount { get; set; }
        public DateTime Date_end { get; set; }
        public int Pips { get; set; }
        public decimal Discount { get; set; }
    }
}
