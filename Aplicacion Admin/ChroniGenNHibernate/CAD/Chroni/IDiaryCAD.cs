
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IDiaryCAD
{
DiaryEN ReadOIDDefault (int identifier
                        );

void ModifyDefault (DiaryEN diary);

System.Collections.Generic.IList<DiaryEN> ReadAllDefault (int first, int size);



int New_ (DiaryEN diary);

void Modify (DiaryEN diary);


void Destroy (int identifier
              );


DiaryEN ReadOID (int identifier
                 );


System.Collections.Generic.IList<DiaryEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitioner (int p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitionerNif (string p_Practitioner_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitionerSurnames (string p_Practitioner_surnames);


void AssignPractitioner (int p_Diary_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs);

void UnassignPractitioner (int p_Diary_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs);

System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatient (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatientNif (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatientSurnames (string p_Patient_surnames);
}
}
