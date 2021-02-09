using System;

namespace Model
{
  public class Elevador
  {
    private int AndarAtual { get; set; }
    private int TotalAndares { get; set; }
    private int Capacidade { get; set; }
    private int PessoasPresentes { get; set; }

    public void Inicializa(int totalAndares, int capacidade)
    {
      AndarAtual = 0;
      PessoasPresentes = 0;
      TotalAndares = totalAndares;
      Capacidade = capacidade;
    }

    public void Entra()
    {
      if (PessoasPresentes < Capacidade)
      {
        PessoasPresentes++;
        Console.WriteLine($"Entrou uma pessoa no elevador, total de pessoas no elevador: {PessoasPresentes}");
      }
      else Console.WriteLine("Capacidade excedida");
    }
    public void Sai()
    {
      if (PessoasPresentes > 0)
      {
        PessoasPresentes--;
        Console.WriteLine($"Saiu uma pessoa do elevador, total de pessoas no elevador: {PessoasPresentes}");
      }
      else Console.WriteLine("Não há pessoas no elevador");
    }
    public void Sobe()
    {
      if (AndarAtual < TotalAndares)
      {
        AndarAtual++;
        Console.WriteLine($"O elevador subiu um andar, andar atual: {AndarAtual}");
      }
      else Console.WriteLine("O elevador já está no topo");
    }

    public void Desce()
    {
      if (AndarAtual > 0)
      {
        AndarAtual--;
        Console.WriteLine($"O elevador desceu um andar, andar atual: {AndarAtual}");
      }
      else Console.WriteLine("O elevador já está no térreo");
    }

    public void MostrarInformacoes()
    {
      Console.WriteLine($"Capacidade: {Capacidade} | Total de andares : {TotalAndares}");
      Console.WriteLine($"Total de pessoas: {PessoasPresentes} | Andar atual : {AndarAtual}");
      Console.WriteLine("---------------------------------");
    }
  }
}