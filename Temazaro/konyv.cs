using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temazaro
{
    internal class konyv
    {
        int id;
        string szerzo;
        string cim;
        string fajta;


        public int Id { get => id; set => id = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Fajta { get => fajta; set => fajta = value; }


        public konyv(int id, string szerzo, string cim, string fajta)
        {
            Id = id;
            Szerzo = szerzo;
            Cim = cim;
            Fajta = fajta;
        }

        public override string ToString()
        {
            return "Szerző:" + szerzo +      "Cím:" + cim +       "Fajta:" + fajta;
        }
    }
}
