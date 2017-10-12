using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsApp.Dominio
{
    class Reserva
    {
        private Laboratorio lab;

        public Laboratorio Lab
        {
            get
            {
                return lab;
            }
            set
            {
                Laboratorio unLab = value;
                lab = unLab ;
            }
        }
    }
}
