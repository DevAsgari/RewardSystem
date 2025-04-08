using AvanceretProgrammeringEksamen.Models;
using System.Text.Json;

namespace AvanceretProgrammeringEksamen.JSON
{

    public class WriteJson
    {
        public static void AppendSaleToJsonFile(Sale sale)
        {
            string filePath = "fileSales.json";

            List<Sale> existingSales = new List<Sale>();
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                existingSales = JsonSerializer.Deserialize<List<Sale>>(existingJson);

            }

            existingSales.Add(sale);
            string jsonString = JsonSerializer.Serialize(existingSales);
            File.WriteAllText(filePath, jsonString);
        }
    }
}