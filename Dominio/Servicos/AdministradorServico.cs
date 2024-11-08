

using System.Data.Common;
using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Interfaces;
using minimal_api.Infraestrutura.Db;

public class AdministradorServico : IAdministradorServico
{
  private readonly DbContexto _contexto;
  public AdministradorServico(DbContexto contexto)
  {
    _contexto = contexto;
  }
  public Administrador? Login(LoginDTO loginDTO)
  {
    var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
    return adm;

  }
}