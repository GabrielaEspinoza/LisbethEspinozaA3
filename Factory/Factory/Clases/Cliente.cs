using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfacez;

namespace Factory.Clases
{
    class Cliente
    {
        ISuperLapto SmartTv;
        ILaptoNormal TvNormal;

        public Cliente(ILaptos factory)
        {
            SmartTv = factory.GetSuperLapto();
            TvNormal = factory.GetLaptoNormal();
        }
        public string GetSmartTvDealles()
        {
            return SmartTv.GetDetalles();
        }

        public string GetTvNormal()
        {
            return TvNormal.GetDetalles();
        }
        }
    }
