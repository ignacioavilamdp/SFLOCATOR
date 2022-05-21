using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SFLOCATOR
{
    public class LineData
    {
        //Properties
        public Complex Z1 { get; set; }
        public Complex Kcomplex { get; set; }
        public double Length { get; set; }
        public double CTRatedK { get; set; }
        public double PTRatedK { get; set; }

        //Constructor
        public LineData(double z1Mag, double z1Arg, double k0r, double k0x, double length, double ctRatedK, double ptRatedK)
        {
            Z1 = Complex.FromPolarCoordinates(z1Mag, z1Arg * Math.PI / 180);
            Kcomplex = new Complex(k0r, k0x);
            Length = length;
            CTRatedK = ctRatedK;
            PTRatedK = ptRatedK;
        }

    }
}
