using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

public class Program
{
    
    public static Nokia nokia = new Nokia();
    public static Iphone iphone = new Iphone();
    
    public static void Main()
    {
        Program program = new Program();
        program.Initializer();
    }

    public void Initializer()
    {
        iphone.Ligar();
        iphone.ReceberLigacao();
        
        nokia.Ligar();
        nokia.ReceberLigacao();
        
        iphone.InstalarAplicativo("Candy Crush");
        nokia.InstalarAplicativo("Love Ritmo");
        iphone.Numero = "1";
        nokia.Numero = "2";
    }
}
