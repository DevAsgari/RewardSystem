using AvanceretProgrammeringEksamen.Models;

namespace AvanceretProgrammeringEksamen.Strategies
{
    public class CustomerSatisfactionRewardStrategy : IRewardStrategy
    {
        public decimal CalculateReward(Sale sale)
        {
            return sale.CustomerSatisfaction * 10m;
        }
    }
}
