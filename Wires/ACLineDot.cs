using System;
using System.Collections.Generic;
using System.Text;
using CIME.Core;
using CIME.GEIRINA;

namespace CIME.Wires
{
    /// <summary>
    /// New Class in CIM/E
    /// </summary>
    public class ACLineDot : Conductor, IDatabaseIO
    {
        public ACLineSegment ACLineSegment { get; set; }

        public Substation Substation { get; set; }

        public string I_node { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public double P { get; set; }

        public double Q { get; set; }

        public double I { get; set; }

        public Bay Bay { get; set; }

        public void CreateTable(IDatabaseConnection conn)
        {
            throw new NotImplementedException();
        }

        public void InsertInto(IDatabaseConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
