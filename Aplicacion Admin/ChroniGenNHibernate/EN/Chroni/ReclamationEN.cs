
using System;
// Definición clase ReclamationEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ReclamationEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo action
 */
private ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum action;



/**
 *	Atributo subject
 */
private string subject;



/**
 *	Atributo content
 */
private string content;



/**
 *	Atributo startDate
 */
private Nullable<DateTime> startDate;



/**
 *	Atributo reclamationResponse
 */
private ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN reclamationResponse;



/**
 *	Atributo patient
 */
private ChroniGenNHibernate.EN.Chroni.PatientEN patient;



/**
 *	Atributo practitioner
 */
private ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner;



/**
 *	Atributo note
 */
private string note;



/**
 *	Atributo resolved
 */
private bool resolved;



/**
 *	Atributo type
 */
private ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum type;



/**
 *	Atributo relatedPerson
 */
private ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum Action {
        get { return action; } set { action = value;  }
}



public virtual string Subject {
        get { return subject; } set { subject = value;  }
}



public virtual string Content {
        get { return content; } set { content = value;  }
}



public virtual Nullable<DateTime> StartDate {
        get { return startDate; } set { startDate = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN ReclamationResponse {
        get { return reclamationResponse; } set { reclamationResponse = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PatientEN Patient {
        get { return patient; } set { patient = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PractitionerEN Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual string Note {
        get { return note; } set { note = value;  }
}



public virtual bool Resolved {
        get { return resolved; } set { resolved = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.RelatedPersonEN RelatedPerson {
        get { return relatedPerson; } set { relatedPerson = value;  }
}





public ReclamationEN()
{
}



public ReclamationEN(int identifier, ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum action, string subject, string content, Nullable<DateTime> startDate, ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN reclamationResponse, ChroniGenNHibernate.EN.Chroni.PatientEN patient, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, string note, bool resolved, ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum type, ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson
                     )
{
        this.init (Identifier, action, subject, content, startDate, reclamationResponse, patient, practitioner, note, resolved, type, relatedPerson);
}


public ReclamationEN(ReclamationEN reclamation)
{
        this.init (Identifier, reclamation.Action, reclamation.Subject, reclamation.Content, reclamation.StartDate, reclamation.ReclamationResponse, reclamation.Patient, reclamation.Practitioner, reclamation.Note, reclamation.Resolved, reclamation.Type, reclamation.RelatedPerson);
}

private void init (int identifier
                   , ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum action, string subject, string content, Nullable<DateTime> startDate, ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN reclamationResponse, ChroniGenNHibernate.EN.Chroni.PatientEN patient, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, string note, bool resolved, ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum type, ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson)
{
        this.Identifier = identifier;


        this.Action = action;

        this.Subject = subject;

        this.Content = content;

        this.StartDate = startDate;

        this.ReclamationResponse = reclamationResponse;

        this.Patient = patient;

        this.Practitioner = practitioner;

        this.Note = note;

        this.Resolved = resolved;

        this.Type = type;

        this.RelatedPerson = relatedPerson;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReclamationEN t = obj as ReclamationEN;
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
