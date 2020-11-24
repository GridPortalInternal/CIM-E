﻿using System;
using System.Collections.Generic;
using System.Text;
using CIME.GEIRINA;

namespace CIME.Core
{
    public class VoltageLevel : EquipmentContainer, IDatabaseIO
    {
        public double highkV { get; set; }

        public double lowkV { get; set; }

        public Substation Substation { get; set; }

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
