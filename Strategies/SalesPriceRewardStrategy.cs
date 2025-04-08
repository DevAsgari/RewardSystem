using AvanceretProgrammeringEksamen.Models;

namespace AvanceretProgrammeringEksamen.Strategies
{
    public class SalesPriceRewardStrategy : IRewardStrategy
    {
        public decimal CalculateReward(Sale sale)
        {
            return sale.Price * 0.05m;
        }
    }
}
