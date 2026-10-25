using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovyxEstoque.Api.Data;
using MovyxEstoque.Api.Models;
using MovyxEstoque.Api.DTOs;

namespace MovyxEstoque.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PeriodsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/periods
        [HttpGet]
        public async Task<ActionResult> GetPeriods()
        {
            // Retorna os períodos já formatados com os saldos para o gráfico do front-end
            var periods = await _context.Periods
                .Include(p => p.Balances)
                .OrderBy(p => p.Date)
                .Select(p => new {
                    p.Id,
                    p.Date,
                    p.Label,
                    Values = p.Balances.ToDictionary(b => b.ProductId.ToString(), b => b.Quantity)
                })
                .ToListAsync();

            return Ok(periods);
        }

        // POST: api/periods
        [HttpPost]
        public async Task<ActionResult> CreatePeriod(CreatePeriodDto dto)
        {
            var period = new Period
            {
                Date = dto.Date,
                Label = dto.Label
            };

            _context.Periods.Add(period);
            await _context.SaveChangesAsync(); // Guarda para gerar o Id do Período

            // Associa as quantidades a cada produto neste novo período
            foreach (var item in dto.Balances)
            {
                var balance = new StockBalance
                {
                    PeriodId = period.Id,
                    ProductId = item.Key,
                    Quantity = item.Value
                };
                _context.StockBalances.Add(balance);
            }

            await _context.SaveChangesAsync();

            return Ok(new { Message = "Período criado com sucesso!", PeriodId = period.Id });
        }
    }
}