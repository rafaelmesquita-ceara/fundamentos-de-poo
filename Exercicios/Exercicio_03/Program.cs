using System;
using Model;

namespace Exercicio_03
{
  class Program
  {

    static void Main(string[] args)
    {
      Elevador elevador = new Elevador();
      elevador.Inicializa(3, 5);
      while (true) Menu(elevador);
    }

    static void Menu(Elevador elevador)
    {
      Console.Clear();
      elevador.MostrarInformacoes();
      Console.WriteLine("1 - Acrescentar pessoa no elevador");
      Console.WriteLine("2 - Remover pessoa do elevador");
      Console.WriteLine("3 - Subir um andar");
      Console.WriteLine("4 - Descer um andar");
      Console.WriteLine("5 - Sair");
      Console.WriteLine("-------------------");
      Console.Write("Comando: ");
      int comando = Convert.ToInt32(Console.ReadLine());
      switch (comando)
      {
          case 1 : elevador.Entra(); break;
          case 2 : elevador.Sai(); break;
          case 3 : elevador.Sobe(); break;
          case 4 : elevador.Desce(); break;
          case 5 : Environment.Exit(0); break;
          default: Console.WriteLine("Comando inválido"); break;
      }
      Console.ReadLine();
    }
  }
}
