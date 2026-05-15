namespace ProjetoIMC;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("=== CALCULADORA IMC ===");

		Console.WriteLine("\nDigite seu nome: ");
		string nome = Console.ReadLine();

		Console.WriteLine("\nPeso: ");
		double peso = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("\nAltura: ");
		double altura = Convert.ToDouble(Console.ReadLine());

		if (altura > 5)
		{
			altura = altura / 100;
		}
		
		double imc = peso / (altura * altura);
		Console.WriteLine("\nSeu IMC é: " + imc.ToString("F2"));


		if (imc < 18.5)
		{
			Console.WriteLine(nome + ", você está abaixo do peso.");
		}
		if (imc >= 18.5 && imc < 24.9)
		{
			Console.WriteLine(nome + ", seu peso esá normal.");
		}
		if (imc >= 25 && imc < 29.9)
		{
			Console.WriteLine(nome + ", você está com sobrepeso.");
		}
		if (imc >= 30 && imc < 34.9)
		{
			Console.WriteLine(nome + ", você está com Obesidade Grau I.");
		}
		if (imc >= 35 && imc < 39.9) 
		{
			Console.WriteLine(nome + ", você está com Obesidade Grau I.");
		}
		if (imc >= 40)
		{
			Console.WriteLine(nome + ", você está com Obesidade Morbida.");
		}

		// MEDIR QUANTIDADE DE AGUA PARA BEBER

		double agua = (peso * 35) / 1000;
		Console.WriteLine("\nE para ajudar sua hidratação, você deve beber " + agua + " litros de água diariamente.");



	}
}
