using System.Runtime.CompilerServices;

namespace Temperaturas
{
    public class Celsius
    {
        private double _gradosCelcius;
        public double GradosCelicus { get =>  _gradosCelcius; set => _gradosCelcius = value; }

        public Celsius(double grados) { GradosCelicus = grados; }

        public static explicit operator double(Celsius celsius)
        {
            return celsius.GradosCelicus;
        }

        public static double ConvertirCelAFaren(Celsius celsius)
        {
            return (celsius.GradosCelicus * 9 / 5) + 32;
        }

        public static double ConvertirCelAKelv(Celsius celsius)
        {
            return ((double)celsius + 273.15);
        }

        public static explicit operator Celsius(Farenheit farenheit)
        {
            Celsius celsius = new Celsius(Farenheit.ConvertirFarenACel(farenheit));
            return celsius;
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            Celsius celsius = new Celsius(Kelvin.ConvertirKelvinACel(kelvin));
            return celsius;
        }

        public override string ToString()
        {
            return GradosCelicus.ToString();
        }


    }

    public class Farenheit
    {
        private double _gradosFarenheit;
        public double GradosFarenheit { get => _gradosFarenheit; set => _gradosFarenheit = value; }

        public Farenheit(double gradosFarenheit) { GradosFarenheit= gradosFarenheit; }

        public static explicit operator double(Farenheit farenheit)
        {
            return farenheit.GradosFarenheit;
        }

        public static double ConvertirFarenACel(Farenheit farenheit)
        {
            return ((farenheit.GradosFarenheit - 32) * 5 / 9);
        }

        public static double ConvertirFarenAKelv(Farenheit farenheit)
        {
            return (farenheit.GradosFarenheit + 459.67) * 5 / 9;
        }

        public static explicit operator Farenheit(Celsius celsius)
        {
            Farenheit farenheit = new Farenheit(Celsius.ConvertirCelAFaren(celsius));
            return farenheit;
        }

        public static explicit operator Farenheit(Kelvin kelvin)
        {
            Farenheit farenheit = new Farenheit(Kelvin.ConvertirKelvinAFaren(kelvin));
            return farenheit;
        }

        public override string ToString()
        {
            return GradosFarenheit.ToString();
        }
    }

    public class Kelvin
    {
        private double _gradosKelvin;
        public double GradosKelvin { get => _gradosKelvin; set => _gradosKelvin = value;}

        public Kelvin(double gradosKelvin) { GradosKelvin= gradosKelvin; }

        public static explicit operator double(Kelvin kelvin)
        {
            return kelvin.GradosKelvin;
        }

        public static double ConvertirKelvinACel(Kelvin kelvin)
        {
            return ((double)kelvin - 273.15);
        }

        public static double ConvertirKelvinAFaren(Kelvin kelvin)
        {
            return (kelvin.GradosKelvin * 9 / 5) - 459.67;        }

        public static explicit operator Kelvin(Celsius celsius)
        {
            Kelvin kelvin = new Kelvin(Celsius.ConvertirCelAKelv(celsius));
            return kelvin;
        }
        public static explicit operator Kelvin(Farenheit farenheit)
        {
            Kelvin kelvin = new Kelvin(Farenheit.ConvertirFarenAKelv(farenheit));
            return kelvin;
        }

        public override string ToString()
        {
            return GradosKelvin.ToString();
        }
    }
}