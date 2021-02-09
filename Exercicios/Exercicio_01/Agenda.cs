using System;
using System.Collections.Generic;

namespace Model
{
  public class Agenda
  {
    public List<Pessoa> Pessoas { get; set; }

    public Agenda() => Pessoas = new List<Pessoa>();

    public void ArmazenaPessoa(Pessoa pessoa)
    {
      Pessoas.Add(pessoa);
    }

    public void RemovePessoa(string nome) => Pessoas.RemoveAll(x => x.Nome == nome);

    public int BuscaPessoa(string nome) => Pessoas.FindIndex(x => x.Nome.Equals(nome));

    public void ImprimeAgenda()
    {
      foreach (var pessoa in Pessoas)
        pessoa.Imprimir_dados();
    }

    public void ImprimePessoa(int index)
    {
      try
      {
        Pessoas[index].Imprimir_dados();
      }
      catch (System.ArgumentOutOfRangeException)
      {
        Console.WriteLine("Pessoa não encontrada");
      }
    }
  }
}