﻿using MigracionGym.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionGym.Web.Data.Entities
{
    public class Horarios:IEntity
    {
        public int Id { get; set; }
        private string Horario { get; set; }
        private string dia { get; set; }
    }
}