
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IConditionCAD
{
ConditionEN ReadOIDDefault (int identifier
                            );

void ModifyDefault (ConditionEN condition);

System.Collections.Generic.IList<ConditionEN> ReadAllDefault (int first, int size);



int New_ (ConditionEN condition);

void Modify (ConditionEN condition);


void Destroy (int identifier
              );


ConditionEN ReadOID (int identifier
                     );


System.Collections.Generic.IList<ConditionEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByPatient (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByPatient_ClinicalStatus (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum ? p_clnicalStatus);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByConditionCodeCode (string p_ConditionCode_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByConditionCode_Display (string p_ConditionCode_Display);


void AssignConditionCode (int p_Condition_OID, int p_conditionCode_OID);

void UnassignConditionCode (int p_Condition_OID, int p_conditionCode_OID);
}
}
