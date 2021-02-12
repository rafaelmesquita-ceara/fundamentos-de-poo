using System;
using Fudnamentos_de_OO;

namespace Payments
{
  class PagamentoBoleto : Pagamento, IDisposable
  {
    public string NumeroBoleto;

    public void Dispose()
    {
      throw new NotImplementedException();
    }

    public override void Pagar(string numero)
    {
      base.Pagar(numero);
      Console.WriteLine("Pagar boleto");
    }
  }
}