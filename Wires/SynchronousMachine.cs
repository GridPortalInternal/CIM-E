using System.ComponentModel.DataAnnotations.Schema;
using CIME.Core;

namespace CIME.Wires
{
    [Table("SynchronousMachine")]
    public class SynchronousMachine : RegulatingCondEq
    {
        public string Type { get; set; }

        public string I_node { get; set; }

        public Substation Substation { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public double RatedMW { get; set; }

        public double maxU { get; set; }

        public double minU { get; set; }

        public double maxQ { get; set; }

        public double minQ { get; set; }

        public double maxP { get; set; }

        public double minP { get; set; }

        public double R { get; set; }

        public double X { get; set; }

        public double r0 { get; set; }

        public double x0 { get; set; }

        public double AuxRatio { get; set; }

        public double P { get; set; }

        public double Q { get; set; }

        public double V { get; set; }
    }
}
