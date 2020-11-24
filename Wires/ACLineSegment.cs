using System.Runtime.CompilerServices;
using CIME.Core;
using CIME.GEIRINA;

namespace CIME.Wires
{
    public class ACLineSegment : Conductor, IDatabaseIO
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

        public void CreateTable(IDatabaseConnection conn)
        {
            throw new System.NotImplementedException();
        }

        public void InsertInto(IDatabaseConnection conn)
        {
            throw new System.NotImplementedException();
        }
    }
}
