using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionGym.Web.Data.Entities
{
    public class ActividadesSociosTurnos : Ientity
    {
        private int idRelacion;
        private Socios socio;
        private Relaciones relacion;
        private int Pases;
        private int paseLibre;
    }
}
