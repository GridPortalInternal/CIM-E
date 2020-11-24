using CIME.GEIRINA;

namespace CIME.Wires
{
    public class GroundDisconnector : Switch, IDatabaseIO
    {
        public string type { get; set; }

        public string I_node { get; set; }

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
