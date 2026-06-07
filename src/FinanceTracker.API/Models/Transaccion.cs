namespace FinanceTracker.API.Models;

public class Transaccion
{
    public int Id { get; set; }
    public decimal Monto { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public DateTime Fecha { get; set; } = DateTime.UtcNow;
    public TipoTransaccion Tipo { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; } = null!;
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; } = null!;
}

public enum TipoTransaccion
{
    Ingreso,
    Egreso
}
