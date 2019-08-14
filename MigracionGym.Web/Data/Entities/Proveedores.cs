using System;
using MigracionGym.Data;

namespace MigracionGym.Web.Data.Entities
{
    public class Proveedores : IEntity
    {
        public byte EstadoRegistro { get; set; }

        public DateTime? FechaBajaLocal => throw new NotImplementedException();

        public DateTime FechaBajaRegistro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? FechaCreacionLocal => throw new NotImplementedException();

        public DateTime FechaCreacionRegistro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? FechaModificacionLocal => throw new NotImplementedException();

        public DateTime FechaModificacionRegistro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ObservacionRegistro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Usuarios Usuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}