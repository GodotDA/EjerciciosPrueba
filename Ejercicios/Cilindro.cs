using System;
using System.Collections.Generic; //No se está usando
using System.Text; 

namespace Ejercicios
{
    public  class Cilindro
    {
        public  string Color;

        public Cilindro(string color)
        {
            this.Color = color;
        }
        public  double CalculoVolumen(double altura, double diametro)
        {
            double radio = diametro / 2;
            double volumen = Math.PI * (Math.Pow(radio, 2)) * altura;
            //Devovemos el volumen
            return volumen;

        }
    }
}
