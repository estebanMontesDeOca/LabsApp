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

        public void agregarReserva(Reserva unaReserva) {
            this.listaReservas.Add(unaReserva); 
        }

        public void agregarPersona(Persona unaPersona) {
            this.listaPersonas.Add(unaPersona);
        }

        public void agregarLaboratorio(Laboratorio unLaboratorio) {
            this.listaLaboratorio.Add(unLaboratorio);   
        }

        public void eliminarLaboratorio(Laboratorio unLaboratorio) {
            this.listaLaboratorio.Remove(unLaboratorio);
        }

        public void eliminarPersona(Persona unaPersona) {
            this.listaPersonas.Remove(unaPersona);
        }

        public void eliminarReserva(Reserva unaReserva) {
            this.listaReservas.Remove(unaReserva);   
        }

        public Persona obtenerPersona(string unNumero) {
            Persona retorno = new Persona();
            foreach (Persona s in listaPersonas) {
                if (s.Numero.Equals(unNumero)) {
                    retorno = s;
                }
            }
            return retorno;
        }

        public Laboratorio obtenerLaboratorio(int unNumero)
        {
            Laboratorio retorno = new Laboratorio();
            foreach (Laboratorio s in listaLaboratorio)
            {
                if (s.Numero.Equals(unNumero))
                {
                    retorno = s;
                }
            }
            return retorno;
        }

        public Reserva obtenerReserva()
        {
            return new Reserva();
        }
    }

}
