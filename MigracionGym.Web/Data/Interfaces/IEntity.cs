using System;
using MigracionGym.Web.Data.Entities;

namespace MigracionGym.Data
{
    public interface IEntity
    {
        byte EstadoRegistro { get; set; }
        DateTime? FechaBajaLocal { get; }
        DateTime FechaBajaRegistro { get; set; }
        DateTime? FechaCreacionLocal { get; }
        DateTime FechaCreacionRegistro { get; set; }
        DateTime? FechaModificacionLocal { get; }
        DateTime FechaModificacionRegistro { get; set; }
        int Id { get; set; }
        string ObservacionRegistro { get; set; }
        Usuarios Usuario { get; set; }
    }
} 