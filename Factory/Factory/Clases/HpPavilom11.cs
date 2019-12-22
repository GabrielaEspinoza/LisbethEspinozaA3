using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfacez;

namespace Factory
{
    public class HpPavilom11 : ISuperLapto
    {
        public HpPavilom11()
        {

        }
        public string GetDetalles()
        {
            return "Detalles: Hp Paviliom 11\nRAM: 12GB\nDisco Duro SSD: 1000GB\nTarjeta Grafica: GTX1080\n";
        }
    }
}
