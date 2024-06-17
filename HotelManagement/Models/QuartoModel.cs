namespace HotelManagement.Models;


    public class Quarto
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
        public bool Ocupado { get; set; }
        public string Descricao { get; set; }
        public int Capacidade { get; set; }
        public List<string> Facilidades { get; set; }

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