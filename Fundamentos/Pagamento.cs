using System;

namespace Payments
{
  public abstract class Pagamento : IPagamento
  {
    // Propriedades
    public DateTime Vencimento { get; set; }

    // Métodos 
    public virtual void Pagar(string numero) { }

  }

  public interface IPagamento
  {
    DateTime Vencimento { get; set; }

    void Pagar(string numero);
  }
}