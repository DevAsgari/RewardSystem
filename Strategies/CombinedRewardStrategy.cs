using AvanceretProgrammeringEksamen.Models;

namespace AvanceretProgrammeringEksamen.Strategies
{
    public class CombinedRewardStrategy : IRewardStrategy
    {
        public decimal CalculateReward(Sale sale)
        {
            return (sale.Price * 0.05m) + (sale.CustomerSatisfaction * 20m);
        }
    }
}
