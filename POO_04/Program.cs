// INVENTO ARGENTINO

using ClassLibrary1;

namespace POO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(ConsoleColor.Blue.ToString(), 100);
            Boligrafo boligrafo2 = new Boligrafo(ConsoleColor.Red.ToString(), 50);

            Console.WriteLine(boligrafo1.GetColor); 
            Console.WriteLine(boligrafo2.GetColor);

            Console.WriteLine("Boligrafo 1 - gasto");
            Console.WriteLine(boligrafo1.GetTinta); 
            Console.WriteLine(boligrafo1.Pintar(10));
            Console.WriteLine(boligrafo1.GetTinta);

            Console.WriteLine("Boligrafo 2 - recarga");
            Console.WriteLine(boligrafo2.GetTinta);
            boligrafo2.RecargarTinta();
            Console.WriteLine(boligrafo2.GetTinta);


        }
    }
}
