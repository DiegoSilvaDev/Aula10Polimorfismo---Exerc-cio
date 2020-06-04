using System;

namespace Polimorfismo___exercicio
{
    public class Relatorio
    {
        public DateTime data;

        public virtual void MostrarRelatorio(){
            Console.WriteLine("Mostrando todos os relátorios.");
        }
    }
}