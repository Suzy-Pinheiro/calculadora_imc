using System;
using System.Collections.Generic;
using System.Text;
using Projeto_IMC.Models;

namespace Projeto_IMC.Service
{
    public class ImcService
    {
        public double Calcular(Usuario usuario)
        {
            //CONVERTER CM PARA ALTURA
            double altura = ConverterAltura(usuario.Altura);

            //RETORNAR O VALOR DO CALCULO DO IMC E ALTERAR O TIPO DE DADOS QUE PRECISO RETORNAR

            double imc = usuario.Peso / (altura * altura);


            return imc;
        }


        private double ConverterAltura(double altura)
        {
            if (altura > 5)
            {
                altura = altura / 100;
            }
            return altura;

        }

        //CRIAR FUNCAO IMC E PRINTAR RESULTADO
        public void MostrarResultadoImc(double imc, string nome)

        {
            if (imc < 18.5)
            {
                Console.WriteLine($"{nome}, você está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine(nome + ", seu peso esá normal.");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine(nome + ", você está com sobrepeso.");
            }
            else if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine(nome + ", você está com Obesidade Grau I.");
            }
            else if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine(nome + ", você está com Obesidade Grau II.");
            }
            else if (imc >= 40)
            {
                Console.WriteLine(nome + ", você está com Obesidade Morbida.");
            }
        }

        // MEDIR QUANTIDADE DE AGUA PARA BEBER

        // CRIAR FUNCAO QUE RECEBA O PESO DO USUARIO E DEVOLVA A QTD DE AGUA

        public double CalcularQuantidadeAgua(double peso)
        {
            double agua = (peso * 35) / 1000;
            return agua;
        }

    }
}
