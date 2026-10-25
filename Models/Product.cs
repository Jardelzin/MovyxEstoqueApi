namespace MovyxEstoque.Api.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string Category { get; set; } = string.Empty;
        
        public string Model { get; set; } = string.Empty;
        
        // Navigation property

        public ICollection<StockBalance> Balances { get; set; } = new List<StockBalance>();

    }
}
