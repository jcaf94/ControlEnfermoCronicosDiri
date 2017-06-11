
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IReclamationCAD
{
ReclamationEN ReadOIDDefault (int identifier
                              );

void ModifyDefault (ReclamationEN reclamation);

System.Collections.Generic.IList<ReclamationEN> ReadAllDefault (int first, int size);



int New_ (ReclamationEN reclamation);

void Modify (ReclamationEN reclamation);


void Destroy (int identifier
              );


ReclamationEN ReadOID (int identifier
                       );


System.Collections.Generic.IList<ReclamationEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByStartInterval (Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByResolved_ResponseInterval (bool? p_resolved, Nullable<DateTime> p_ReclamationResponse_createdDateFrom, Nullable<DateTime> p_ReclamationResponse_createdDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitionerNif (string p_Practitioner_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByType_StartInterval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum? p_type, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByResolved_StartInterval (bool? p_resolved, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByAction_StartInterval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum? p_reclamationType, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByAction_StartInterval_Patient (ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum? p_action, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo, int p_Patient_OID);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByRelatedPersonNif (string p_RelatedPerson_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByAction_StartInterval_RelatedPerson (ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum? p_action, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo, int p_RelatedPerson_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByEndInterval (Nullable<DateTime> p_ReclamationResponse_createdDateFrom, Nullable<DateTime> p_ReclamationResponse_createdDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPersonNif (string p_RelatedPerson_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByPatientNif (string p_Patient_nif);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPatient (int p_patient);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPerson (int p_RelatedPerson_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitioner (int p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByReclamationResponseActionState (ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum ? p_ReclamationResponse_actionState);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPatientSurnames (string p_Patient_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPersonSurnames (string p_RelatedPerson_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitionerSurnames (string p_Practitioner_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsBySubject (string p_subject);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByContent (string p_content);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByNote (string p_note);


void AssignPractitioner (int p_Reclamation_OID, int p_practitioner_OID);

void UnassignPractitioner (int p_Reclamation_OID, int p_practitioner_OID);
}
}
