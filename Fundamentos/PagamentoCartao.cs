using System;
using Fudnamentos_de_OO;

namespace Payments
{
  class PagamentoCartaoCredito : Pagamento
  {
    public string Numero;

    public override void Pagar(string numero)
    {
      base.Pagar(numero);
      Console.WriteLine("Pagar cartão");
    }
  }
}