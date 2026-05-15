using System;
using System.Collections.Generic;
using System.Text;
using Projeto_IMC.Models;

namespace Projeto_IMC.Service
{
    public class ColetarDadosService
    {
        public Usuario SolicitarDadosUsuario()
        {
            Console.WriteLine("=== CALCULADORA IMC ===");

            Console.WriteLine("\nDigite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nPeso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAltura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Usuario usuario = new Usuario();
            usuario.Name = nome;
            usuario.Altura = altura;
            usuario.Peso = peso;

            return usuario;
        }
    }
}
