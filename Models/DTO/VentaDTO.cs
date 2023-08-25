namespace DON_KILO_BE.Models.DTO
{
    public class VentaDTO
    {
        public int IdVenta { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? TipoPago { get; set; }
        public string? FechaRegistro { get; set; }
        public string? TotalTexto { get; set; }
        public virtual ICollection<DetalleVentaDTO>? DetalleVenta { get; set; }
    }
}
