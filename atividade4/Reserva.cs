

namespace atividade4
{
    public class Reserva : Quarto
    {
        public int Dias;
        public string NomeReserva;
        public Reserva(int DiasConstrutor, string NomeReservaConstrutor)
        {
            Dias = DiasConstrutor;
            NomeReserva = NomeReservaConstrutor;
        }
        public Reserva()
        {}
        
        public virtual double CalcularTotal()
        {
            return Dias * PrecoDiaria;
        }

        public void ResumoReserva()
        {
            Console.WriteLine($"Hospede: {NomeReserva}");
            Console.WriteLine($"Quarto: {Numero}");
            Console.WriteLine($"Total da reserva : {CalcularTotal()}");
        }
    }
}