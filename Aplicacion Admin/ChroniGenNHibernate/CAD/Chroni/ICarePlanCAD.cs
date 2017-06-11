
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface ICarePlanCAD
{
CarePlanEN ReadOIDDefault (int identifier
                           );

void ModifyDefault (CarePlanEN carePlan);

System.Collections.Generic.IList<CarePlanEN> ReadAllDefault (int first, int size);



int New_ (CarePlanEN carePlan);

void Modify (CarePlanEN carePlan);


void Destroy (int identifier
              );


CarePlanEN ReadOID (int identifier
                    );


System.Collections.Generic.IList<CarePlanEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByCategoryCode_Period (string p_CarePlanCategory_code, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByStatus_Period (ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum? p_status, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient_Practitioner (int p_Patient_OID, Nullable<DateTime> p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum ? p_status);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByCategoryDisplay_Period (string p_CarePlanCategory_display, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


void AssignCategory (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_carePlanCategory_OIDs);

void UnassignCategory (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_carePlanCategory_OIDs);

void AssignGoal (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_goal_OIDs);

void UnassignGoal (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_goal_OIDs);
}
}
