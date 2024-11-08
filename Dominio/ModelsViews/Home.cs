namespace minimal_api.Dominio.ModelsViews;


public struct Home
{
  public string Documentacao { get => "/swagger"; }
  public string Mensagem { get => "Bem vindo a minha API"; }
}