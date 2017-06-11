
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IRelatedPersonCAD
{
RelatedPersonEN ReadOIDDefault (int identifier
                                );

void ModifyDefault (RelatedPersonEN relatedPerson);

System.Collections.Generic.IList<RelatedPersonEN> ReadAllDefault (int first, int size);



int New_ (RelatedPersonEN relatedPerson);

void Modify (RelatedPersonEN relatedPerson);


void Destroy (int identifier
              );


RelatedPersonEN ReadOID (int identifier
                         );


System.Collections.Generic.IList<RelatedPersonEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByRelationship (ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum ? p_Relationship_relationship);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByGender (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum ? p_gender);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByName_Surnames (string p_name, string p_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByName_Surnames_BirthDate (string p_name, string p_surnames, Nullable<DateTime> p_birthDate);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonByNif (string p_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonByPatientNif (string p_patientNif);









System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientSurnames (string p_Patient_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsBySurnames (string p_surnames);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientNif_Interval (string p_Patient_nif, string p_StartDateFrom, string p_endDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientNif_Active (string p_Patient_nif, bool ? p_active);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPhone (string p_phone);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByEmail (string p_email);


void AssignPatient (int p_RelatedPerson_OID, System.Collections.Generic.IList<int> p_patient_OIDs);

void UnassignPatient (int p_RelatedPerson_OID, System.Collections.Generic.IList<int> p_patient_OIDs);
}
}
