using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfacez;

namespace Factory.Clases
{
    public class HpIdealPad : ILaptoNormal
    {
        public HpIdealPad()
            {
            }

        public string GetDetalles()
        {
            return "Detalles: Hp IdeaPad\nRAM: 8GB\nDisco Duro: 1000GB\nTarjeta Grafica: AMD Radeon\n";
        }
    }
}
