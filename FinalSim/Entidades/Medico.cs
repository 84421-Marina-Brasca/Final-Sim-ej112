using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim.Entidades
{
    internal class Medico
    {
        private EstadoM Estado;
        private int TamCola;

        public Medico(EstadoM estado, int tamCola) 
        {
            Estado = estado;
            TamCola = tamCola;
        }

        //public void SetEstado(Estado estado) => Estado = estado;

        public void SumarACola() => TamCola++;

        public void RestarACola() => TamCola--;

        //public string GetNombreEstado() => Estado.GetNombre();

        public int getTamCola()
        {
            return TamCola;
        }

        public bool EstaLibre()
        {
            return (this.Estado == EstadoM.Libre); //ver si está bien cambiar el get por esto
        }
    }
    public enum EstadoM
    {
        Libre,
        Ocupado
    }
}
