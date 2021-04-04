using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TransportApp
{
    public abstract class Cargaison
    {
        protected int distance;
        protected List<Marchandise> marchandises = new List<Marchandise>();
        public List<Marchandise> GetMarchandises()
        {
            return marchandises;
        }
        public Cargaison(int distance)
        {
            this.distance = distance;
        }
        public void add(Marchandise m)
        {
            marchandises.Add(m);
        }
        public void afficher()
        {
            foreach (Marchandise m in marchandises)
            {
                Console.WriteLine(m.ToString());
            }
        }
        public Marchandise GetMarchandise(int numero)
        {
            foreach (Marchandise m in marchandises)
            {
                if (m.Numero == numero)
                    return m;
            }
            return null;
        }
        public double GetPoidsTotal()
        {
            double p = 0;
            foreach (Marchandise m in marchandises)
            {
                p += m.Poids;
            }
            return p;
        }

        public double GetVolumeTotal()
        {
            double p = 0;
            foreach (Marchandise m in marchandises)
            {
                p += m.Volume;
            }
            return p;
        }

        public abstract double cout();
    }

    }
