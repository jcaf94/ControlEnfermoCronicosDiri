

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;

using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


namespace ChroniGenNHibernate.CEN.Chroni
{
/*
 *      Definition of the class ConversationCEN
 *
 */
public partial class ConversationCEN
{
private IConversationCAD _IConversationCAD;

public ConversationCEN()
{
        this._IConversationCAD = new ConversationCAD ();
}

public ConversationCEN(IConversationCAD _IConversationCAD)
{
        this._IConversationCAD = _IConversationCAD;
}

public IConversationCAD get_IConversationCAD ()
{
        return this._IConversationCAD;
}

public void Modify (int p_Conversation_OID, Nullable<DateTime> p_startDate)
{
        ConversationEN conversationEN = null;

        //Initialized ConversationEN
        conversationEN = new ConversationEN ();
        conversationEN.Identifier = p_Conversation_OID;
        conversationEN.StartDate = p_startDate;
        //Call to ConversationCAD

        _IConversationCAD.Modify (conversationEN);
}

public void Destroy (int identifier
                     )
{
        _IConversationCAD.Destroy (identifier);
}

public ConversationEN ReadOID (int identifier
                               )
{
        ConversationEN conversationEN = null;

        conversationEN = _IConversationCAD.ReadOID (identifier);
        return conversationEN;
}

public System.Collections.Generic.IList<ConversationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConversationEN> list = null;

        list = _IConversationCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPatient (int p_Patient_OID)
{
        return _IConversationCAD.GetConversationByPatient (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPractitioner (int p_Practitioner_OID)
{
        return _IConversationCAD.GetConversationByPractitioner (p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByRelatedPerson (int p_RelatedPerson_OID)
{
        return _IConversationCAD.GetConversationByRelatedPerson (p_RelatedPerson_OID);
}
public void AssignPatient (int p_Conversation_OID, int p_patient_OID)
{
        //Call to ConversationCAD

        _IConversationCAD.AssignPatient (p_Conversation_OID, p_patient_OID);
}
public void AssignRelatedPerson (int p_Conversation_OID, int p_relatedPerson_OID)
{
        //Call to ConversationCAD

        _IConversationCAD.AssignRelatedPerson (p_Conversation_OID, p_relatedPerson_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPatientNif ()
{
        return _IConversationCAD.GetConversationByPatientNif ();
}
}
}
