namespace HotelManagement.Models;


    public class Quarto
    {
        private int Numero { get; set; }
        private string Tipo { get; set; }
        private decimal Preco { get; set; }
        private bool Ocupado { get; set; }
        private string Descricao { get; set; }
        private int Capacidade { get; set; }
        private List<string> Facilidades { get; set; }

        public Quarto(int numero, string tipo, decimal preco, bool ocupado, string descricao, int capacidade, List<string> facilidades)
        {
            Numero = numero;
            Tipo = tipo;
            Preco = preco;
            Ocupado = ocupado;
            Descricao = descricao;
            Capacidade = capacidade;
            Facilidades = facilidades;
        }
    }