using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class Pessoa // abstract?
    {
        // Atributos
        public string nome {get; set;}

        public Endereco endereco {get; set;}
             
        // Métodos
        public abstract float PagarImposto(float rendimento);

        public void VerificarPastaArquivo(string caminho) {
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);        
            }

            if(!File.Exists(caminho)) {
                using(File.Create(caminho)) {
                    
                }
            }
        }

    }

    /*

    Criar método de pagar imposto PF e PJ que calcule a porcentagem de desconto conforme o rendimento.
    PF:
    Até R$1.500,00 - isento - desconto 0
    Entre R$1.501,00 e R$5.000,00 - desconto de 3%
    Acima de 5.000,01 - desconto de 5%

    PJ:
    Até R$5.000,00 - isento - desconto de 6%
    Entre R$5.000,01 e R$10.000,00 - desconto de 8%
    Acima de 10.000,01 - desconto de 10%

    OBS: O método deve retornar o valor do desconto e não monstrar direto na tela.

    */
    
}