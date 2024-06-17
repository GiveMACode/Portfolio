namespace HotelManagement.Models;

public class Hospede
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Email { get; set; }
        private string NumeroDocumento { get; set; }

        public Hospede(string nome, string endereco, string telefone, DateTime dataNascimento, string email, string numeroDocumento)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Email = email;
            NumeroDocumento = numeroDocumento;
        }
    }