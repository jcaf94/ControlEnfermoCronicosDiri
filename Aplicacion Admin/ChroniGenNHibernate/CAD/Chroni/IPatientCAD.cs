
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IPatientCAD
{
PatientEN ReadOIDDefault (int identifier
                          );

void ModifyDefault (PatientEN patient);

System.Collections.Generic.IList<PatientEN> ReadAllDefault (int first, int size);



int New_ (PatientEN patient);

void Modify (PatientEN patient);


void Destroy (int identifier
              );


PatientEN ReadOID (int identifier
                   );


System.Collections.Generic.IList<PatientEN> ReadAll (int first, int size);





void AssignLocation (int p_Patient_OID, System.Collections.Generic.IList<int> p_location_OIDs);

void UnassignLocation (int p_Patient_OID, System.Collections.Generic.IList<int> p_location_OIDs);

System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByGender_Location (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, int p_location);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval_Location (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo, int p_location);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByActive_Location (bool? p_active, int p_location);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByName_Surnames_Location (string p_name, string p_surname, int p_location);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientByNif (string p_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByGender_MaritalStatus (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum ? p_maritalStatus);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval_Gender (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum ? p_gender);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCode (string p_conditionCode);







void AssignPractitioner (int p_Patient_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs);

void UnassignPractitioner (int p_Patient_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs);

void AssignRelatedPerson (int p_Patient_OID, System.Collections.Generic.IList<int> p_relatedPerson_OIDs);

void UnassignRelatedPerson (int p_Patient_OID, System.Collections.Generic.IList<int> p_relatedPerson_OIDs);

System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByPractitionerNif (string p_practitionerNif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByRelatedPersonNif (string p_relatedPersonNif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByNameSurnames (string p_name, string p_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByName_Surnames_BirthDate (string p_name, string p_surnames, Nullable<DateTime> p_birthDate);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsBySurnames (string p_surnames);






System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByPhone (string p_phone);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByEmail (string p_email);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByDeseased (bool ? p_deseased);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByEncounter (int p_Encounter_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCodeCode (string p_ConditionCode_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCodeDisplay (string p_ConditionCode_display);


void AssignDiary (int p_Patient_OID, int p_diary_OID);

void UnassignDiary (int p_Patient_OID, int p_diary_OID);

System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByLocation (int p_location);
}
}
