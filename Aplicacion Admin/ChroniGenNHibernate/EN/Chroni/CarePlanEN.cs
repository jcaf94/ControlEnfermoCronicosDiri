
using System;
// Definición clase CarePlanEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class CarePlanEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo subject
 */
private string subject;



/**
 *	Atributo status
 */
private ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum status;



/**
 *	Atributo context
 */
private string context;



/**
 *	Atributo startDate
 */
private Nullable<DateTime> startDate;



/**
 *	Atributo modified
 */
private Nullable<DateTime> modified;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo note
 */
private string note;



/**
 *	Atributo activity
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> activity;



/**
 *	Atributo encounter
 */
private ChroniGenNHibernate.EN.Chroni.EncounterEN encounter;



/**
 *	Atributo goal
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> goal;



/**
 *	Atributo endDate
 */
private Nullable<DateTime> endDate;



/**
 *	Atributo carePlanCategory
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> carePlanCategory;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Subject {
        get { return subject; } set { subject = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual string Context {
        get { return context; } set { context = value;  }
}



public virtual Nullable<DateTime> StartDate {
        get { return startDate; } set { startDate = value;  }
}



public virtual Nullable<DateTime> Modified {
        get { return modified; } set { modified = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual string Note {
        get { return note; } set { note = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> Activity {
        get { return activity; } set { activity = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.EncounterEN Encounter {
        get { return encounter; } set { encounter = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> Goal {
        get { return goal; } set { goal = value;  }
}



public virtual Nullable<DateTime> EndDate {
        get { return endDate; } set { endDate = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> CarePlanCategory {
        get { return carePlanCategory; } set { carePlanCategory = value;  }
}





public CarePlanEN()
{
        activity = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
        goal = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
        carePlanCategory = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN>();
}



public CarePlanEN(int identifier, string subject, ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum status, string context, Nullable<DateTime> startDate, Nullable<DateTime> modified, string description, string note, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> activity, ChroniGenNHibernate.EN.Chroni.EncounterEN encounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> goal, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> carePlanCategory
                  )
{
        this.init (Identifier, subject, status, context, startDate, modified, description, note, activity, encounter, goal, endDate, carePlanCategory);
}


public CarePlanEN(CarePlanEN carePlan)
{
        this.init (Identifier, carePlan.Subject, carePlan.Status, carePlan.Context, carePlan.StartDate, carePlan.Modified, carePlan.Description, carePlan.Note, carePlan.Activity, carePlan.Encounter, carePlan.Goal, carePlan.EndDate, carePlan.CarePlanCategory);
}

private void init (int identifier
                   , string subject, ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum status, string context, Nullable<DateTime> startDate, Nullable<DateTime> modified, string description, string note, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> activity, ChroniGenNHibernate.EN.Chroni.EncounterEN encounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> goal, Nullable<DateTime> endDate, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> carePlanCategory)
{
        this.Identifier = identifier;


        this.Subject = subject;

        this.Status = status;

        this.Context = context;

        this.StartDate = startDate;

        this.Modified = modified;

        this.Description = description;

        this.Note = note;

        this.Activity = activity;

        this.Encounter = encounter;

        this.Goal = goal;

        this.EndDate = endDate;

        this.CarePlanCategory = carePlanCategory;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CarePlanEN t = obj as CarePlanEN;
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
