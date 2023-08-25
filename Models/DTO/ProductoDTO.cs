namespace DON_KILO_BE.Models.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public int? IdCategoria { get; set; }
        public string? DescripcionCategoria { get; set; }
        public int? Stock { get; set; }
        public string? Precio { get; set; }
    }
}
