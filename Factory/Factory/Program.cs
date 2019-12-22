using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Clases;
using Factory.Interfacez;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ILaptos AcerLapto = new Acer();
            Cliente AcerCliente = new Cliente(AcerLapto);

            Console.WriteLine("Acer");
            Console.WriteLine(AcerCliente.GetSmartTvDealles());
            Console.WriteLine(AcerCliente.GetTvNormal());

            ILaptos LaptoHp = new Hp();
            Cliente HpCliente = new Cliente(LaptoHp);

            Console.WriteLine("Hp");
            Console.WriteLine(HpCliente.GetSmartTvDealles());

            Console.WriteLine(HpCliente.GetTvNormal());

            Console.ReadKey();
        }
    }
}
