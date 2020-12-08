using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIME.LoadModel
{
#if TPT
    [Table("ConformLoad")]
#endif
    public class ConformLoad : Wires.EnergyConsumer
    {
    }
}
