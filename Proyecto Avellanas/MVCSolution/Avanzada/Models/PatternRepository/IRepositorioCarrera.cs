using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
     public interface IRepositorioCarrera
    {
        List<Carreras> ObtenerCarrera();
        bool CrearCarrera(Carreras carrera);
        bool EditarCarrera(Carreras carrera);
        bool EliminarCarrera(int id);
        Carreras BuscarCarrera(int id );
		bool ExisteCarrera(int id);



	}
}
