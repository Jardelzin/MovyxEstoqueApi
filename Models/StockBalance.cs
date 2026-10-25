namespace MovyxEstoque.Api.Models
{
    public class StockBalance
    {

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int PeriodId { get; set; }
        public Period Period { get; set; } = null!;

        public int Quantity { get; set; }

    }
}
