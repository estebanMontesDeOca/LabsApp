using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsApp.Dominio
{
    class Laboratorio
    {
        private string nombre;
        private int numero;
        private int cantEquipos;
        private int cantSillas;

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

        public int CantEquipos
        {
            get
            {
                return cantEquipos;
            }
            set
            {
                int unaCantEquipos = value;
                cantEquipos = unaCantEquipos;
            }

        }

        public int CantSillas
        {
            get
            {
                return cantSillas;
            }
            set
            {
                int unaCantSillas = value;
                cantSillas = unaCantSillas;
            }
        }

        public Laboratorio()
        {
            nombre = "unNombre";
            numero = 000;
            cantEquipos = 0;
            cantSillas = 0;
        }

        public Laboratorio(string unNombre, int unNumero, int unaCantEquipos, int unaCantSillas)
        {
            nombre = unNombre;
            numero = unNumero;
            cantEquipos = unaCantEquipos;
            cantSillas = unaCantSillas;
        }

        public override string ToString()
        {
            return nombre+"\n"+numero;
        }
    }
}
