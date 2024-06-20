﻿namespace HotelManagement.Models;

public class Reserva
    {
        private int ReservaId { get; set; }
        private int HospedeId { get; set; }
        private int QuartoId { get; set; }
        private DateTime DataCheckIn { get; set; }
        private DateTime DataCheckOut { get; set; }
        private string Status { get; set; }
        private bool IsDeleted { get; set; } = false;
    }
