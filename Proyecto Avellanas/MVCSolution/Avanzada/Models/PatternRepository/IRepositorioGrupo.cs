using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
	public interface IRepositorioGrupo
	{
		List<Grupo> ObtenerGrupo();
		bool CrearGrupo(Grupo Grupo);
		bool EditarGrupo(Grupo Grupo);
		bool EliminarGrupo(int id);
		Grupo BuscarGrupo(int id);
		bool ExisteGrupo(int id);
	}

}
