using Microsoft.EntityFrameworkCore;
using HotelManagement.Models;

namespace HotelManagement.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

    //Classes que vão virar tabelas no banco de dados
    public DbSet<Hospede> Hospedes { get; set; }
    public DbSet<Quarto> Quartos { get; set; }
    public DbSet<Reserva> Reservas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}