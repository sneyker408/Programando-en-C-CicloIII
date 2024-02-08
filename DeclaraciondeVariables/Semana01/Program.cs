namespace Semana01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 21;
            
            
            float preciococa2 = 2.50f;
            char letra = 'a';
            bool esActivo = false;

            string mensaje = "Hola mundo";
            int[] numeros = { 1, 2, 3, 4, 5, 6 };
            string[] nombres = { "Juan", "Jose", "Juana", "Mario", "Selena" };

            Console.WriteLine($"Mi edad es: {edad}");
            //Console.WriteLine("Mi edad es: " + Convert.ToString(edad + 2) + " " + 48.50 + " " + edad.ToString());


            //utilizando la inferencia de datos ocupando la barra var 

            //INFERENCIA DE DATOS
            var numero = 6;
            var mensaje2 = "Hola desde C#";
            var esverdadero = false;

            Console.WriteLine(numero);

            //numero ) "hola desde C#";

            // Ambito de las variales 

            Console.WriteLine(esActivo);

            void miprimerafunsion() {
                bool estaactivo = true;
                esActivo = true;
                Console.WriteLine(esActivo);
            }

            miprimerafunsion();

        }
    }
}