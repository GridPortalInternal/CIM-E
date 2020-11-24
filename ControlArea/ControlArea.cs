using System;
using System.Collections.Generic;
using System.Text;
using CIME.GEIRINA;

namespace CIME.ControlArea
{
    public class ControlArea : Core.PowerSystemResource, IDatabaseIO
    {
        public string Parent { get; set; }

        public double P { get; set; }

        public double Q { get; set; }

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
