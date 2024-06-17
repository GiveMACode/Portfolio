namespace HotelManagement.Models;

public class Reserva
    {
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int NumeroQuarto { get; set; }
        public string NomeHospede { get; set; }
        public int NumeroHospedes { get; set; }
        public string EmailHospede { get; set; }
        public string TelefoneHospede { get; set; }
        public string StatusReserva { get; set; }

        public Reserva(DateTime dataCheckIn, DateTime dataCheckOut, int numeroQuarto, string nomeHospede, int numeroHospedes, string emailHospede, string telefoneHospede, string statusReserva)
        {
            DataCheckIn = dataCheckIn;
            DataCheckOut = dataCheckOut;
            NumeroQuarto = numeroQuarto;
            NomeHospede = nomeHospede;
            NumeroHospedes = numeroHospedes;
            EmailHospede = emailHospede;
            TelefoneHospede = telefoneHospede;
            StatusReserva = statusReserva;
        }
    }

