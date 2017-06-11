
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Schedule_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ScheduleCEN
{
public int New_ (int p_practitioner, int p_location, bool p_active, Nullable<DateTime> p_morningStart, Nullable<DateTime> p_morningEnd, Nullable<DateTime> p_afternoonStart, Nullable<DateTime> p_afternoonEnd, Nullable<DateTime> p_dateStart, Nullable<DateTime> p_dateEnd)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Schedule_new__customized) START*/

        ScheduleEN scheduleEN = null;

        int oid;

        //Initialized ScheduleEN
        scheduleEN = new ScheduleEN ();

        if (p_practitioner != -1) {
                scheduleEN.Practitioner = new ChroniGenNHibernate.EN.Chroni.PractitionerEN ();
                scheduleEN.Practitioner.Identifier = p_practitioner;
        }


        if (p_location != -1) {
                scheduleEN.Location = new ChroniGenNHibernate.EN.Chroni.LocationEN ();
                scheduleEN.Location.Identifier = p_location;
        }

        scheduleEN.Active = p_active;

        scheduleEN.MorningStart = p_morningStart;

        scheduleEN.MorningEnd = p_morningEnd;

        scheduleEN.AfternoonStart = p_afternoonStart;

        scheduleEN.AfternoonEnd = p_afternoonEnd;

        scheduleEN.DateStart = p_dateStart;

        scheduleEN.DateEnd = p_dateEnd;

        //Call to ScheduleCAD

        oid = _IScheduleCAD.New_ (scheduleEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
