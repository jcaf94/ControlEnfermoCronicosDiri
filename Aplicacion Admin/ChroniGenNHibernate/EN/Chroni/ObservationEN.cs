
using System;
// Definición clase ObservationEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ObservationEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo measureType
 */
private ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum measureType;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo dateEntry
 */
private Nullable<DateTime> dateEntry;



/**
 *	Atributo note
 */
private string note;



/**
 *	Atributo dateAdded
 */
private Nullable<DateTime> dateAdded;



/**
 *	Atributo diary
 */
private ChroniGenNHibernate.EN.Chroni.DiaryEN diary;



/**
 *	Atributo dateObservation
 */
private Nullable<DateTime> dateObservation;



/**
 *	Atributo category
 */
private ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum category;



/**
 *	Atributo grade
 */
private ChroniGenNHibernate.Enumerated.Chroni.SymptomGradeEnum grade;



/**
 *	Atributo value1
 */
private double value1;



/**
 *	Atributo value2
 */
private double value2;



/**
 *	Atributo personOID
 */
private int personOID;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum MeasureType {
        get { return measureType; } set { measureType = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual Nullable<DateTime> DateEntry {
        get { return dateEntry; } set { dateEntry = value;  }
}



public virtual string Note {
        get { return note; } set { note = value;  }
}



public virtual Nullable<DateTime> DateAdded {
        get { return dateAdded; } set { dateAdded = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.DiaryEN Diary {
        get { return diary; } set { diary = value;  }
}



public virtual Nullable<DateTime> DateObservation {
        get { return dateObservation; } set { dateObservation = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum Category {
        get { return category; } set { category = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.SymptomGradeEnum Grade {
        get { return grade; } set { grade = value;  }
}



public virtual double Value1 {
        get { return value1; } set { value1 = value;  }
}



public virtual double Value2 {
        get { return value2; } set { value2 = value;  }
}



public virtual int PersonOID {
        get { return personOID; } set { personOID = value;  }
}





public ObservationEN()
{
}



public ObservationEN(int identifier, ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum measureType, string name, Nullable<DateTime> dateEntry, string note, Nullable<DateTime> dateAdded, ChroniGenNHibernate.EN.Chroni.DiaryEN diary, Nullable<DateTime> dateObservation, ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum category, ChroniGenNHibernate.Enumerated.Chroni.SymptomGradeEnum grade, double value1, double value2, int personOID
                     )
{
        this.init (Identifier, measureType, name, dateEntry, note, dateAdded, diary, dateObservation, category, grade, value1, value2, personOID);
}


public ObservationEN(ObservationEN observation)
{
        this.init (Identifier, observation.MeasureType, observation.Name, observation.DateEntry, observation.Note, observation.DateAdded, observation.Diary, observation.DateObservation, observation.Category, observation.Grade, observation.Value1, observation.Value2, observation.PersonOID);
}

private void init (int identifier
                   , ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum measureType, string name, Nullable<DateTime> dateEntry, string note, Nullable<DateTime> dateAdded, ChroniGenNHibernate.EN.Chroni.DiaryEN diary, Nullable<DateTime> dateObservation, ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum category, ChroniGenNHibernate.Enumerated.Chroni.SymptomGradeEnum grade, double value1, double value2, int personOID)
{
        this.Identifier = identifier;


        this.MeasureType = measureType;

        this.Name = name;

        this.DateEntry = dateEntry;

        this.Note = note;

        this.DateAdded = dateAdded;

        this.Diary = diary;

        this.DateObservation = dateObservation;

        this.Category = category;

        this.Grade = grade;

        this.Value1 = value1;

        this.Value2 = value2;

        this.PersonOID = personOID;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ObservationEN t = obj as ObservationEN;
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
