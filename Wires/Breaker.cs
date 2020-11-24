using CIME.Core;
using CIME.GEIRINA;

namespace CIME.Wires
{
    public class Breaker : ProtectedSwitch, IDatabaseIO
    {
        public string type { get; set; }

        public string I_node { get; set; }

        public string J_node { get; set; }

        public double mvarating { get; set; }


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
