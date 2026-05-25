using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2
{
    internal class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("電気エンジンで走ります");
        }
    }
}
