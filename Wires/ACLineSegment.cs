using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using CIME.Core;

namespace CIME.Wires
{
//    [Table("ACLineSegment")]
    public class ACLineSegment : Conductor
    {
        public string StartSt { get; set; }

        public string EndSt { get; set; }

        public double ratedMW { get; set; }

        public double ratedCurrent { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public double R { get; set; }

        public double X { get; set; }

        public double Bch { get; set; }

        public double r0 { get; set; }

        public double x0 { get; set; }

        public double b0ch { get; set; }

        public double length { get; set; }
    }
}
