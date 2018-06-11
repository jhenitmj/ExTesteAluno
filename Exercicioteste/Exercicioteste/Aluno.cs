using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicioteste
{
   public class Aluno
    {
        public int cod;
       public DateTime data;
       public string nomep;
        public string sobrenome;
        public string NomeCompleto;
        public int obj;



        public int idade()
        { // este método deverá calcular a idade do aluno baseado na sua data de nascimento


            DateTime dataAtual = DateTime.Now;

            //Subtai para saber quantos anos se passaram após nascimento
            int idade = DateTime.Now.Year - data.Year;

            return idade;
        }
        public string nomeCompleto()
        {// Deverá retornar o nome concatenado com o sobrenome
            
            NomeCompleto = nomep.Trim() + "" + sobrenome;
            return NomeCompleto;

        }

        public int validaNome(bool CaractereE)
        {//Deverá validar o nome do Aluno com caracteres divergentes
            if (CaractereE = Regex.IsMatch(NomeCompleto, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]")))
            {
                obj = 1;
            }
            else if (nomep.StartsWith("Ç") || sobrenome.StartsWith("Ç"))
            {
                obj = 2;
            }

            return obj;
                                                    
        }

        public string erroValidacao()
        {
            if(obj==1)
            {
                Console.WriteLine("Este nome não pode ser usado contém caracter 'Ç' que é inválido no inicio do nome ");
            }
            else if(obj ==2)
                {
                Console.WriteLine("Este nome não pode ser usado contém caracter 'Ç' que é inválido no inicio do nome ");
            }
            return erroValidacao();
        }
    }
}
