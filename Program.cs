using System;

class Program
{
        static void Main(string[] args)
    {
        //instanciar
        IMC i = new IMC();
        Console.WriteLine("Digite seu peso: ");
        i.peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua altura em metros: ");
        i.altura = double.Parse(Console.ReadLine());
        i.mensagem();

    }
}
    
