
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IActivityCAD
{
ActivityEN ReadOIDDefault (int identifier
                           );

void ModifyDefault (ActivityEN activity);

System.Collections.Generic.IList<ActivityEN> ReadAllDefault (int first, int size);



int New_ (ActivityEN activity);

void Modify (ActivityEN activity);


void Destroy (int identifier
              );


ActivityEN ReadOID (int identifier
                    );


System.Collections.Generic.IList<ActivityEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByInterval (Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPractitioner_Interval (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByCarePlan (int p_CarePlan_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByCarePlanCategoryDisplay (string p_CarePlanCategory_display);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatientNif (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivityByPractitionerNif (string p_Practitioner_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatientNif_Description (string p_Patient_nif, string p_description);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByDescription ();


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByMedicationName (string p_Medication_name);


void AssignMedication (int p_Activity_OID, System.Collections.Generic.IList<int> p_medication_OIDs);

void UnassignMedication (int p_Activity_OID, System.Collections.Generic.IList<int> p_medication_OIDs);
}
}
