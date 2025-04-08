using AvanceretProgrammeringEksamen.Models;
using AvanceretProgrammeringEksamen.Strategies;

namespace AvanceretProgrammeringEksamen.Strategies
{
    public interface IRewardStrategy
    {
        decimal CalculateReward(Sale sale);
    }

}
