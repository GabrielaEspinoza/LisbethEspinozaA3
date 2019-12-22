using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfacez;

namespace Factory.Clases
{
    public class AcerSpin7 : ISuperLapto
    {
        public AcerSpin7()
        {

        }

        public string GetDetalles()
        {
            return "Detalles: Acer Spin 7\nRAM: 16GB\nDisco Duro ssd: 500GB\nTarjeta Grafica: GTX1060\n";
        }
    }
}
