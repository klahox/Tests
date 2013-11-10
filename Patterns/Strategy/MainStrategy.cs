using System;

namespace Refactoring
{
	public class MainStrategy
	{
		public static void NotMain (string[] args)
		{

			CrearDibujos dibujos = new CrearDibujos();

			Console.WriteLine(dibujos.Dibujar(TipoDibujo.TipoA));
			Console.WriteLine(dibujos.Dibujar(TipoDibujo.TipoB));
			Console.WriteLine(dibujos.Dibujar(TipoDibujo.TipoC));

			Console.WriteLine(dibujos.Borrar(TipoDeBorrado.Rapido));
			Console.WriteLine(dibujos.Borrar(TipoDeBorrado.PorCapas));
			Console.WriteLine(dibujos.Borrar(TipoDeBorrado.Limpio));


			Console.WriteLine(dibujos.Copiar(TiposDeCopiado.Horizontal));
			Console.WriteLine(dibujos.Copiar(TiposDeCopiado.Vertical));
			Console.WriteLine(dibujos.Copiar(TiposDeCopiado.Plano));
			Console.Read();

		}
	}
}

