using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    internal interface IAutomobile
    {
        //it initalizes the get function for wheels, speed, and licenseplate
        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        // make a some thing that can be used in other classes
        public void Stringify();
    }
}
