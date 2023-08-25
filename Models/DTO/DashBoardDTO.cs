namespace DON_KILO_BE.Models.DTO
{
    public class DashBoardDTO
    {
        public int TotalVentas { get; set; }
        public string? TotalIngresos { get; set; }
        public int TotalProductos { get; set; }

        public List<VentasSemanaDTO>? VentasUltimaSemana { get; set; }
    }
}
