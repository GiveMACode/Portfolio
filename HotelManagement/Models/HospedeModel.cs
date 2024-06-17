namespace HotelManagement.Models;

public class Hospede
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string NumeroDocumento { get; set; }

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