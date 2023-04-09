namespace Sumador
{
    public class Sumador
    {
        public int CantidadSumas { get => _cantidadSumas; set => _cantidadSumas = value; }
        private int _cantidadSumas;

        public Sumador(int inicio)
        {
            CantidadSumas = inicio;
        }

        public Sumador()
        {
            CantidadSumas = 0;
        }

        public long Sumar(long a, long b)
        {
            CantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            CantidadSumas++;
            return a + b;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.CantidadSumas + s2.CantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.CantidadSumas == s2.CantidadSumas;
        }

        public static explicit operator int(Sumador s)
        {
            return s.CantidadSumas;
        }
        
    }
}