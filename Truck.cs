using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    internal class Truck : IAutomobile
    {
        // gets the get from automobile and makes it private
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double weight { get; }

        // it makes the information public with a custom name and sets the infromation to the right name
        public Truck(double speedParam, double weightParam, string licanseNum)
        {
            Speed = speedParam;
            weight = weightParam;
            LicensePlate = licanseNum;

            //if the weight is over a certain number it changes the wheel count
            if(weight < 400) 
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        //allows stringify to be called upon
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a Licanse plate # of {LicensePlate}!");
        }

        // when called upon increase/dencrease by 5
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DencreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
