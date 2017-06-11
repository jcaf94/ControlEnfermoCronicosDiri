
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IMedicationCAD
{
MedicationEN ReadOIDDefault (int identifier
                             );

void ModifyDefault (MedicationEN medication);

System.Collections.Generic.IList<MedicationEN> ReadAllDefault (int first, int size);



int New_ (MedicationEN medication);

void Modify (MedicationEN medication);


void Destroy (int identifier
              );


MedicationEN ReadOID (int identifier
                      );


System.Collections.Generic.IList<MedicationEN> ReadAll (int first, int size);





System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsBySubstanceCodeCode (string p_SubstanceCode_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form ();


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form_OverTheCounter ();


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form_Manufacturer ();


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByActivity (int p_Activity_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByPatient (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByPatientNif (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsBySubstanceCodeDisplay (string p_SubstanceCode_display);


void AssignIngredient (int p_Medication_OID, System.Collections.Generic.IList<int> p_ingredient_OIDs);

void UnassignIngredient (int p_Medication_OID, System.Collections.Generic.IList<int> p_ingredient_OIDs);
}
}
