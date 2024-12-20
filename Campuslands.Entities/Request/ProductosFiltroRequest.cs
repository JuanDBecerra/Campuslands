namespace Campuslands.Entities.Request
{
    public class ProductosFiltroRequest
    {
        public decimal PrecioMinimo { get; set; }
        public decimal PrecioMaximo { get; set; }
        public int StockMinimo { get; set; }
    }
}
