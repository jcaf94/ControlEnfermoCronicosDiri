
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IPractitionerCAD
{
PractitionerEN ReadOIDDefault (int identifier
                               );

void ModifyDefault (PractitionerEN practitioner);

System.Collections.Generic.IList<PractitionerEN> ReadAllDefault (int first, int size);



int New_ (PractitionerEN practitioner);

void Modify (PractitionerEN practitioner);


void Destroy (int identifier
              );


PractitionerEN ReadOID (int identifier
                        );


System.Collections.Generic.IList<PractitionerEN> ReadAll (int first, int size);





System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByRole_Location (ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum? p_role, int p_location);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByActive_Location (bool? p_active, int p_Location_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByName_Surname_Location (string p_name, int p_Location_OID);









void AssignLocation (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_location_OIDs);

void UnassignLocation (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_location_OIDs);

System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByPatientNif (string p_Patient_nif);


void AssignSpecialty (int p_Practitioner_OID, int p_specialty_OID);

void UnassignSpecialty (int p_Practitioner_OID, int p_specialty_OID);

System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByGender_Location (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, int p_Location_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByRole_LocationName (ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum? p_role, string p_Location_name);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByNif (string p_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByLocation (int p_location);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByLocationName (string p_Location_name);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByPhone (string p_phone);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerBySpecialtyDisplay (string p_Specialty_Display);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersBySpecialtyCode (string p_Specialty_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersBySpecialtyDisplay_Interval (string p_Specialty_display, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByBirthInterval (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByEmail (string email);


void AssignSchedule (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_schedule_OIDs);

void UnassignSchedule (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_schedule_OIDs);
}
}
