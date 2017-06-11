
using System;
// Definición clase ActivityEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ActivityEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo progress
 */
private string progress;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo carePlan
 */
private ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlan;



/**
 *	Atributo startDate
 */
private Nullable<DateTime> startDate;



/**
 *	Atributo endDate
 */
private Nullable<DateTime> endDate;



/**
 *	Atributo medication
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> medication;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Progress {
        get { return progress; } set { progress = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.CarePlanEN CarePlan {
        get { return carePlan; } set { carePlan = value;  }
}



public virtual Nullable<DateTime> StartDate {
        get { return startDate; } set { startDate = value;  }
}



public virtual Nullable<DateTime> EndDate {
        get { return endDate; } set { endDate = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> Medication {
        get { return medication; } set { medication = value;  }
}





public ActivityEN()
{
        medication = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
}



public ActivityEN(int identifier, string progress, string description, ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlan, Nullable<DateTime> startDate, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> medication
                  )
{
        this.init (Identifier, progress, description, carePlan, startDate, endDate, medication);
}


public ActivityEN(ActivityEN activity)
{
        this.init (Identifier, activity.Progress, activity.Description, activity.CarePlan, activity.StartDate, activity.EndDate, activity.Medication);
}

private void init (int identifier
                   , string progress, string description, ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlan, Nullable<DateTime> startDate, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> medication)
{
        this.Identifier = identifier;


        this.Progress = progress;

        this.Description = description;

        this.CarePlan = carePlan;

        this.StartDate = startDate;

        this.EndDate = endDate;

        this.Medication = medication;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ActivityEN t = obj as ActivityEN;
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
