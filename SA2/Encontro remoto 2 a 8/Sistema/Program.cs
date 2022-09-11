namespace Sistema {
  public class Program {
    static void Main (string[] args) {

      // Lista
      List<PessoaFisica> listaPf = new List<PessoaFisica>();

      // Método carregamento
      static void BarraCarregamento(string texto){
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(texto);  
        Thread.Sleep(500);
        for (var contador = 0; contador < 10; contador++) {
          Console.Write("#");
          Thread.Sleep(500);
        }
      }

      Console.WriteLine(@$"
          
          =======================================
          |                                     |
          |   Seja Bem Vindo ao nosso Sistema   |
          |        de cadastro de pessoas       |
          |          Fisica e Juridica          |
          |                                     |
          =======================================
      ");    

        BarraCarregamento("Iniciando ");
     
        string opcao;

        Console.Clear();
        do {
         Console.WriteLine(@$"
          =======================================           
          |       Escolha uma opção :           |
          |                                     |
          |          Pessoa fisica              |
          |          1 - Cadastrar              |
          |          2 - Listar                 |
          |          3 - Remover                |
          |                                     |
          |          Pessoa Juridica            |
          |          4 - Cadastrar              |
          |          5 - Listar                 |
          |          6 - Remover                |          
          |                                     |
          |         0 - sair                    |
          =======================================
          ");  
       
          opcao = Console.ReadLine();

          switch (opcao) {
            case "1":

              // Cadastrar PF
              Endereco endPf = new Endereco();
              Console.WriteLine("Digite seu logradouro:");
              endPf.logradouro = Console.ReadLine();
              Console.WriteLine("Digite o número de sua residência:");
              endPf.numero = int.Parse(Console.ReadLine());
              Console.WriteLine(@$"Digite o complemento caso possua. Precione ENTER para pular:");
              endPf.complemento = Console.ReadLine();
              Console.WriteLine("Este endereço é comercial? (S - SIM / N - NÃO)");
              string endComercial = Console.ReadLine().ToUpper();

              if(endComercial == "S") {
                endPf.enderecoComercial = true;
              } else if (endComercial == "N") {
                endPf.enderecoComercial = false;
              }

              PessoaFisica pf = new PessoaFisica();
              pf.endereco = endPf;

              Console.WriteLine("Digite seu CPF (Somente números):");
              pf.CPF = Console.ReadLine();
              Console.WriteLine("Digite seu nome:");
              pf.nome = Console.ReadLine();
              Console.WriteLine("Digite seu salário:");
              pf.salario = float.Parse(Console.ReadLine());
              Console.WriteLine("Digite sua data de aniversário [ANO, MES, DIA]:");
              pf.dataNascimento = DateTime.Parse(Console.ReadLine());

              bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

              if(idadeValida == true) {
                Console.WriteLine("Cadastro aprovado!");
                listaPf.Add(pf);
                Console.WriteLine(pf.PagarImposto(pf.salario));
              } else {
                Console.WriteLine("Cadastro reprovado!");
              }

              Console.WriteLine($"Aperte 'ENTER' para continuar...");
              Console.ReadLine();
              
            break;
            case "2":
              // Listar PF
              foreach (var cadaItem in listaPf) {
                Console.WriteLine($"{cadaItem.nome}, {cadaItem.salario}");
              }

              Console.WriteLine($"Aperte 'ENTER' para continuar...");
              Console.ReadLine();

            break;
            case "3": 
              // Remover PF
              Console.WriteLine("Digite o CPF para ser removido (somente números): ");
              String cpfProcurado = Console.ReadLine();
              PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.CPF == cpfProcurado);

              if (pessoaEncontrada != null ) {
                listaPf.Remove(pessoaEncontrada);
                Console.WriteLine("Removido com sucesso!");
              } else {
                Console.WriteLine("CPF não encontrado!");
              }

              Console.WriteLine($"Aperte 'ENTER' para continuar...");
              Console.ReadLine();

            break;
            case "4": 
              // Cadastrar PJ
            break;
            case "5": 
              // Listar PJ
            break;
            case "6": 
              // Remover PJ            
            break;
            case "0":
              Console.WriteLine("Obrigado por utilizar nosso sistema");
              BarraCarregamento("Finalizando "); 
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