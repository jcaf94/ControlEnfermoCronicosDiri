
using System;
// Definición clase ConditionEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ConditionEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo encounter
 */
private ChroniGenNHibernate.EN.Chroni.EncounterEN encounter;



/**
 *	Atributo conditionCode
 */
private ChroniGenNHibernate.EN.Chroni.ConditionCodeEN conditionCode;



/**
 *	Atributo category
 */
private ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum category;



/**
 *	Atributo clinicalStatus
 */
private ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum clinicalStatus;



/**
 *	Atributo severity
 */
private ChroniGenNHibernate.Enumerated.Chroni.ConditionSeverityEnum severity;



/**
 *	Atributo onset
 */
private string onset;



/**
 *	Atributo abatement
 */
private string abatement;



/**
 *	Atributo note
 */
private string note;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.EncounterEN Encounter {
        get { return encounter; } set { encounter = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.ConditionCodeEN ConditionCode {
        get { return conditionCode; } set { conditionCode = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum Category {
        get { return category; } set { category = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum ClinicalStatus {
        get { return clinicalStatus; } set { clinicalStatus = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.ConditionSeverityEnum Severity {
        get { return severity; } set { severity = value;  }
}



public virtual string Onset {
        get { return onset; } set { onset = value;  }
}



public virtual string Abatement {
        get { return abatement; } set { abatement = value;  }
}



public virtual string Note {
        get { return note; } set { note = value;  }
}





public ConditionEN()
{
}



public ConditionEN(int identifier, ChroniGenNHibernate.EN.Chroni.EncounterEN encounter, ChroniGenNHibernate.EN.Chroni.ConditionCodeEN conditionCode, ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum category, ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum clinicalStatus, ChroniGenNHibernate.Enumerated.Chroni.ConditionSeverityEnum severity, string onset, string abatement, string note
                   )
{
        this.init (Identifier, encounter, conditionCode, category, clinicalStatus, severity, onset, abatement, note);
}


public ConditionEN(ConditionEN condition)
{
        this.init (Identifier, condition.Encounter, condition.ConditionCode, condition.Category, condition.ClinicalStatus, condition.Severity, condition.Onset, condition.Abatement, condition.Note);
}

private void init (int identifier
                   , ChroniGenNHibernate.EN.Chroni.EncounterEN encounter, ChroniGenNHibernate.EN.Chroni.ConditionCodeEN conditionCode, ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum category, ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum clinicalStatus, ChroniGenNHibernate.Enumerated.Chroni.ConditionSeverityEnum severity, string onset, string abatement, string note)
{
        this.Identifier = identifier;


        this.Encounter = encounter;

        this.ConditionCode = conditionCode;

        this.Category = category;

        this.ClinicalStatus = clinicalStatus;

        this.Severity = severity;

        this.Onset = onset;

        this.Abatement = abatement;

        this.Note = note;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ConditionEN t = obj as ConditionEN;
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
