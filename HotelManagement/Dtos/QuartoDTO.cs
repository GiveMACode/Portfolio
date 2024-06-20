using System.ComponentModel.DataAnnotations;
namespace HotelManagement.DTOs;
using  HotelManagement.Models;

public class QuartoDTO
    {
        [Required (ErrorMessage ="O quarto deve ser informado")]
        private string TipoQuarto { get; set; }
        [Required (ErrorMessage ="A descricao deve ser informada")]
        private string Descricao { get; set; }
        [Range(1,1000, ErrorMessage = "Valor entre 1 e 1000"), Required (ErrorMessage ="O preco deve ser informado")]
        private decimal PrecoPorNoite { get; set; }
        [Required (ErrorMessage ="O status deve ser informado")]
        private string Status { get; set; }
    }