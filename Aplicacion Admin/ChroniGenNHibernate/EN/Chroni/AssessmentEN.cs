
using System;
// Definición clase AssessmentEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class AssessmentEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo rating
 */
private int rating;



/**
 *	Atributo practitioner
 */
private ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner;



/**
 *	Atributo patient
 */
private ChroniGenNHibernate.EN.Chroni.PatientEN patient;



/**
 *	Atributo relatedPerson
 */
private ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual int Rating {
        get { return rating; } set { rating = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PractitionerEN Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PatientEN Patient {
        get { return patient; } set { patient = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.RelatedPersonEN RelatedPerson {
        get { return relatedPerson; } set { relatedPerson = value;  }
}





public AssessmentEN()
{
}



public AssessmentEN(int identifier, int rating, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, ChroniGenNHibernate.EN.Chroni.PatientEN patient, ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson
                    )
{
        this.init (Identifier, rating, practitioner, patient, relatedPerson);
}


public AssessmentEN(AssessmentEN assessment)
{
        this.init (Identifier, assessment.Rating, assessment.Practitioner, assessment.Patient, assessment.RelatedPerson);
}

private void init (int identifier
                   , int rating, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, ChroniGenNHibernate.EN.Chroni.PatientEN patient, ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPerson)
{
        this.Identifier = identifier;


        this.Rating = rating;

        this.Practitioner = practitioner;

        this.Patient = patient;

        this.RelatedPerson = relatedPerson;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AssessmentEN t = obj as AssessmentEN;
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
