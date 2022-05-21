using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLOCATOR
{
    public class FaultResults
    {
        //Properties
        public LoopResults L1toGround { get; set; }
        public LoopResults L2toGround { get; set; }
        public LoopResults L3toGround { get; set; }
        public LoopResults L1toL2 { get; set; }
        public LoopResults L2toL3 { get; set; }
        public LoopResults L3toL1 { get; set; }

        //Constructor
        public FaultResults(LoopResults resultL1G, LoopResults resultL2G, LoopResults resultL3G, LoopResults resultL1L2, LoopResults resultL2L3, LoopResults resultL3L1)
        {
            L1toGround = resultL1G;
            L2toGround = resultL2G;
            L3toGround = resultL3G;
            L1toL2 = resultL1L2;
            L2toL3 = resultL2L3;
            L3toL1 = resultL3L1;
        }
    }
}
