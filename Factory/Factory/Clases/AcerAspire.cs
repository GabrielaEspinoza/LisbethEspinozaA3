using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfacez;

namespace Factory.Clases
{
    public class AcerAspire : ILaptoNormal
    {
        public AcerAspire()
        {

        }

        public string GetDetalles()
        {
            return "Detalles: Acer Aspire\nRAM: 8GB\nDisco Duro: 1000GB\nTarjeta Grafica: Intel Hd Graphics\n";
        }
    }
}
