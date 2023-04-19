namespace TecNM.Ecommerce.Core.Entities;

public class Product : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float PrecioCompra { get; set; }
    public float PrecioVenta { get; set; }
    public float StockProducto { get; set; }
    public string Ubicacion{ get; set; }

}