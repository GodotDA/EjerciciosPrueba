using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public class VolumenCilindro
    {
        public static void CalculoVolumen()
        {
            Console.WriteLine("Deme la altura de cilindro:");    
            string alturaString = Console.ReadLine();
            double altura = Double.Parse(alturaString);

            Console.WriteLine("Deme el diámetro de cilindro:");
            string diametroString = Console.ReadLine();
            double diametro = Double.Parse(diametroString);

            double radio = diametro / 2;
            double volumen = Math.PI*(Math.Pow(radio, 2)) * altura;

            Console.WriteLine("El volumen es: " + volumen);

        }
    }
}
