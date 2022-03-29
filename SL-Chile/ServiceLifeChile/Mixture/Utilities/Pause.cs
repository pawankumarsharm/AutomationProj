using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceLife_Chile.mixture_acids_validation.Utilities
{
    class Pause
    {
        public static void WaitForSomeTime()
        {
            Thread.Sleep(3000);
        }
        public static void Waiting()
        {
            Thread.Sleep(1000);
        }
    }
}
