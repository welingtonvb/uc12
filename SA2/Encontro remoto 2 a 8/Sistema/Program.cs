// Console.Beep();
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Alguma coisa sem caracter especial");

// Console.WriteLine("************************");
// Console.WriteLine("*                      *");
// Console.WriteLine("*         MENU         *");
// Console.WriteLine("*                      *");
// Console.WriteLine("************************");

// Console.ReadLine();

namespace Sistema {
  public class Program {
    static void Main (string[] args) {

      Endereco end = new Endereco();
      end.logradouro = "Rua X";
      end.numero = 1;
      end.complemento = "Beco sem saída";
      end.enderecoComercial = false;
   
      PessoaFisica pf = new PessoaFisica();
      pf.endereco = end;
      pf.nome = "Fulano de Tal";
      pf.CPF = "123456789-00";
      pf.dataNascimento =  new DateTime(1899,1,1);

      // interpolação
      Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro} Número {pf.endereco.numero}");

      // concatenação
      Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + " Número " + pf.endereco.numero);

      //forma não-inteligente
      Console.WriteLine(pf.nome);
      Console.WriteLine(pf.endereco.logradouro);
      Console.WriteLine(pf.endereco.numero);
      Console.WriteLine(pf.endereco.complemento);
      Console.WriteLine(pf.endereco.enderecoComercial);

      // chamada de método
      bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento); 

      if (idadeValida) {
        Console.WriteLine("Cadastro aprovado!");
      } else {
        Console.WriteLine("Cadastro reprovado!");
      }

    }

  } 
   
}