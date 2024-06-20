namespace HotelManagement.Models;

public class Quarto
    {
        public int QuartoId { get; set; }
        public string TipoQuarto { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoPorNoite { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; } = false;
    }