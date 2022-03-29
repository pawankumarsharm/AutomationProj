using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace select_service_us_canada.single_acid_validation.Utilities
{
    class Pause
    {
        public static void WaitingForSomeTime()
        {
            Thread.Sleep(2000);
        }
    }
}
