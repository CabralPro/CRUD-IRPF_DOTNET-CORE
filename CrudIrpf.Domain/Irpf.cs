using System;

namespace CrudIrpf.Domain
{
  public class Irpf
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CpfCnpj { get; set; }
    public string Email { get; set; }
    public DateTime DtNascimento { get; set; }
    public string TituloEleitoral { get; set; }
    public double RendimentosTributaveis { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Cep { get; set; }
  }
}