
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IConditionCodeCAD
{
ConditionCodeEN ReadOIDDefault (int identifier
                                );

void ModifyDefault (ConditionCodeEN conditionCode);

System.Collections.Generic.IList<ConditionCodeEN> ReadAllDefault (int first, int size);



int New_ (ConditionCodeEN conditionCode);

void Modify (ConditionCodeEN conditionCode);


void Destroy (int identifier
              );


ConditionCodeEN ReadOID (int identifier
                         );


System.Collections.Generic.IList<ConditionCodeEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> GetConditionCodeByCode (string p_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> GetConditionCodeByDisplay (string p_display);
}
}
