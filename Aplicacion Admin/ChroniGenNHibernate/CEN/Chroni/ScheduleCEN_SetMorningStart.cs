
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Schedule_setMorningStart) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ScheduleCEN
{
public void SetMorningStart (int p_oid, Nullable<DateTime> p_morningStart)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Schedule_setMorningStart) ENABLED START*/

        // Write here your custom code...

        ScheduleCAD scheduleCAD = new ScheduleCAD ();
        ScheduleCEN scheduleCEN = new ScheduleCEN (scheduleCAD);

        if (p_oid > 0) {
                ScheduleEN schedule = scheduleCEN.ReadOID (p_oid);

                if (schedule != null) {
                        if (p_morningStart != null && p_morningStart < schedule.MorningEnd) {
                                schedule.MorningStart = p_morningStart;
                                scheduleCAD.Modify (schedule);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
