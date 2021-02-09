using System;
using Model;

namespace Exercicio_01
{
  class Program
  {
    static void Main(string[] args)
    {
      var pessoa_01 = new Pessoa();
      pessoa_01.Nome = "Rafael";
      pessoa_01.Data_nascimento = new DateTime(2001, 3, 6);
      pessoa_01.Altura = 1.86f;

      var pessoa_02 = new Pessoa();
      pessoa_02.Nome = "Mesquita";
      pessoa_02.Data_nascimento = new DateTime(2001, 3, 6);
      pessoa_02.Altura = 1.86f;

      var pessoa_03 = new Pessoa();
      pessoa_03.Nome = "Brito";
      pessoa_03.Data_nascimento = new DateTime(2001, 3, 6);
      pessoa_03.Altura = 1.86f;


      var agenda = new Agenda();
      agenda.ArmazenaPessoa(pessoa_01);
      agenda.ArmazenaPessoa(pessoa_02);
      agenda.ArmazenaPessoa(pessoa_03);

      //agenda.ImprimeAgenda();
      agenda.RemovePessoa("Mesquita");
      //Console.Clear();
      agenda.ImprimeAgenda();
      //Console.Clear();
      //agenda.ImprimePessoa(agenda.BuscaPessoa("Mesquita"));
    }
  }
}
