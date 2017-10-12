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

        public override bool Equals(object value)
        {
            Laboratorio labAux = value as Laboratorio;

            return numero == labAux.Numero;
        }

        public override string ToString()
        {
            return nombre+"\n"+numero;
        }

        public override int GetHashCode()
        {
            var hashCode = 1560022278;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + numero.GetHashCode();
            hashCode = hashCode * -1521134295 + cantEquipos.GetHashCode();
            hashCode = hashCode * -1521134295 + cantSillas.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + Numero.GetHashCode();
            hashCode = hashCode * -1521134295 + CantEquipos.GetHashCode();
            hashCode = hashCode * -1521134295 + CantSillas.GetHashCode();
            return hashCode;
        }
    }
}
