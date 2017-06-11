
using System;
// Definición clase PractitionerEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class PractitionerEN
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
 *	Atributo role
 */
private ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum role;



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
 *	Atributo location
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> location;



/**
 *	Atributo diary
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> diary;



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
 *	Atributo schedule
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> schedule;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo patient
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient;



/**
 *	Atributo specialty
 */
private ChroniGenNHibernate.EN.Chroni.SpecialtyEN specialty;



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



public virtual ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum Role {
        get { return role; } set { role = value;  }
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



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> Location {
        get { return location; } set { location = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> Diary {
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



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> Schedule {
        get { return schedule; } set { schedule = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> Patient {
        get { return patient; } set { patient = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.SpecialtyEN Specialty {
        get { return specialty; } set { specialty = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> AssessmentPractitioner {
        get { return assessmentPractitioner; } set { assessmentPractitioner = value;  }
}





public PractitionerEN()
{
        location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
        diary = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.DiaryEN>();
        encounter = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
        conversation = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ConversationEN>();
        reclamation = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
        schedule = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
        patient = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
        assessmentPractitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.AssessmentEN>();
}



public PractitionerEN(int identifier, string nif, bool active, ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum role, string name, string surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, string address, string email, string phone, string photo, Nullable<DateTime> startDate, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> location, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> diary, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> encounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> schedule, String password, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient, ChroniGenNHibernate.EN.Chroni.SpecialtyEN specialty, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> assessmentPractitioner
                      )
{
        this.init (Identifier, nif, active, role, name, surnames, gender, birthDate, address, email, phone, photo, startDate, endDate, location, diary, encounter, conversation, reclamation, schedule, password, patient, specialty, assessmentPractitioner);
}


public PractitionerEN(PractitionerEN practitioner)
{
        this.init (Identifier, practitioner.Nif, practitioner.Active, practitioner.Role, practitioner.Name, practitioner.Surnames, practitioner.Gender, practitioner.BirthDate, practitioner.Address, practitioner.Email, practitioner.Phone, practitioner.Photo, practitioner.StartDate, practitioner.EndDate, practitioner.Location, practitioner.Diary, practitioner.Encounter, practitioner.Conversation, practitioner.Reclamation, practitioner.Schedule, practitioner.Password, practitioner.Patient, practitioner.Specialty, practitioner.AssessmentPractitioner);
}

private void init (int identifier
                   , string nif, bool active, ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum role, string name, string surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, string address, string email, string phone, string photo, Nullable<DateTime> startDate, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> location, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> diary, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> encounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> conversation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> reclamation, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> schedule, String password, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient, ChroniGenNHibernate.EN.Chroni.SpecialtyEN specialty, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> assessmentPractitioner)
{
        this.Identifier = identifier;


        this.Nif = nif;

        this.Active = active;

        this.Role = role;

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

        this.Location = location;

        this.Diary = diary;

        this.Encounter = encounter;

        this.Conversation = conversation;

        this.Reclamation = reclamation;

        this.Schedule = schedule;

        this.Password = password;

        this.Patient = patient;

        this.Specialty = specialty;

        this.AssessmentPractitioner = assessmentPractitioner;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PractitionerEN t = obj as PractitionerEN;
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
