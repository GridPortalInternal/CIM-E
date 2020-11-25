using System.ComponentModel.DataAnnotations.Schema;

namespace CIME.Wires
{
#if TPT
    [Table("RegulatingCondEq")]
#endif
    public class RegulatingCondEq : Core.ConductingEquipment
    {
    }
}
