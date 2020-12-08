using System.ComponentModel.DataAnnotations.Schema;

namespace CIME.Wires
{
    [Table("GroundDisconnector")]
    public class GroundDisconnector : Switch
    {
        public string type { get; set; }

        public string I_node { get; set; }
    }
}
