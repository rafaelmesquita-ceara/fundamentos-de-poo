namespace Model
{
  public class Televisao
  {
    internal int Volume { get; set; }
    internal string Canal { get; set; }
  }

  public class ControleRemoto
  {
    public Televisao Televisao { get; set; }
    public ControleRemoto(Televisao televisao) => Televisao = televisao;

    public void AumentarVolume() => Televisao.Volume++;
    public void DiminuirVolume() => Televisao.Volume--;

    public void TrocarCanal(string canal) => Televisao.Canal = canal;

    public void ConsultarInformacoes()
    {
      System.Console.WriteLine($"Canal atual: {Televisao.Canal}");
      System.Console.WriteLine($"Volume atual: {Televisao.Volume}");
    }
  }
}