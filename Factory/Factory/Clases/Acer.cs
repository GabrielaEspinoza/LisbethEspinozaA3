using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfacez;

namespace Factory.Clases
{
    class Acer : ILaptos
    {
        public Acer()
        {

        }
        public ILaptoNormal GetLaptoNormal()
        {
            return new AcerAspire();
        }

        public ISuperLapto GetSuperLapto()
        {
            return new AcerSpin7();
        }
    }
}
