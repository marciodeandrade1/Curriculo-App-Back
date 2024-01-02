namespace Curriculo_App_Back.Models
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string? Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string UF  { get; set; }
        public string CEP { get; set; }
        public string? DataNascimento { get; set; }
    }
}
