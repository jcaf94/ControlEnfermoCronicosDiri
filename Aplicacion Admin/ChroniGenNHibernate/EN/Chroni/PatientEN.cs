
using System;
// Definición clase PatientEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class PatientEN
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
 *	Atributo active
 */
private bool active;



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
 *	Atributo deceased
 */
private bool deceased;



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
 *	Atributo maritalStatus
 */
private ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum maritalStatus;



/**
 *	Atributo photo
 */
private string photo;



/**
 *	Atributo relatedPerson
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> relatedPerson;



/**
 *	Atributo location
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> location;



/**
 *	Atributo diary
 */
private ChroniGenNHibernate.EN.Chroni.DiaryEN diary;



/**
 *	Atributo encounter
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> encounter;



/**
 *	Atributo conversation
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation;



/**
 *	Atributo reclamation
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo practitioner
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner;



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



public virtual bool Active {
        get { return active; } set { active = value;  }
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



public virtual bool Deceased {
        get { return deceased; } set { deceased = value;  }
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



public virtual ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum MaritalStatus {
        get { return maritalStatus; } set { maritalStatus = value;  }
}



public virtual string Photo {
        get { return photo; } set { photo = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> RelatedPerson {
        get { return relatedPerson; } set { relatedPerson = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> Location {
        get { return location; } set { location = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.DiaryEN Diary {
        get { return diary; } set { diary = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> Encounter {
        get { return encounter; } set { encounter = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> Conversation {
        get { return conversation; } set { conversation = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> Reclamation {
        get { return reclamation; } set { reclamation = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> AssessmentPractitioner {
        get { return assessmentPractitioner; } set { assessmentPractitioner = value;  }
}





public PatientEN()
{
        relatedPerson = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
        location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
        encounter = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
        conversation = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ConversationEN>();
        reclamation = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
        practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
        assessmentPractitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.AssessmentEN>();
}



public PatientEN(int identifier, string nif, bool active, string name, string surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, bool deceased, string address, string email, string phone, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum maritalStatus, string photo, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> relatedPerson, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> location, ChroniGenNHibernate.EN.Chroni.DiaryEN diary, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> encounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation, String password, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> assessmentPractitioner
                 )
{
        this.init (Identifier, nif, active, name, surnames, gender, birthDate, deceased, address, email, phone, maritalStatus, photo, relatedPerson, location, diary, encounter, conversation, reclamation, password, practitioner, assessmentPractitioner);
}


public PatientEN(PatientEN patient)
{
        this.init (Identifier, patient.Nif, patient.Active, patient.Name, patient.Surnames, patient.Gender, patient.BirthDate, patient.Deceased, patient.Address, patient.Email, patient.Phone, patient.MaritalStatus, patient.Photo, patient.RelatedPerson, patient.Location, patient.Diary, patient.Encounter, patient.Conversation, patient.Reclamation, patient.Password, patient.Practitioner, patient.AssessmentPractitioner);
}

private void init (int identifier
                   , string nif, bool active, string name, string surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, bool deceased, string address, string email, string phone, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum maritalStatus, string photo, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> relatedPerson, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> location, ChroniGenNHibernate.EN.Chroni.DiaryEN diary, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> encounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation, String password, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> assessmentPractitioner)
{
        this.Identifier = identifier;


        this.Nif = nif;

        this.Active = active;

        this.Name = name;

        this.Surnames = surnames;

        this.Gender = gender;

        this.BirthDate = birthDate;

        this.Deceased = deceased;

        this.Address = address;

        this.Email = email;

        this.Phone = phone;

        this.MaritalStatus = maritalStatus;

        this.Photo = photo;

        this.RelatedPerson = relatedPerson;

        this.Location = location;

        this.Diary = diary;

        this.Encounter = encounter;

        this.Conversation = conversation;

        this.Reclamation = reclamation;

        this.Password = password;

        this.Practitioner = practitioner;

        this.AssessmentPractitioner = assessmentPractitioner;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PatientEN t = obj as PatientEN;
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
