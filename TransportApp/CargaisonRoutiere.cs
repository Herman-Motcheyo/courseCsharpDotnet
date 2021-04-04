using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class CargaisonRoutiere : Cargaison
    {
        public CargaisonRoutiere(int d) : base(d) { }
        public override double cout()
        {
            if (GetVolumeTotal() < 380000)
                return 4 * distance * GetVolumeTotal();
            else
                return 6 * distance * GetPoidsTotal();
        }
        public override string ToString()
        {
            return "Cargaison Routière Distance =" + distance;
        }
    }
}
