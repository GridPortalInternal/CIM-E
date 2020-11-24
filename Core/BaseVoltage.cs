using System;
using System.Collections.Generic;
using System.Text;
using CIME.GEIRINA;

namespace CIME.Core
{
    public class BaseVoltage : IdentifiedObject, IDatabaseIO
    {
        public double nomkV { get; set; }

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
