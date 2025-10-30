namespace atividade5
{
    public class Transporte
    {
        public uint velocidadeMedia{get; set;}
        public string modelo {get; set;}
        public Transporte(uint velocidadeMediaConstrutor, string modeloConstrutor)
        {
            velocidadeMedia = velocidadeMediaConstrutor;
            modelo = modeloConstrutor;
        }

        public virtual double calcularTempoViagem(double distancia)
        {
            return distancia / velocidadeMedia;
        }
        public virtual void iniciarViagem()
        {
            Console.WriteLine("Iniciando viagem");
        }
    }
}