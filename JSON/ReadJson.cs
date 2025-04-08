using AvanceretProgrammeringEksamen.Models;
using System.Text.Json;

namespace AvanceretProgrammeringEksamen.JSON
{
    public class ReadJson
    {
        public static List<Sale> ReadSales()
        {

            try
            {
                using StreamReader reader = new("fileSales.json");
                var json = reader.ReadToEnd();
                List<Sale> sales = JsonSerializer.Deserialize<List<Sale>>(json);
                return sales;
            }
            catch (Exception e)
            {

                return new List<Sale>();
            }

        }
    }
}
