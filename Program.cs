using System.Diagnostics;
using System.Text;
using Projeto_IMC.Service;

namespace ProjetoIMC; //organizar classes

public class Program // public: pode ser acessada de qualquer lugar
{
	public static void Main() //Main (método princial)
	{
		ColetarDadosService coletarDadosService = new ColetarDadosService();
		var usuario = coletarDadosService.SolicitarDadosUsuario();

		ImcService imcService = new ImcService();
		var imc = imcService.Calcular(usuario);
		imcService.MostrarResultadoImc(imc, usuario.Name);
        var pesoagua = imcService.CalcularQuantidadeAgua(usuario.Peso);

        Console.WriteLine($"\nE de acordo com os seus indicadores, você deve beber {pesoagua} litros de água diariamente.");

    }
}
