
using System;
// Definición clase EncounterEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class EncounterEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo status
 */
private ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum status;



/**
 *	Atributo type
 */
private ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum type;



/**
 *	Atributo priority
 */
private ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum priority;



/**
 *	Atributo startDate
 */
private Nullable<DateTime> startDate;



/**
 *	Atributo endDate
 */
private Nullable<DateTime> endDate;



/**
 *	Atributo reason
 */
private string reason;



/**
 *	Atributo serviceProvider
 */
private string serviceProvider;



/**
 *	Atributo patient
 */
private ChroniGenNHibernate.EN.Chroni.PatientEN patient;



/**
 *	Atributo practitioner
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner;



/**
 *	Atributo condition
 */
private ChroniGenNHibernate.EN.Chroni.ConditionEN condition;



/**
 *	Atributo carePlan
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> carePlan;



/**
 *	Atributo slot
 */
private ChroniGenNHibernate.EN.Chroni.SlotEN slot;



/**
 *	Atributo note
 */
private string note;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum Priority {
        get { return priority; } set { priority = value;  }
}



public virtual Nullable<DateTime> StartDate {
        get { return startDate; } set { startDate = value;  }
}



public virtual Nullable<DateTime> EndDate {
        get { return endDate; } set { endDate = value;  }
}



public virtual string Reason {
        get { return reason; } set { reason = value;  }
}



public virtual string ServiceProvider {
        get { return serviceProvider; } set { serviceProvider = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PatientEN Patient {
        get { return patient; } set { patient = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.ConditionEN Condition {
        get { return condition; } set { condition = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> CarePlan {
        get { return carePlan; } set { carePlan = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.SlotEN Slot {
        get { return slot; } set { slot = value;  }
}



public virtual string Note {
        get { return note; } set { note = value;  }
}





public EncounterEN()
{
        practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
        carePlan = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
}



public EncounterEN(int identifier, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum status, ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum type, ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum priority, Nullable<DateTime> startDate, Nullable<DateTime> endDate, string reason, string serviceProvider, ChroniGenNHibernate.EN.Chroni.PatientEN patient, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner, ChroniGenNHibernate.EN.Chroni.ConditionEN condition, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> carePlan, ChroniGenNHibernate.EN.Chroni.SlotEN slot, string note
                   )
{
        this.init (Identifier, status, type, priority, startDate, endDate, reason, serviceProvider, patient, practitioner, condition, carePlan, slot, note);
}


public EncounterEN(EncounterEN encounter)
{
        this.init (Identifier, encounter.Status, encounter.Type, encounter.Priority, encounter.StartDate, encounter.EndDate, encounter.Reason, encounter.ServiceProvider, encounter.Patient, encounter.Practitioner, encounter.Condition, encounter.CarePlan, encounter.Slot, encounter.Note);
}

private void init (int identifier
                   , ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum status, ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum type, ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum priority, Nullable<DateTime> startDate, Nullable<DateTime> endDate, string reason, string serviceProvider, ChroniGenNHibernate.EN.Chroni.PatientEN patient, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner, ChroniGenNHibernate.EN.Chroni.ConditionEN condition, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> carePlan, ChroniGenNHibernate.EN.Chroni.SlotEN slot, string note)
{
        this.Identifier = identifier;


        this.Status = status;

        this.Type = type;

        this.Priority = priority;

        this.StartDate = startDate;

        this.EndDate = endDate;

        this.Reason = reason;

        this.ServiceProvider = serviceProvider;

        this.Patient = patient;

        this.Practitioner = practitioner;

        this.Condition = condition;

        this.CarePlan = carePlan;

        this.Slot = slot;

        this.Note = note;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EncounterEN t = obj as EncounterEN;
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
