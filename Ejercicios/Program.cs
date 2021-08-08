using System;

namespace Ejercicios
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Program.CalcularVolumenCilindro();
            //Program.CalcuarPrecioMinimoDeUnProducto();
            //Program.SaberSiUnNumeroEsPositivoONegativo(); 
        }

        // Ejercicio 1
        public static void CalcularVolumenCilindro()
        {
            double diametro = ConseguirInformacion.ConseguirDiametro();
            double altura = ConseguirInformacion.ConseguirAltura();
            Cilindro volumenObjeto = new Cilindro("Rojo");
            double volumen = volumenObjeto.CalculoVolumen(altura, diametro);

            Console.WriteLine("El volumen es: " + volumen);
        }

        // Ejercicio 2
        public static void CalcuarPrecioMinimoDeUnProducto()
        {
            Console.WriteLine("Dame el precio del primer producto");
            string producto1String = Console.ReadLine();
            double producto1 = Double.Parse(producto1String);
            Console.WriteLine("Dame el precio del segundo producto");
            string producto2String = Console.ReadLine();
            double producto2 = Double.Parse(producto2String);
            Console.WriteLine("Dame el precio del tercer producto");
            string producto3String = Console.ReadLine();
            double producto3 = Double.Parse(producto3String);
            if (producto1 <= producto2 && producto1 <= producto3)
            {
                Console.WriteLine("El producto 1 es más barto");
            }
            else if (producto2 <= producto1 && producto2 <= producto3)
            {
                Console.WriteLine("El prodcuto 2 es más barato");
            }
            else Console.WriteLine("El producto 3 es más barato");
        }
        // Ejercicio 3
        public static void SaberSiUnNumeroEsPositivoONegativo()
        {
            Console.WriteLine("Introduce un Número");
            string numeroString = Console.ReadLine();
            double numero = Double.Parse(numeroString);
            if (numero < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else if (numero > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Es igual a 0");
            }
        }
    }
}
