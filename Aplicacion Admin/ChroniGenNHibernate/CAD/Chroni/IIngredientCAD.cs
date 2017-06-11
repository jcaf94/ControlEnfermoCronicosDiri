
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IIngredientCAD
{
IngredientEN ReadOIDDefault (int identifier
                             );

void ModifyDefault (IngredientEN ingredient);

System.Collections.Generic.IList<IngredientEN> ReadAllDefault (int first, int size);



int New_ (IngredientEN ingredient);

void Modify (IngredientEN ingredient);


void Destroy (int identifier
              );


IngredientEN ReadOID (int identifier
                      );


System.Collections.Generic.IList<IngredientEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> GetIngredientsByIsActive (bool ? p_isActive);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> GetIngredientsByMedicationName (string p_Medication_Name);
}
}
