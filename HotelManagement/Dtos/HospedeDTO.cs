namespace HotelManagement.DTOs;
using  HotelManagement.Models;
using System.ComponentModel.DataAnnotations;

    public class HospedeDTO
    {
        [Required(ErrorMessage ="O nome do hospede é obrigatório")]
        private string Nome { get; set; }
        [Required (ErrorMessage ="O sobrenome do hospede é obrigatório")]
        private string Sobrenome { get; set; }
        [Required (ErrorMessage ="O email do hospede é obrigatório")]
        private string Email { get; set; }
        [Required (ErrorMessage ="O telefone do hospede é obrigatório")]
        private string NumeroTelefone { get; set; }
        private string Pais { get; set; }
        [Required (ErrorMessage ="A data de nascimento do hospede é obrigatório")]
        private DateTime DataDeNascimento { get; set; }
        
    }