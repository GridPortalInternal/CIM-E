using System.ComponentModel.DataAnnotations.Schema;

namespace CIME.Wires
{
#if TPT
    [Table("Conductor")]
#endif
    public class Conductor : Core.ConductingEquipment
    {
    }
}
