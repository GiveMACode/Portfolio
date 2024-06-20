using System;
using System.Data;

namespace HotelManagement.Models
{
    public class Hospede
    {
        private int HospedeId { get; set; }
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private string NumeroDocumento { get; set; }
        private string Endereco { get; set; } 
        private string Email { get; set; }
        private string NumeroTelefone { get; set; }
        private string Pais { get; set; }
        private DateTime DataDeNascimento { get; set; } 
        private bool IsDeleted { get; set; } = false;
    }
}