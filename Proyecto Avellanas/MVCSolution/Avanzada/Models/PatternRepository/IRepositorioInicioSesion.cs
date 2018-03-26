using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    interface IRepositorioInicioSesion
    {
        bool Acceder(string Usuario, string contraseña);
    }
}
