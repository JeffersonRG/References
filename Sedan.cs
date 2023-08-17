using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    internal class Sedan : Automobile
    {
        // gets the get from automobile and makes it private
        public double Speed  { get; private set; }

        public int Wheels  { get; private set; }

        public string LicensePlate  { get; private set; }
        
        // it makes the information public with a custom name and sets the infromation to the right name  
        public Sedan(double speed)
        {
            Speed = speed;
            Wheels = 4;
            LicensePlate = "GCTC-06";
        }

        //allows stringify to be called upon
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is treaveling at a speed of {Speed} on {Wheels} wheels, with a license Plate # of {LicensePlate}.");
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
