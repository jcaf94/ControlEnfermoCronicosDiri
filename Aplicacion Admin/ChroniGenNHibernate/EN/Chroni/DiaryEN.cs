
using System;
// Definición clase DiaryEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class DiaryEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo observation
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> observation;



/**
 *	Atributo patient
 */
private ChroniGenNHibernate.EN.Chroni.PatientEN patient;



/**
 *	Atributo practitioner
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> Observation {
        get { return observation; } set { observation = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PatientEN Patient {
        get { return patient; } set { patient = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}





public DiaryEN()
{
        observation = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ObservationEN>();
        practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
}



public DiaryEN(int identifier, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> observation, ChroniGenNHibernate.EN.Chroni.PatientEN patient, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner
               )
{
        this.init (Identifier, observation, patient, practitioner);
}


public DiaryEN(DiaryEN diary)
{
        this.init (Identifier, diary.Observation, diary.Patient, diary.Practitioner);
}

private void init (int identifier
                   , System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> observation, ChroniGenNHibernate.EN.Chroni.PatientEN patient, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner)
{
        this.Identifier = identifier;


        this.Observation = observation;

        this.Patient = patient;

        this.Practitioner = practitioner;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DiaryEN t = obj as DiaryEN;
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
