

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;

using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


namespace ChroniGenNHibernate.CEN.Chroni
{
/*
 *      Definition of the class ScheduleCEN
 *
 */
public partial class ScheduleCEN
{
private IScheduleCAD _IScheduleCAD;

public ScheduleCEN()
{
        this._IScheduleCAD = new ScheduleCAD ();
}

public ScheduleCEN(IScheduleCAD _IScheduleCAD)
{
        this._IScheduleCAD = _IScheduleCAD;
}

public IScheduleCAD get_IScheduleCAD ()
{
        return this._IScheduleCAD;
}

public void Modify (int p_Schedule_OID, bool p_active, Nullable<DateTime> p_morningStart, Nullable<DateTime> p_morningEnd, Nullable<DateTime> p_afternoonStart, Nullable<DateTime> p_afternoonEnd, Nullable<DateTime> p_dateStart, Nullable<DateTime> p_dateEnd)
{
        ScheduleEN scheduleEN = null;

        //Initialized ScheduleEN
        scheduleEN = new ScheduleEN ();
        scheduleEN.Identifier = p_Schedule_OID;
        scheduleEN.Active = p_active;
        scheduleEN.MorningStart = p_morningStart;
        scheduleEN.MorningEnd = p_morningEnd;
        scheduleEN.AfternoonStart = p_afternoonStart;
        scheduleEN.AfternoonEnd = p_afternoonEnd;
        scheduleEN.DateStart = p_dateStart;
        scheduleEN.DateEnd = p_dateEnd;
        //Call to ScheduleCAD

        _IScheduleCAD.Modify (scheduleEN);
}

public void Destroy (int identifier
                     )
{
        _IScheduleCAD.Destroy (identifier);
}

public ScheduleEN ReadOID (int identifier
                           )
{
        ScheduleEN scheduleEN = null;

        scheduleEN = _IScheduleCAD.ReadOID (identifier);
        return scheduleEN;
}

public System.Collections.Generic.IList<ScheduleEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ScheduleEN> list = null;

        list = _IScheduleCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner (int p_Practitioner_OID)
{
        return _IScheduleCAD.GetSchedulesByPractitioner (p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Interval (int p_Practitioner_OID)
{
        return _IScheduleCAD.GetSchedulesByPractitioner_Interval (p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Interval_Active (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, bool ? p_active)
{
        return _IScheduleCAD.GetSchedulesByPractitioner_Interval_Active (p_Practitioner_OID, p_dateFrom, p_dateTo, p_active);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif_Interval (string p_practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IScheduleCAD.GetSchedulesByPractitionerNif_Interval (p_practitioner_nif, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Location (int p_Practitioner_OID, int p_Location_OID)
{
        return _IScheduleCAD.GetSchedulesByPractitioner_Location (p_Practitioner_OID, p_Location_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Interval (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IScheduleCAD.GetSchedulesByPractitionerSurnames_Interval (p_Practitioner_nif, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Interval_Active (string p_Practitioner_surnames, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, bool ? p_active)
{
        return _IScheduleCAD.GetSchedulesByPractitionerSurnames_Interval_Active (p_Practitioner_surnames, p_dateFrom, p_dateTo, p_active);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif (string p_Practitioner_nif)
{
        return _IScheduleCAD.GetSchedulesByPractitionerNif (p_Practitioner_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Active (string p_Practitioner_Surnames, bool ? p_active)
{
        return _IScheduleCAD.GetSchedulesByPractitionerSurnames_Active (p_Practitioner_Surnames, p_active);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesBySpecialtyDisplay_Active (string p_Specialty_display, bool ? p_active)
{
        return _IScheduleCAD.GetSchedulesBySpecialtyDisplay_Active (p_Specialty_display, p_active);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSpecialty_LocationName_Active (string p_Specialty_display, string p_Location_name, bool ? p_active)
{
        return _IScheduleCAD.GetSchedulesByPractitionerSpecialty_LocationName_Active (p_Specialty_display, p_Location_name, p_active);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_LocationName_Active (string p_Practitioner_surnames, string p_Location_name, string p_active)
{
        return _IScheduleCAD.GetSchedulesByPractitionerSurnames_LocationName_Active (p_Practitioner_surnames, p_Location_name, p_active);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif_LocationName_Active (string p_Practitioner_nif, string p_Location_name, bool ? p_active)
{
        return _IScheduleCAD.GetSchedulesByPractitionerNif_LocationName_Active (p_Practitioner_nif, p_Location_name, p_active);
}
}
}
