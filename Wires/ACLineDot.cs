using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CIME.Core;

namespace CIME.Wires
{
    /// <summary>
    /// New Class in CIM/E
    /// </summary>
//    [Table("ACLineDot")]
    public class ACLineDot : Conductor
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
    }
}
