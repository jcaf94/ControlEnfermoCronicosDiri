
using System;
// Definición clase GoalEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class GoalEN
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
 *	Atributo statusDate
 */
private Nullable<DateTime> statusDate;



/**
 *	Atributo target
 */
private string target;



/**
 *	Atributo category
 */
private ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum category;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo status
 */
private ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum status;



/**
 *	Atributo priority
 */
private ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum priority;



/**
 *	Atributo note
 */
private string note;



/**
 *	Atributo carePlan
 */
private ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlan;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Subject {
        get { return subject; } set { subject = value;  }
}



public virtual Nullable<DateTime> StatusDate {
        get { return statusDate; } set { statusDate = value;  }
}



public virtual string Target {
        get { return target; } set { target = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum Category {
        get { return category; } set { category = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum Priority {
        get { return priority; } set { priority = value;  }
}



public virtual string Note {
        get { return note; } set { note = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.CarePlanEN CarePlan {
        get { return carePlan; } set { carePlan = value;  }
}





public GoalEN()
{
}



public GoalEN(int identifier, string subject, Nullable<DateTime> statusDate, string target, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum category, string description, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum status, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum priority, string note, ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlan
              )
{
        this.init (Identifier, subject, statusDate, target, category, description, status, priority, note, carePlan);
}


public GoalEN(GoalEN goal)
{
        this.init (Identifier, goal.Subject, goal.StatusDate, goal.Target, goal.Category, goal.Description, goal.Status, goal.Priority, goal.Note, goal.CarePlan);
}

private void init (int identifier
                   , string subject, Nullable<DateTime> statusDate, string target, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum category, string description, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum status, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum priority, string note, ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlan)
{
        this.Identifier = identifier;


        this.Subject = subject;

        this.StatusDate = statusDate;

        this.Target = target;

        this.Category = category;

        this.Description = description;

        this.Status = status;

        this.Priority = priority;

        this.Note = note;

        this.CarePlan = carePlan;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        GoalEN t = obj as GoalEN;
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
