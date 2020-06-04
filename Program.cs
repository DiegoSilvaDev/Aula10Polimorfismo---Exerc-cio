using System;

namespace Polimorfismo___exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio();
            Console.WriteLine("Digite a data");
            relatorio.data = DateTime.Parse(Console.ReadLine()); 
            relatorio.MostrarRelatorio();
            Console.WriteLine();
            Mensal mensal = new Mensal();
            Console.WriteLine("Digite a data");
            mensal.data = DateTime.Parse(Console.ReadLine());
            mensal.MostrarRelatorio();
            Console.WriteLine();
            Anual ano = new Anual();
            Console.WriteLine("Digite a data");
            ano.data = DateTime.Parse(Console.ReadLine());
            ano.MostrarRelatorio();


        }
    }
}
