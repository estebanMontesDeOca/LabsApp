using LabsApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsApp.Persistencia
{
    class BaseDeDatos
    {
        private List<Reserva> listaReservas = new List<Reserva>();
        private List<Persona> listaPersonas = new List<Persona>();
        private List<Laboratorio> listaLaboratorio = new List<Laboratorio>();

        public List<Reserva> getListaReservas() {
            return listaReservas;
        }

        public List<Persona> getListaPersonas() {
            return listaPersonas;
        }

        public List<Laboratorio> getListaLaboratorio() {
            return listaLaboratorio;
        }

    }
}
