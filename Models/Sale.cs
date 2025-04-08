namespace AvanceretProgrammeringEksamen.Models
{
    public class Sale
    {
        public required string SaleType { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerSatisfaction { get; set; }
    }
}
