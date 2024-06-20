using System;
using System.Data;

namespace HotelManagement.Models
{
    public class Hospede
    {
        public int HospedeId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NumeroDocumento { get; set; }
        public string Endereco { get; set; } 
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }
        public string Pais { get; set; }
        public DateTime DataDeNascimento { get; set; } 
        public bool IsDeleted { get; set; } = false;
    }
}