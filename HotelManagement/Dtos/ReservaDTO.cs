namespace HotelManagement.DTOs;

using System.ComponentModel.DataAnnotations;
using  HotelManagement.Models;

public class ReservaDTO
    {

        private int ReservaId { get; set; }
        private int HospedeId { get; set; }
        private int QuartoId { get; set; }
        private DateTime DataCheckIn { get; set; }
        private DateTime DataCheckOut { get; set; }
        private string Status { get; set; }
        private bool IsDeleted { get; set; } = false;
    }
