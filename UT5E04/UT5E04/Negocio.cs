using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5E04
{
    public class Negocio
    {
        private int reservaId;
        private List<Reserva> reservas;

        public Negocio()
        {
            reservaId = 0;
            reservas = new List<Reserva>();
        }

        public Reserva[] ObtenerReservas()
        {
            return reservas.ToArray();
        }

        public Reserva ObtenerReserva(int reservaId)
        {
            return reservas.First(r => r.ReservaId == reservaId);
        }

        public void BorrarReserva(int reservaId)
        {
            Reserva eliminar = reservas.FirstOrDefault(r => r.ReservaId == reservaId);
            if (eliminar!= null)
            {
                reservas.Remove(eliminar);
            }
        } 

        public void CrearReserva(Reserva reserva)
        {
            reserva.ReservaId = SiguienteReservaId();
            reservas.Add(reserva);
        }

        private int SiguienteReservaId()
        {
            reservaId++;
            return reservaId;
        }
    }
}
