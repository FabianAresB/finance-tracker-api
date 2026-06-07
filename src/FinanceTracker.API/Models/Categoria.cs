namespace FinanceTracker.API.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; } = null!;
    public ICollection<Transaccion> Transacciones { get; set; } = new List<Transaccion>();
}
    
