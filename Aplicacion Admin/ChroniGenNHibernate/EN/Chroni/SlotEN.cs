
using System;
// Definición clase SlotEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class SlotEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo status
 */
private ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum status;



/**
 *	Atributo startDate
 */
private Nullable<DateTime> startDate;



/**
 *	Atributo endDate
 */
private Nullable<DateTime> endDate;



/**
 *	Atributo note
 */
private string note;



/**
 *	Atributo encounter
 */
private ChroniGenNHibernate.EN.Chroni.EncounterEN encounter;



/**
 *	Atributo schedule
 */
private ChroniGenNHibernate.EN.Chroni.ScheduleEN schedule;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual Nullable<DateTime> StartDate {
        get { return startDate; } set { startDate = value;  }
}



public virtual Nullable<DateTime> EndDate {
        get { return endDate; } set { endDate = value;  }
}



public virtual string Note {
        get { return note; } set { note = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.EncounterEN Encounter {
        get { return encounter; } set { encounter = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.ScheduleEN Schedule {
        get { return schedule; } set { schedule = value;  }
}





public SlotEN()
{
}



public SlotEN(int identifier, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum status, Nullable<DateTime> startDate, Nullable<DateTime> endDate, string note, ChroniGenNHibernate.EN.Chroni.EncounterEN encounter, ChroniGenNHibernate.EN.Chroni.ScheduleEN schedule
              )
{
        this.init (Identifier, status, startDate, endDate, note, encounter, schedule);
}


public SlotEN(SlotEN slot)
{
        this.init (Identifier, slot.Status, slot.StartDate, slot.EndDate, slot.Note, slot.Encounter, slot.Schedule);
}

private void init (int identifier
                   , ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum status, Nullable<DateTime> startDate, Nullable<DateTime> endDate, string note, ChroniGenNHibernate.EN.Chroni.EncounterEN encounter, ChroniGenNHibernate.EN.Chroni.ScheduleEN schedule)
{
        this.Identifier = identifier;


        this.Status = status;

        this.StartDate = startDate;

        this.EndDate = endDate;

        this.Note = note;

        this.Encounter = encounter;

        this.Schedule = schedule;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SlotEN t = obj as SlotEN;
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
