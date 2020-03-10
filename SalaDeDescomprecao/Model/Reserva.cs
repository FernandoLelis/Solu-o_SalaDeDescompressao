using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaDeDescomprecao.Model
{
    class Reserva
    {
        private static string cpf;
        private static DateTime dataReserva;
        private static DateTime horaEntrada;
        private static DateTime horaSaida;
        private static string statusReserva;

        public static string Cpf { get => cpf; set => cpf = value; }
        public static DateTime DataReserva { get => dataReserva; set => dataReserva = value; }
        public static DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public static DateTime HoraSaida { get => horaSaida; set => horaSaida = value; }
        public static string StatusReserva { get => statusReserva; set => statusReserva = value; }
    }
}
