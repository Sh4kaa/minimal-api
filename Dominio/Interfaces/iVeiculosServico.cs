using minimal_api.Dominio.Entidades;
namespace minimal_api.Dominio.Interfaces;

public interface IveiculoServico
{
  List<Veiculo>? Todos(int pagina = 1, string? nome = null, string? marca = null);
  void Incluir(Veiculo veiculo);
  void Atualizar(Veiculo veiculo);
  void ApagarPorId(Veiculo veiculo);
  Veiculo? BuscarPorId(int id);
}