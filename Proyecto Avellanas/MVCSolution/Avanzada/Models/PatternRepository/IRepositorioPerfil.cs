using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    public interface IRepositorioPerfil
    {
        Perfil ObtenerPerfil();
        bool EditarPerfil(int telefono, string correo);

    }
}
