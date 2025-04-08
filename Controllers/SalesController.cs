using AvanceretProgrammeringEksamen.JSON;
using AvanceretProgrammeringEksamen.Models;
using AvanceretProgrammeringEksamen.Strategies;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace AvanceretProgrammeringEksamen.Controllers
{
    public class SalesController : Controller
    {

        public IActionResult RegisterSale()
        {
            return View();
        }

        public IActionResult Register(Sale sale)
        {
            if (ModelState.IsValid)
            {
                WriteJson.AppendSaleToJsonFile(sale);
                TempData["SuccessMessage"] = "Sale registered successfully!";
            }
            return View("RegisterSale");
        }

        public IActionResult Reward(string strategyType)
        {
            IRewardStrategy strategy;

            switch (strategyType)
            {
                case "CustomerSatisfaction":
                    strategy = new CustomerSatisfactionRewardStrategy();
                    break;

                case "SalesPrice":
                    strategy = new SalesPriceRewardStrategy();
                    break;

                case "Combined":
                    strategy = new CombinedRewardStrategy();
                    break;

                case "Adjusted":
                    strategy = new AdapterRewardStrategy();
                    break;

                default:
                    TempData["ErrorMessage"] = "Please select a strategy.";
                    return RedirectToAction("RegisterSale");
            }

            List<Sale> sales = ReadJson.ReadSales();
            List<RewardModel> rewards = sales.Select(sale => new RewardModel
            {
                Sale = sale,
                Reward = strategy.CalculateReward(sale)
            }).ToList();

            return View(new RewardViewModel { Rewards = rewards, SelectedStrategy = strategyType });
        }
    }
}
