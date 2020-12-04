using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.Wires
{
#if TPT
//    [Table("EnergyConsumer")]
#endif
    public class EnergyConsumer : Core.ConductingEquipment
    {
    }
}
