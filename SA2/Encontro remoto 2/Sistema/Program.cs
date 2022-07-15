namespace Sistema {
  public class program {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello!");

      Pessoa fulano = new Pessoa();
      fulano.nome = "Fulano";

      Console.WriteLine(fulano.nome);
    }
  }
}
