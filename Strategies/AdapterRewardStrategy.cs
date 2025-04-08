using AvanceretProgrammeringEksamen.Models;
using TredjepartsProjekt;

namespace AvanceretProgrammeringEksamen.Strategies
{
    public class AdapterRewardStrategy : IRewardStrategy
    {
        public decimal CalculateReward(Sale sale)
        {
            StrategyFromAnotherCompany strategy = new StrategyFromAnotherCompany();

            decimal price = strategy.calculate((int)(decimal.Round(sale.Price)));

            return price;
        }
    }
}
