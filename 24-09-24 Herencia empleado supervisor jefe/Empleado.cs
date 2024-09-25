using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_09_24_Herencia_empleado_supervisor_jefe
{
    internal class Empleado
    {
        private string _Nombre;
        private string _Apellido;
        private string _FecNac;
        private int _Edad;

        public Empleado(string nombre, string apellido, string fecNac, int edad)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FecNac = fecNac;
            this.Edad = edad;
        }


        public string Nombre { get { return this._Nombre; } set { this._Nombre = value; } }

        public string Apellido { get { return this._Apellido; } set { this._Apellido = value; } }

        public string FecNac { get { return this._FecNac; } set { this._FecNac = value; } }

        public int Edad { get { return this._Edad; } set { this._Edad = value; } }


        public virtual void MostrarDatos()
        {
            Console.Write($"Nombre: {this.Nombre} - Apellido: {this.Apellido} - Fecha de nacimiento: {this.FecNac} - Edad: {this.Edad} ");
        }
    }
}
