using System;

namespace _NET_CORE_CRUD_IRPF
{
  public class Irpf
  {
    // [JsonProperty("id")]
    public int Id { get; set; }

    // [JsonProperty("nome")]
    public string Nome { get; set; }

    // [JsonProperty("cpfCnpj")]
    public string CpfCnpj { get; set; }

    // [JsonProperty("email")]
    public string Email { get; set; }

    // [JsonProperty("dt_nascimento")]
    public DateTime DtNascimento { get; set; }

    // [JsonProperty("tituloEleitoral")]
    public string TituloEleitoral { get; set; }

    // [JsonProperty("rendimentosTributaveis")]
    public double RendimentosTributaveis { get; set; }

    // [JsonProperty("endereco")]
    public string Endereco { get; set; }

    // [JsonProperty("cidade")]
    public string Cidade { get; set; }

    // [JsonProperty("bairro")]
    public string Bairro { get; set; }

    // [JsonProperty("cep")]
    public string Cep { get; set; }
  }
}