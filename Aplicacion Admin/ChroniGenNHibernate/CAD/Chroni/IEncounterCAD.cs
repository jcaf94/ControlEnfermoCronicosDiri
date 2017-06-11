
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IEncounterCAD
{
EncounterEN ReadOIDDefault (int identifier
                            );

void ModifyDefault (EncounterEN encounter);

System.Collections.Generic.IList<EncounterEN> ReadAllDefault (int first, int size);



int New_ (EncounterEN encounter);

void Modify (EncounterEN encounter);


void Destroy (int identifier
              );


EncounterEN ReadOID (int identifier
                     );


System.Collections.Generic.IList<EncounterEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Status (string p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Practitioner (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitioner (int p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEnconntersByPractitioner_Status (int p_Practitioner_OID, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCategory (ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum ? p_ConditionCategory);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByCondidionClinicalStatus (ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum ? p_Condition_clinicalStatus);




System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCodeCode (string p_Condition_code);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCodeDisplay (string p_ConditionCode_display);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif (string p_Practitioner_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerName_Surnames ();


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersBySpecialtyCode (string p_SpecialtyCode);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersBySpecialtyDisplay (string p_Specialty_Display);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_PractitionerSpecialtyDisplay (string p_Patient_nif, string p_Specialty_display);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByInterval_Priority (Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum ? p_priority);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_Status (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_Interval (string p_patient_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_PractitionerName_Surnames (string p_Patient_nif, string p_Practitioner_name, string p_Practitioner_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif_Interval (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif_Status ();


void AssignCarePlan (int p_Encounter_OID, System.Collections.Generic.IList<int> p_carePlan_OIDs);

void UnassignCarePlan (int p_Encounter_OID, System.Collections.Generic.IList<int> p_carePlan_OIDs);
}
}
