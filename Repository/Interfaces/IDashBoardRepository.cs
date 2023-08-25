namespace DON_KILO_BE.Repository.Interfaces
{
    public interface IDashBoardRepository
    {
        Task<int> TotalVentasUltimaSemana();
        Task<string> TotalIngresosUltimaSemana();
        Task<int> TotalProductos();
        Task<Dictionary<string, int>> VentasUltimaSemana();

    }
}
