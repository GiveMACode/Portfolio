namespace HotelManagement.Models;

public class Reserva
    {
        private DateTime DataCheckIn { get; set; }
        private DateTime DataCheckOut { get; set; }
        private int NumeroQuarto { get; set; }
        private string NomeHospede { get; set; }
        private int NumeroHospedes { get; set; }
        private string EmailHospede { get; set; }
        private string TelefoneHospede { get; set; }
        private string StatusReserva { get; set; }

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

