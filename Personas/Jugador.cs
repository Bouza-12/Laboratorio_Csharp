using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas 
{
    internal class Jugador : Persona
    {
        private int _partidosJugados;
        private int _totalGoles;

        public int PartidosJugados { get { return _partidosJugados; } set { _partidosJugados = value; } }
        public int TotalGoles { get {  return _totalGoles; } set { _totalGoles = value; } }

        public float PromedioDeGoles 
        { 
            get 
            {
                return (float)TotalGoles / (float)PartidosJugados;
            } 
        }

        public Jugador(int dni, string nombre) : base((long) dni, nombre) { }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : base((long)dni, nombre)
        {
            PartidosJugados = partidosJugados;
            TotalGoles = totalGoles;
        }

        public override string ToString()
        {
            return $"Jugador: {Nombre}, Partidos Jugados: {PartidosJugados}, Goles: {TotalGoles}, Promedio: {PromedioDeGoles}";
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if(jugador1.DNI == jugador2.DNI) { return true; }
            else{ return false; }   
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
