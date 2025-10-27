

namespace atividade4
{
    public class Quarto
    {
       
    
    public int Numero{get; set;}
    public string Tipo{get; set;}
    public double PrecoDiaria{get; set;}
    public bool Disponivel{get;set;}

    public Quarto(int NumeroConstrutor, string TipoConstrutor, double PrecoDiariaConstrutor, bool DisponivelConstrutor)
    {
        

namespace atividade4
{
    public class Quarto
    {
       
    
    public int Numero{get; set;}
    public string Tipo{get; set;}
    public double PrecoDiaria{get; set;}
    public bool Disponivel{get;set;}

    public Quarto(int NumeroConstrutor, string TipoConstrutor, double PrecoDiariaConstrutor, bool DisponivelConstrutor)
    {
        NumeroConstrutor = Numero;
        TipoConstrutor = Tipo;
        PrecoDiariaConstrutor = PrecoDiaria;
        DisponivelConstrutor = Disponivel;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Numero do Quarto: {numero}");
        Console.WriteLine($"Tipo do Quarto: {Tipo}");
        Console.WriteLine($"Preço da Diaria: {PrecoDiaria}");
        if (Disponivel){
            Console.WriteLine($"O quarto {numero} esta disponivel");
        }
        else{
            Console.WriteLine("Esse quarto esta ocupado");
        }
    }
    public bool Ocupar(){
        if (Disponivel){
            Disponivel = false;
        }
        else{
            Console.WriteLine("O quarto ja esta ocupado")
        }
        return Disponivel;
    }
    public bool Liberar(){
        if(!Disponivel){
            Disponivel = true;
        }
        else{
            Console.WriteLine("O quarto nao esta ocupado")
        }
        return Disponivel;
    }


    
    
    
    
    
    }
}
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Numero do Quarto: {numero}");
        Console.WriteLine($"Tipo do Quarto: {Tipo}");
        Console.WriteLine($"Preço da Diaria: {PrecoDiaria}");
        if (Disponivel){
            Console.WriteLine($"O quarto {numero} esta disponivel");
        }
        else{
            Console.WriteLine("Esse quarto esta ocupado");
        }
    }
    public bool Ocupar(){
        if (Disponivel){
            Disponivel = false;
        }
        else{
            Console.WriteLine("O quarto ja esta ocupado")
        }
        return Disponivel;
    }
    public bool Liberar(){
        if(!Disponivel){
            Disponivel = true;
        }
        else{
            Console.WriteLine("O quarto nao esta ocupado");
        }
        return Disponivel;
    }


    
    
    
    
    
    }
}