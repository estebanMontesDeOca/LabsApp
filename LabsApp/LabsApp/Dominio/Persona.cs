using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsApp.Dominio
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fehcaNacimiento;
        private int numero;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                string unNombre = value;
                nombre = unNombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                string unApellido = value;
                apellido = unApellido;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fehcaNacimiento;
            }
            set
            {
                DateTime unaFecha = value;
                fehcaNacimiento = unaFecha;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                int unNumero = value;
                numero = unNumero;
            }
        }


        public Persona()
        {
            nombre = "unNombre";
            apellido = "unApellido";
            fehcaNacimiento = new DateTime() ;
            numero = 0;
        }

        public Persona(string unNombre, string unApellido, DateTime unaFecha, int unNumero)
        {
            nombre = unNombre;
            apellido = unApellido;
            fehcaNacimiento = unaFecha;
            numero = unNumero;
        }

        public override bool Equals(object value)
        {
            Persona per = value as Persona;

            return numero == per.Numero;
        }

        public override string ToString()
        {
            return nombre+" "+apellido + "\n" + numero;
        }


    }
}
