using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double diametro = ConseguirInformacion.ConseguirDiametro();
            double altura = ConseguirInformacion.ConseguirAltura();
            Cilindro volumenObjeto = new Cilindro("Rojo");
            double volumen = volumenObjeto.CalculoVolumen(altura, diametro);

            Console.WriteLine("El volumen es: " + volumen);
        }
    }
}
