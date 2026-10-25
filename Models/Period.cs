namespace MovyxEstoque.Api.Models
{
    public class Period
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string Label { get; set; } = string.Empty;

        // Navigation property

        public ICollection<StockBalance> Balances { get; set; } = new List<StockBalance>();


    }
}
