using CIME.Core;
using CIME.GEIRINA;

namespace CIME.Wires
{
    public class BusbarSection : Connector, IDatabaseIO
    {
        public string I_node { get; set; }

        public Substation Substation { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public Bay Bay { get; set; }

        public string Location { get; set; }

        public double vmax { get; set; }

        public double vmin { get; set; }

        public double V { get; set; }

        public double A { get; set; }

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
