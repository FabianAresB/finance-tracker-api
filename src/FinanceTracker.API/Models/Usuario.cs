namespace FinanceTracker.API.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
    public ICollection<Transaccion> Transacciones { get; set; } = new List<Transaccion>();
    public ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
}