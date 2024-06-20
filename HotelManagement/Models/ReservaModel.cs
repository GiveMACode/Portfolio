namespace HotelManagement.Models;

public class Reserva
    {
        public int HospedeId { get; set; }
        public int ReservaId { get; set; }
        public int QuartoId { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
