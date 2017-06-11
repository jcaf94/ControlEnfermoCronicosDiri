
using System;
// Definición clase ConversationEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ConversationEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo startDate
 */
private Nullable<DateTime> startDate;



/**
 *	Atributo message
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> message;



/**
 *	Atributo patient
 */
private ChroniGenNHibernate.EN.Chroni.PatientEN patient;



/**
 *	Atributo practitioner
 */
private ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner;



/**
 *	Atributo relatedPerson
 */
private ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual Nullable<DateTime> StartDate {
        get { return startDate; } set { startDate = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> Message {
        get { return message; } set { message = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PatientEN Patient {
        get { return patient; } set { patient = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PractitionerEN Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.RelatedPersonEN RelatedPerson {
        get { return relatedPerson; } set { relatedPerson = value;  }
}





public ConversationEN()
{
        message = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.MessageEN>();
}



public ConversationEN(int identifier, Nullable<DateTime> startDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> message, ChroniGenNHibernate.EN.Chroni.PatientEN patient, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson
                      )
{
        this.init (Identifier, startDate, message, patient, practitioner, relatedPerson);
}


public ConversationEN(ConversationEN conversation)
{
        this.init (Identifier, conversation.StartDate, conversation.Message, conversation.Patient, conversation.Practitioner, conversation.RelatedPerson);
}

private void init (int identifier
                   , Nullable<DateTime> startDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> message, ChroniGenNHibernate.EN.Chroni.PatientEN patient, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson)
{
        this.Identifier = identifier;


        this.StartDate = startDate;

        this.Message = message;

        this.Patient = patient;

        this.Practitioner = practitioner;

        this.RelatedPerson = relatedPerson;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ConversationEN t = obj as ConversationEN;
        if (t == null)
                return false;
        if (Identifier.Equals (t.Identifier))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Identifier.GetHashCode ();
        return hash;
}
}
}
