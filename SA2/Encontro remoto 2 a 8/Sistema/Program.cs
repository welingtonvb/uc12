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

      PessoaJuridica pj = new PessoaJuridica();

      Endereco endJ = new Endereco();
      endJ.logradouro = "Rua X";
      endJ.numero = 1;
      endJ.complemento = "Beco sem saída";
      endJ.enderecoComercial = false;

      pj.endereco = endJ;
      pj.CNPJ = "12345678900021";
      pj.razaoSocial = "Organizações Tabajara";
      
      bool cnpjValido = pj.ValidarCNPJ(pj.CNPJ);
      
      if (cnpjValido) {
        Console.WriteLine("CNPJ valido!");
      } else {
        Console.WriteLine("CNPJ invalido!");
      }

      // Boas vindas e menu de opções
      Console.ForegroundColor = ConsoleColor.Yellow;
      // Console.BackgroundColor = ConsoleColor.White;
 
      
        Console.Write("iniciando ");
        for (var contador = 0; contador < 10; contador++) {
          Console.Write("#");
          Thread.Sleep(500);
        }

        string opcao;

        Console.Clear();
        do {
          Console.WriteLine(@$"
          
          =======================================
          |                                     |
          |   Seja Bem Vindo ao nosso Sistema   |
          |        de cadastro de pessoas       |
          |          Fisica e Juridica          |
          |                                     |
          =======================================
          |       Escolha uma opção :           |
          |                                     |
          |         1 - Pessoa fisica           |
          |         2 - Pessoa Juridica         |
          |                                     |
          |         0 - sair                    |
          =======================================
          ");  
       
          opcao = Console.ReadLine();

          switch (opcao) {
            case "1":
            break;
            case "2":
            break;
            case "0":
            break; 
            default:
              Console.WriteLine("Opção invalida, digite outra valor!");
              Thread.Sleep(500);
            break;         
          }
        }  
        while(opcao !="0");  

        Console.ResetColor();
    }

  } 
   
}