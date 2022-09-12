using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaJuridica : Pessoa
    {
        // Atributos
        public string CNPJ { get; set; }
        
        public string razaoSocial { get; set; }

        public string caminho {get; private set; } = "Database/PessoaJuridica.csv";
               
        // Métodos
        public override float PagarImposto(float rendimento) {
        float imposto = 0;

        if (rendimento <= 5000) {
          imposto = rendimento * 6 /100;
        } else if (rendimento > 5001 && rendimento <= 10000) {
          imposto = rendimento * 8 /100;
        } else if (rendimento > 10000) {
          imposto = rendimento * 10 / 100;
        }

        return imposto;
        
      }

        public bool ValidarCNPJ(string cnpj){
            if(cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length - 4)) == "0001") {
                return true;
            } else {
                return false;
            }
        }

        public void Inserir(PessoaJuridica pj) {
          VerificarPastaArquivo(caminho);

          string[] pjString = {$"{pj.nome}, {pj.CNPJ}, {pj.razaoSocial}"};

          File.AppendAllLines(caminho,pjString);
        }

        public List<PessoaJuridica> Ler() {

          List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

          string[] linhas = File.ReadAllLines(caminho);

          foreach (string cadaLinha in linhas) {
            string[] atributos = cadaLinha.Split(",");

            PessoaJuridica cadaPj = new PessoaJuridica();

            cadaPj.nome = atributos[0];
            cadaPj.CNPJ = atributos[1];
            cadaPj.razaoSocial = atributos[2];

            listaPj.Add(cadaPj);
          }

          return listaPj;

        }

    }
    
}