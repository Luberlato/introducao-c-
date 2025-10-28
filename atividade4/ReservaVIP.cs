namespace atividade4
{
    public class ReservaVIP : Reserva
    {
        private double desconto;
        public ReservaVIP(double DescontoConstrutor)
        {
            Desconto = DescontoConstrutor;
        }

        public double Desconto
        {
            get { return desconto; }
            set
            {
                if (value > 1 || value < 0)
                {
                    Console.WriteLine("Desconto inválido! Deve estar entre 0 e 1.");
                }
                else
                {
                    desconto = value;
                }
            }
        }

        public override double CalcularTotal()
        {
            return base.CalcularTotal() * (1 - Desconto);
        }
    }
}