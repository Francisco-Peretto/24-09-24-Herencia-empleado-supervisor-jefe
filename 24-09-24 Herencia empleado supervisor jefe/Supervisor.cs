﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_09_24_Herencia_empleado_supervisor_jefe
{
    internal class Supervisor : Empleado
    {
        public Supervisor(string nombre, string apellido, string fecNac, int edad) : base(nombre, apellido, fecNac, edad)
        {}

        public void MandarEmpleado()
        {

        }
    }
}
