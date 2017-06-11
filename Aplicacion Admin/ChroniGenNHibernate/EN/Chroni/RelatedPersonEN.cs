
using System;
// Definición clase RelatedPersonEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class RelatedPersonEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo nif
 */
private string nif;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo surnames
 */
private string surnames;



/**
 *	Atributo gender
 */
private ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender;



/**
 *	Atributo birthDate
 */
private Nullable<DateTime> birthDate;



/**
 *	Atributo address
 */
private string address;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo phone
 */
private string phone;



/**
 *	Atributo photo
 */
private string photo;



/**
 *	Atributo startDate
 */
private Nullable<DateTime> startDate;



/**
 *	Atributo endDate
 */
private Nullable<DateTime> endDate;



/**
 *	Atributo patient
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo conversation
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation;



/**
 *	Atributo reclamation
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation;



/**
 *	Atributo active
 */
private bool active;



/**
 *	Atributo assessmentPractitioner
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> assessmentPractitioner;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Nif {
        get { return nif; } set { nif = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Surnames {
        get { return surnames; } set { surnames = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.GenderEnum Gender {
        get { return gender; } set { gender = value;  }
}



public virtual Nullable<DateTime> BirthDate {
        get { return birthDate; } set { birthDate = value;  }
}



public virtual string Address {
        get { return address; } set { address = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Phone {
        get { return phone; } set { phone = value;  }
}



public virtual string Photo {
        get { return photo; } set { photo = value;  }
}



public virtual Nullable<DateTime> StartDate {
        get { return startDate; } set { startDate = value;  }
}



public virtual Nullable<DateTime> EndDate {
        get { return endDate; } set { endDate = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> Patient {
        get { return patient; } set { patient = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> Conversation {
        get { return conversation; } set { conversation = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> Reclamation {
        get { return reclamation; } set { reclamation = value;  }
}



public virtual bool Active {
        get { return active; } set { active = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> AssessmentPractitioner {
        get { return assessmentPractitioner; } set { assessmentPractitioner = value;  }
}





public RelatedPersonEN()
{
        patient = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
        conversation = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ConversationEN>();
        reclamation = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
        assessmentPractitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.AssessmentEN>();
}



public RelatedPersonEN(int identifier, string nif, string name, string surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, string address, string email, string phone, string photo, Nullable<DateTime> startDate, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient, String password, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation, bool active, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> assessmentPractitioner
                       )
{
        this.init (Identifier, nif, name, surnames, gender, birthDate, address, email, phone, photo, startDate, endDate, patient, password, conversation, reclamation, active, assessmentPractitioner);
}


public RelatedPersonEN(RelatedPersonEN relatedPerson)
{
        this.init (Identifier, relatedPerson.Nif, relatedPerson.Name, relatedPerson.Surnames, relatedPerson.Gender, relatedPerson.BirthDate, relatedPerson.Address, relatedPerson.Email, relatedPerson.Phone, relatedPerson.Photo, relatedPerson.StartDate, relatedPerson.EndDate, relatedPerson.Patient, relatedPerson.Password, relatedPerson.Conversation, relatedPerson.Reclamation, relatedPerson.Active, relatedPerson.AssessmentPractitioner);
}

private void init (int identifier
                   , string nif, string name, string surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, string address, string email, string phone, string photo, Nullable<DateTime> startDate, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient, String password, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation, bool active, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> assessmentPractitioner)
{
        this.Identifier = identifier;


        this.Nif = nif;

        this.Name = name;

        this.Surnames = surnames;

        this.Gender = gender;

        this.BirthDate = birthDate;

        this.Address = address;

        this.Email = email;

        this.Phone = phone;

        this.Photo = photo;

        this.StartDate = startDate;

        this.EndDate = endDate;

        this.Patient = patient;

        this.Password = password;

        this.Conversation = conversation;

        this.Reclamation = reclamation;

        this.Active = active;

        this.AssessmentPractitioner = assessmentPractitioner;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RelatedPersonEN t = obj as RelatedPersonEN;
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
