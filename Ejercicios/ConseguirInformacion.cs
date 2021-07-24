using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public static class ConseguirInformacion
    {
        public static double ConseguirDiametro()
        {

            Console.WriteLine("Deme el diámetro de cilindro:");
            string diametroString = Console.ReadLine();
            double diametro = Double.Parse(diametroString);

            return diametro;
        }

        public static double ConseguirAltura()
        {
            Console.WriteLine("Deme la altura de cilindro:");
            string alturaString = Console.ReadLine();
            double altura = Double.Parse(alturaString);

            return altura;
        }
    }
}
