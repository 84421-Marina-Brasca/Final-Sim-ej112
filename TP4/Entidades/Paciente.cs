using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    internal class Paciente
    {
        public double TiempoLlegada;
        public Estado Estado;
        public Tipo Tipo;

        public Paciente(double tiempo, Estado estado, Tipo tipo)
        {
            TiempoLlegada = tiempo;
            Estado = estado;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"Tiempo de llegada: {TiempoLlegada}, Estado: {Estado}, Tipo: {Tipo}";
        }
    }

    public enum Estado
    {
        Esperando,
        SiendoAtendido,
        Suspendido
    }

    public enum Tipo
    {
        Consulta,
        Urgencia
    }
}
