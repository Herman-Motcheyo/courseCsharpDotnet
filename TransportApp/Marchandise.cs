using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Marchandise
    {
        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private double poids;
        public double Poids
        {
            get { return poids; }
            set { poids = value; }
        }

        private double volume;
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Marchandise(int numero, double poids, double volume)
        {
            this.numero = numero;
            this.poids = poids;
            this.volume = volume;
        }
        public override string ToString()
        {
            return "Num=" + numero + " Poids=" + poids + " vol=" + volume;
        }
    }
}
