using System;
using CIME.ControlArea;
using CIME.Core;
using CIME.Wires;

namespace CIME_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CIME.GEIRINA.DatabaseContext())
            {
                var area = new ControlArea()
                {
                    mRID = "11111",
                    name = "CONTROL AREA"
                };
                db.ControlAreas.Add(area);

                var baseVoltage = new BaseVoltage()
                {
                    mRID = "123456",
                    name = "BASE VOLTAGE",
                    nomkV = 115
                };
                //                db.BaseVoltages.Add(baseVoltage);
                db.BaseVoltages.Add(baseVoltage);

                var substation = new Substation()
                {
                    mRID = "22222",
                    name = "SUBSTATION",
                    BaseVoltage = baseVoltage,
                    ControlArea = area
                };
                db.Substations.Add(substation);

                var voltageLvl = new VoltageLevel()
                {
                    mRID = "33333",
                    name = "VOLTAGE LVL",
                    Substation = substation,
                    BaseVoltage = baseVoltage
                };
                db.VoltageLevels.Add(voltageLvl);

                var bay = new Bay()
                {
                    mRID = "4444",
                    name = "BAY",
                    Substation = substation,
                    VoltageLevel = voltageLvl,
                    BaseVoltage = baseVoltage
                };
                db.Bays.Add(bay);

                var breaker = new Breaker()
                {
                    mRID = "55555",
                    name = "breaker",
                    Substation = substation,
                    BaseVoltage = baseVoltage,
                    VoltageLevel = voltageLvl,
                    Bay = bay
                };
                db.Breakers.Add(breaker);

                db.SaveChanges();
            }
        }
    }
}
