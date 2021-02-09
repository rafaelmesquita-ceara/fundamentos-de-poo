using System;
using System.Collections.Generic;

namespace Model
{
  public class Pessoa
  {
    private string _nome;
    public string Nome
    {
      get => _nome;
      set => _nome = value;
    }
    private DateTime _data_nascimento;
    public DateTime Data_nascimento
    {
      get => _data_nascimento;
      set => _data_nascimento = value;
    }
    private float _altura;
    public float Altura
    {
      get => _altura;
      set => _altura = value;
    }

    public void Imprimir_dados()
    {
      Console.WriteLine($"Nome: {Nome}\nData de nascimento: {Data_nascimento.ToString("dd/MM/yyyy")}\nIdade: {CalculaIdade()}\nAltura: {Altura}");
      Console.WriteLine("-------------------------------");
    }

    public int CalculaIdade() => DateTime.Today.Year - Data_nascimento.Year;
  }

}