namespace MovyxEstoque.Api.DTOs
{
    public class CreatePeriodDto
    {
        public DateTime Date { get; set; }
        public string Label { get; set; } = string.Empty;

        // Dicionário para receber os saldos: Chave = ProductId, Valor = Quantidade
        public Dictionary<int, int> Balances { get; set; } = new Dictionary<int, int>();
    }
}