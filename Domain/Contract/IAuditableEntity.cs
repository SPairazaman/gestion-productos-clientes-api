﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface IAuditableEntity
    {
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
    }
}
