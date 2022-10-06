# Sistema de Cadastro de Clientes - SCC v6.9

## UC12 - SA2 - Atividade Online 3

README para atividade online 3.

## Features (funcionalidades)

Codificar um sistema web server-side de cadastro de clientes (Back-End), utilizando a programação orientada a objetos. A Herança é um mecanismo que permite que características comuns a diversas classes sejam fatoradas em uma classe base, ou superclasse (Pai e filhas).

## Tecnologias utilizadas

* Linguagem de programação orientada a objetos C#;
* Microsoft .NET Framework 6.0. Um framework é um conjunto de códigos genéricos capaz de unir trechos de um projeto de desenvolvimento. 

## Organização do projeto

Está baseado na orientação a objetos da seguinte forma:

* Classe Pessoa (super classe / classe pai) :
	* Atributos : nome, endereço;
	* Métodos : pagar imposto;
* Classe Pessoa Física (Subclasse / Classe filha) :
	* Atributos : CPF e data de nascimento;
* Classe Pessoa Jurídica (Subclasse /  Classe filha) :
	* Atributos : CNPJ e razão social;

## Pré-requisitos de instalação

É necessário :

* Microsoft Visual Studio Code (VSCODE)

* Extensões do C#:

	* C# Snippets;
	* C#;
	* C# XML Documentation Comments;
	* C# Extensions.

* Microsoft .NET Framework 6.0.

## Execução da aplicação

* Baixar o pacote zip e descompactar;
* Caminho do arquivo na pasta: uc12-main\uc12-main\SA2\Encontro remoto 2 a 8\Sistema\ . Abrir o VSCODE nesta pasta;
* Executar por meio do comando "donet run" no console do vscode.

## Erros comuns

* Não instalar as extensões necessárias;
* Instalar o .NET diferente da versão 6.0 recomendada (inferior ou superior). Podem ocorrer erros de execução.  

## Contribuidores

Elaborado por welingtonvb