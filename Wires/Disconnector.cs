using CIME.GEIRINA;

namespace CIME.Wires
{
    public class Disconnector : Switch, IDatabaseIO
    {
        public string I_node { get; set; }

        public string J_node { get; set; }

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
