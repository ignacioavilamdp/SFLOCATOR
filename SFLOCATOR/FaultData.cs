using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SFLOCATOR
{
    public class FaultData
    {
        public Complex L1Current { get; set; }
        public Complex L2Current { get; set; }
        public Complex L3Current { get; set; }
        public Complex NCurrent { get; set; }

        public Complex L1Voltage { get; set; }
        public Complex L2Voltage { get; set; }
        public Complex L3Voltage { get; set; }

        public FaultData(double l1CurrentMag, double l2CurrentMag, double l3CurrentMag, double nCurrentMag, double l1CurrentArg, double l2CurrentArg, double l3CurrentArg, double nCurrentArg, double l1VoltageMag, double l2VoltageMag, double l3VoltageMag, double l1VoltageArg, double l2VoltageArg, double l3VoltageArg)
        {
            L1Current = Complex.FromPolarCoordinates(l1CurrentMag, l1CurrentArg * Math.PI / 180);
            L2Current = Complex.FromPolarCoordinates(l2CurrentMag, l2CurrentArg * Math.PI / 180);
            L3Current = Complex.FromPolarCoordinates(l3CurrentMag, l3CurrentArg * Math.PI / 180);
            NCurrent = Complex.FromPolarCoordinates(nCurrentMag, nCurrentArg * Math.PI / 180);

            L1Voltage = Complex.FromPolarCoordinates(l1VoltageMag, l1VoltageArg * Math.PI / 180);
            L2Voltage = Complex.FromPolarCoordinates(l2VoltageMag, l2VoltageArg * Math.PI / 180);
            L3Voltage = Complex.FromPolarCoordinates(l3VoltageMag, l3VoltageArg * Math.PI / 180);
    }
    }
}
