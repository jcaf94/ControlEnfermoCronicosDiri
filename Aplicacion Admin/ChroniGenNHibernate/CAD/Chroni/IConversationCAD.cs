
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IConversationCAD
{
ConversationEN ReadOIDDefault (int identifier
                               );

void ModifyDefault (ConversationEN conversation);

System.Collections.Generic.IList<ConversationEN> ReadAllDefault (int first, int size);



int New_ (ConversationEN conversation);

void Modify (ConversationEN conversation);


void Destroy (int identifier
              );


ConversationEN ReadOID (int identifier
                        );


System.Collections.Generic.IList<ConversationEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPatient (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPractitioner (int p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByRelatedPerson (int p_RelatedPerson_OID);


void AssignPatient (int p_Conversation_OID, int p_patient_OID);

void AssignRelatedPerson (int p_Conversation_OID, int p_relatedPerson_OID);

System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPatientNif ();
}
}
