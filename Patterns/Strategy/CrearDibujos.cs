using System;
using System.Collections;
using System.Collections.Generic;

namespace Refactoring
{
	public class CrearDibujos
	{
		public IDictionary<TipoDibujo,EstrategiaDibujo> _EstrategiasDeDibujo;
		public IDictionary<TipoDeBorrado,EstrategiaBorrado> _EstrategiasDeBorrado;
		public IDictionary<TiposDeCopiado,IEstrategiaCopiado> _EstrategiasDeCopiado;

		public CrearDibujos ()
		{
			_EstrategiasDeDibujo = new Dictionary<TipoDibujo, EstrategiaDibujo>
			{
				{TipoDibujo.TipoA,new EstrategiaDibujarTipoA()},
				{TipoDibujo.TipoB, new EstrategiaDibujarTipoB()},
				{TipoDibujo.TipoC, new EstrategiaDibujarTipoC()}
			};

			_EstrategiasDeBorrado = new Dictionary<TipoDeBorrado, EstrategiaBorrado>
			{
				{TipoDeBorrado.Limpio,new EstrategiaBorradoLimpio()},
				{TipoDeBorrado.PorCapas, new EstrategiaBorradoPorCapas()},
				{TipoDeBorrado.Rapido , new EstrategiaBorradoRapido()}
			};

			_EstrategiasDeCopiado = new Dictionary<TiposDeCopiado, IEstrategiaCopiado>
			{
				{TiposDeCopiado.Horizontal,new EstrategiaCopiadoHorizontal()},
				{TiposDeCopiado.Vertical, new EstrategiaCopiadoVertical()},
				{TiposDeCopiado.Plano, new EstrategiaCopiadoPlano()}
			};


		}

		public string Dibujar(TipoDibujo tipoDeDibujar)
		{
			return _EstrategiasDeDibujo[tipoDeDibujar].Dibujar();
		}

		public string Borrar(TipoDeBorrado tipoDeborrar)
		{
			return _EstrategiasDeBorrado[tipoDeborrar].Borrado();
		}

		public string Copiar(TiposDeCopiado tipoDeCopiado)
		{
			return _EstrategiasDeCopiado[tipoDeCopiado].copia();
		}
	}
}

