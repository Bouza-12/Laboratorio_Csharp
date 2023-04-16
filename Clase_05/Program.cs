namespace Clase_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase 05 | Listas");

            //listas genericas y no genericas copiar del gdb del profe


            Console.WriteLine("<=========================================>");
            Console.WriteLine("Diccionarios");

            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();

            maquinaExpendedora.Add(1, "Bolsa de Papas fritas");
            maquinaExpendedora.Add(2, "Gaseosa Coca Cola");
            maquinaExpendedora.Add(3, "Doritos");
            maquinaExpendedora.Add(4, "Alfajor Bon o Bon");
            maquinaExpendedora.Add(5, "Gaseosa Sprite");
            maquinaExpendedora.Add(6, "Palitos Salados");

            //maquinaExpendedora.Add(1, "Otra bolsa");  no se pueden repetir valores de Key

            foreach(var item in maquinaExpendedora)
            {
                Console.WriteLine($"ID: {item.Key} | Valor: {item.Value}");
            }

            Console.WriteLine(maquinaExpendedora.ContainsKey(1));  //retorna un bool

            string ingreso = "";
            while (ingreso != "S")
            {
                foreach (var item in maquinaExpendedora) ;
            }

        }
    }
}