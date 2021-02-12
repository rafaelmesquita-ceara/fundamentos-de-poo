using System;
using System.Collections.Generic;
using System.Linq;

namespace Fudnamentos_de_OO
{
  class Program
  {
    static void Main(string[] args)
    {
      var payments = new List<Payment>();

      payments.Add(new Payment(1));
      payments.Add(new Payment(2));
      payments.Add(new Payment(3));
      payments.Add(new Payment(4));
      payments.Add(new Payment(5));

      foreach (var payment in payments)
      {
        Console.WriteLine(payment.Id);
      }

      var paidPayments = new List<Payment>();
      
      // Adiciona uma lista dentro de outra
      paidPayments.AddRange(payments);

      // Retorna uma lista
      var paymentList = payments.Where(x => x.Id == 3);

      // Retorna um Payment
      var paymentOne = payments.First(x => x.Id == 3);

      // Remove um item da lista
      payments.Remove(paymentOne);

      // Limpa toda a lista
      payments.Clear();
    }
  }

  public class Payment
  {
    public int Id { get; set; }
    public Payment(int id)
    {
      Id = id;
    }
  }

}
