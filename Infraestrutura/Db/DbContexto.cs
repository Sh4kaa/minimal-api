using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;

namespace minimal_api.Infraestrutura.Db;
public class DbContexto : DbContext
{
  private readonly IConfiguration _configAppSettings;
  public DbContexto(IConfiguration configAppSettings)
  {
    _configAppSettings = configAppSettings;
  }
  public DbSet<Administrador> Administradores { get; set; } = default!;
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    var stringConexao = _configAppSettings.GetConnectionString("sqlserver");
    if (!string.IsNullOrEmpty(stringConexao))
    {
      optionsBuilder.UseSqlServer(stringConexao);
    }
  }
}