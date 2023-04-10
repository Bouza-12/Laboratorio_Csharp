namespace Billetes
{
    public class Dolar
    {
        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        private double _cantidad;

        public double CotzRespectoDolar { get => _cotzRespectoDolar; set => _cotzRespectoDolar = value; }
        private double _cotzRespectoDolar;

        private Dolar()
        {

        }

        public Dolar(double cantindad)
        {
            Cantidad = cantindad;
        }

        public static explicit operator Euro(Dolar d)
        {
            return (Euro)(d.Cantidad * 1.17);
        }

        public static explicit operator Peso(Dolar d)
        {
            return (Peso)(d.Cantidad * 102.65);
        }

        public static implicit operator Dolar(double d)
        {

            return (Dolar)d;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar e, Peso p)
        {
            return e == (Dolar)p;
        }

        public static bool operator !=(Dolar e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.Cantidad == d2.Cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar d2 = (Dolar)e;
            return d.Cantidad + d2.Cantidad;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar d2 = (Dolar)e;
            return d.Cantidad - d2.Cantidad;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar d2 = (Dolar)p;
            return d.Cantidad + d2.Cantidad;
        }

        public static Dolar operator -(Dolar d, Euro p)
        {
            Dolar d2 = (Dolar)p;
            return d.Cantidad - d2.Cantidad;
        }

        
    }

    public class Euro  //  1 Euro = 1.17 Dolar 
    {
        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        private double _cantidad;

        public double CotzRespectoDolar { get => _cotzRespectoDolar; set => _cotzRespectoDolar = value; }
        private double _cotzRespectoDolar;

        private Euro()
        {

        }

        public Euro(double cantindad)
        {
            Cantidad = cantindad;
            CotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad, double cotzRespectoDolar)
        {
            Cantidad = cantidad;
            CotzRespectoDolar = cotzRespectoDolar;
        }

        public static explicit operator Euro(double d)
        {
            return (Euro)(d);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.Cantidad*e.CotzRespectoDolar);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1 == e2;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (Dolar)e == (Dolar)p;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            Dolar e1 = (Dolar)e;
            return e1.Cantidad == d.Cantidad;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static Dolar operator +(Euro e, Dolar d)
        {
            Dolar d2 = (Dolar)e;
            return d.Cantidad + d2.Cantidad;
        }

        public static Dolar operator -(Euro e, Dolar d)
        {
            Dolar d2 = (Dolar)e;
            return d2.Cantidad - d.Cantidad;
        }

        public static Dolar operator +(Euro e, Peso p)
        {
            Dolar d1 = (Dolar)e;
            Dolar d2 = (Dolar)p;
            return d1.Cantidad + d2.Cantidad;
        }

        public static Dolar operator -(Euro e, Peso p)
        {
            Dolar d1 = (Dolar)e;
            Dolar d2 = (Dolar)p;
            return d1.Cantidad - d2.Cantidad;
        }


    }

    public class Peso // 1 Dolar = 102.65 Pesos
    {
        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        private double _cantidad;

        public double CotzRespectoDolar { get => _cotzRespectoDolar; set => _cotzRespectoDolar = value; }
        private double _cotzRespectoDolar;

        private Peso()
        {

        }

        public Peso(double cantindad)
        {
            Cantidad = cantindad;
            CotzRespectoDolar = 1.17;
        }

        public Peso(double cantidad, double cotzRespectoDolar)
        {
            Cantidad = cantidad;
            CotzRespectoDolar = cotzRespectoDolar;
        }

        public static implicit operator Peso(double d)
        {
            return (Peso)d;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.Cantidad * p.CotzRespectoDolar);
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1 == p2;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (Dolar)p == (Dolar)e;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            Dolar p1 = (Dolar)p;
            return p1.Cantidad == d.Cantidad;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static Dolar operator +(Peso p, Dolar d)
        {
            Dolar p2 = (Dolar)p;
            return p2.Cantidad + d.Cantidad;
        }

        public static Dolar operator -(Peso p, Dolar d)
        {
            Dolar p2 = (Dolar)p;
            return p2.Cantidad - d.Cantidad;
        }

        public static Dolar operator +(Peso p, Euro e)
        {
            Dolar d1 = (Dolar)p;
            Dolar d2 = (Dolar)e;
            return d1.Cantidad + d2.Cantidad;
        }

        public static Dolar operator -(Peso p, Euro e)
        {
            Dolar d1 = (Dolar)p;
            Dolar d2 = (Dolar)e;
            return d1.Cantidad - d2.Cantidad;
        }
    }
}