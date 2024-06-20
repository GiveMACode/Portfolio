namespace HotelManagement.Models;

public class Quarto
    {
        private int QuartoId { get; set; }
        private string TipoQuarto { get; set; }
        private string Descricao { get; set; }
        private decimal PrecoPorNoite { get; set; }
        private string Status { get; set; }
        private bool IsDeleted { get; set; } = false;
    }