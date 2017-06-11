
using System;
// Definición clase ScheduleEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ScheduleEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo slot
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> slot;



/**
 *	Atributo practitioner
 */
private ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner;



/**
 *	Atributo location
 */
private ChroniGenNHibernate.EN.Chroni.LocationEN location;



/**
 *	Atributo active
 */
private bool active;



/**
 *	Atributo morningStart
 */
private Nullable<DateTime> morningStart;



/**
 *	Atributo morningEnd
 */
private Nullable<DateTime> morningEnd;



/**
 *	Atributo afternoonStart
 */
private Nullable<DateTime> afternoonStart;



/**
 *	Atributo afternoonEnd
 */
private Nullable<DateTime> afternoonEnd;



/**
 *	Atributo dateStart
 */
private Nullable<DateTime> dateStart;



/**
 *	Atributo dateEnd
 */
private Nullable<DateTime> dateEnd;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> Slot {
        get { return slot; } set { slot = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PractitionerEN Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.LocationEN Location {
        get { return location; } set { location = value;  }
}



public virtual bool Active {
        get { return active; } set { active = value;  }
}



public virtual Nullable<DateTime> MorningStart {
        get { return morningStart; } set { morningStart = value;  }
}



public virtual Nullable<DateTime> MorningEnd {
        get { return morningEnd; } set { morningEnd = value;  }
}



public virtual Nullable<DateTime> AfternoonStart {
        get { return afternoonStart; } set { afternoonStart = value;  }
}



public virtual Nullable<DateTime> AfternoonEnd {
        get { return afternoonEnd; } set { afternoonEnd = value;  }
}



public virtual Nullable<DateTime> DateStart {
        get { return dateStart; } set { dateStart = value;  }
}



public virtual Nullable<DateTime> DateEnd {
        get { return dateEnd; } set { dateEnd = value;  }
}





public ScheduleEN()
{
        slot = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
}



public ScheduleEN(int identifier, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> slot, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, ChroniGenNHibernate.EN.Chroni.LocationEN location, bool active, Nullable<DateTime> morningStart, Nullable<DateTime> morningEnd, Nullable<DateTime> afternoonStart, Nullable<DateTime> afternoonEnd, Nullable<DateTime> dateStart, Nullable<DateTime> dateEnd
                  )
{
        this.init (Identifier, slot, practitioner, location, active, morningStart, morningEnd, afternoonStart, afternoonEnd, dateStart, dateEnd);
}


public ScheduleEN(ScheduleEN schedule)
{
        this.init (Identifier, schedule.Slot, schedule.Practitioner, schedule.Location, schedule.Active, schedule.MorningStart, schedule.MorningEnd, schedule.AfternoonStart, schedule.AfternoonEnd, schedule.DateStart, schedule.DateEnd);
}

private void init (int identifier
                   , System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> slot, ChroniGenNHibernate.EN.Chroni.PractitionerEN practitioner, ChroniGenNHibernate.EN.Chroni.LocationEN location, bool active, Nullable<DateTime> morningStart, Nullable<DateTime> morningEnd, Nullable<DateTime> afternoonStart, Nullable<DateTime> afternoonEnd, Nullable<DateTime> dateStart, Nullable<DateTime> dateEnd)
{
        this.Identifier = identifier;


        this.Slot = slot;

        this.Practitioner = practitioner;

        this.Location = location;

        this.Active = active;

        this.MorningStart = morningStart;

        this.MorningEnd = morningEnd;

        this.AfternoonStart = afternoonStart;

        this.AfternoonEnd = afternoonEnd;

        this.DateStart = dateStart;

        this.DateEnd = dateEnd;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ScheduleEN t = obj as ScheduleEN;
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
