namespace Model
{
  public class Televisao
  {
    protected int Volume { get; set; }
    protected string Canal { get; set; }
  }

  public class ControleRemoto : Televisao
  {

    public void AumentarVolume() => this.Volume++;
    public void DiminuirVolume() => this.Volume--;

    public void TrocarCanal(string canal) => this.Canal = canal;

    public void ConsultarInformacoes()
    {
      System.Console.WriteLine($"Canal atual: {this.Canal}");
      System.Console.WriteLine($"Volume atual: {this.Volume}");
    }
  }
}