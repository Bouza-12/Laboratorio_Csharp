using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        public short CantidadDeJugadores
        {
            get
            {
                return _cantidadDeJugadores;
            }
            set
            {
                _cantidadDeJugadores = value;
            }
        }
        public List<Jugador> Jugadores
        {
            get
            {
                return _jugadores;
            }
            set
            {
                _jugadores = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
            }   
        }

        public Equipo() { }

        public Equipo(short cantidad,string nombre)
        {
            CantidadDeJugadores = cantidad;
            Nombre = nombre;
        }

       // public static bool operator +(Equipo e, Jugador j)
       // {
            //return e.Jugadores.Add(j);
       //}
    }
}
