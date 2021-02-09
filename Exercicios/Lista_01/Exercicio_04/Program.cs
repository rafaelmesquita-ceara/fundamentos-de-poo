using System;
using Model;

namespace Exercicio_04
{
  class Program
  {
    static void Main(string[] args)
    {
      ControleRemoto controle = new ControleRemoto();
      while (true) Menu(controle);
    }

    static void Menu(ControleRemoto controle)
    {
      Console.Clear();
      Console.WriteLine("1 - Aumentar volume da televisão");
      Console.WriteLine("2 - Diminuir volume da televisão");
      Console.WriteLine("3 - Trocar canal da televisão");
      Console.WriteLine("4 - Consultar valor do volume de som e canal selecionado");
      Console.WriteLine("5 - Sair");
      Console.WriteLine("-------------------");
      Console.Write("Comando: ");
      int comando = Convert.ToInt32(Console.ReadLine());
      switch (comando)
      {
        case 1: controle.AumentarVolume(); break;
        case 2: controle.DiminuirVolume(); break;
        case 3: 
            Console.Write("Digite o canal: ");
            string canal = Console.ReadLine();
            controle.TrocarCanal(canal); 
            break;
        case 4: controle.ConsultarInformacoes(); break;
        case 5: Environment.Exit(0); break;
        default: Console.WriteLine("Comando inválido"); break;
      }
      Console.ReadLine();
    }
  }
}
