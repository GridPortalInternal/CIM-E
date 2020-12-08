using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.Core
{
#if TPT
    [Table("ConductingEquipment")]
#endif
    public class ConductingEquipment : Equipment
    {
    }
}
