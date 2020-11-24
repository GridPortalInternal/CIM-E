using System;
using System.Collections.Generic;
using System.Text;
using CIME.GEIRINA;

namespace CIME.Core
{
    public class Bay : EquipmentContainer, IDatabaseIO
    {
        public Substation Substation { get; set; }

        public VoltageLevel VoltageLevel { get; set; }

        public BaseVoltage BaseVoltage { get; set; }

        public string Type { get; set; }

        public void CreateTable(IDatabaseConnection conn)
        {
            throw new NotImplementedException();
        }

        public void InsertInto(IDatabaseConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
