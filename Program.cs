using System;

namespace Aula18Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
             Jogador messi = new Jogador();
            messi.Nome = "Messi";
            messi.Posicao = "Atacante";
            messi.Nascimento = DateTime.Parse("24/06/1987");            

            messi.MostrarDados();
            Console.WriteLine( messi.CalcularIdade() );
            Console.WriteLine( messi.CalcularAposentadoria() );
        }
    }
}
