
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IScheduleCAD
{
ScheduleEN ReadOIDDefault (int identifier
                           );

void ModifyDefault (ScheduleEN schedule);

System.Collections.Generic.IList<ScheduleEN> ReadAllDefault (int first, int size);



int New_ (ScheduleEN schedule);

void Modify (ScheduleEN schedule);


void Destroy (int identifier
              );


ScheduleEN ReadOID (int identifier
                    );


System.Collections.Generic.IList<ScheduleEN> ReadAll (int first, int size);









System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner (int p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Interval (int p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Interval_Active (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, bool ? p_active);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif_Interval (string p_practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Location (int p_Practitioner_OID, int p_Location_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Interval (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Interval_Active (string p_Practitioner_surnames, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, bool ? p_active);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif (string p_Practitioner_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Active (string p_Practitioner_Surnames, bool ? p_active);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesBySpecialtyDisplay_Active (string p_Specialty_display, bool ? p_active);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSpecialty_LocationName_Active (string p_Specialty_display, string p_Location_name, bool ? p_active);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_LocationName_Active (string p_Practitioner_surnames, string p_Location_name, string p_active);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif_LocationName_Active (string p_Practitioner_nif, string p_Location_name, bool ? p_active);
}
}
