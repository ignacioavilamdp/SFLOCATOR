using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLOCATOR
{
    public class LoopResults
    {
        //Properties
        public double DistancePu { get; set; }
        public double FaultResistance { get; set; }

        //Constructor
        public LoopResults(double distancePu, double faultResistance)
        {
            DistancePu = distancePu;
            FaultResistance = faultResistance;
        }
    }
}
