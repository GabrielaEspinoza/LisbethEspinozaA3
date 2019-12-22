using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfacez;

namespace Factory.Clases
{
    class Hp : ILaptos
    {
        public Hp()
        {
        }

        public ILaptoNormal GetLaptoNormal()
        {
            return new HpIdealPad();
        }

        public ISuperLapto GetSuperLapto()
        {
            return new HpPavilom11();
        }
    }
}
