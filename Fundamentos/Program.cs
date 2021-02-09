using System;

namespace Fudnamentos_de_OO
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamentoBoleto = new PagamentoBoleto();
      pagamentoBoleto.Vencimento = DateTime.Now;
      pagamentoBoleto.NumeroBoleto = "1234";


      var pagamento = new Pagamento();
      Console.WriteLine("Hello World!");
    }
  }

  class Pagamento
  {
    // Propriedades
    public DateTime Vencimento;

    // Métodos 
    public virtual void Pagar()
    {
    }

    public override string ToString()
    {
      return Vencimento.ToString("dd/mm/yy");
    }
  }

  class PagamentoBoleto : Pagamento
  {
    public string NumeroBoleto;
    public override void Pagar()
    {
      // Regra do boleto
    }
  }

  class PagamentoCartaoCredito : Pagamento
  {
      public string Numero;

    public override void Pagar()
    {
      // Regra do Cartão de Crédito
    }
  }
}
