
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IGoalCAD
{
GoalEN ReadOIDDefault (int identifier
                       );

void ModifyDefault (GoalEN goal);

System.Collections.Generic.IList<GoalEN> ReadAllDefault (int first, int size);



int New_ (GoalEN goal);

void Modify (GoalEN goal);


void Destroy (int identifier
              );


GoalEN ReadOID (int identifier
                );


System.Collections.Generic.IList<GoalEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetCoalsByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Category_Interval (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Category_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Priority_Interval (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum? p_priority, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByCarePlan (int p_CarePlan_OID);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Interval (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Category_Status (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Priority_Interval (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum? p_priority, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);
}
}
