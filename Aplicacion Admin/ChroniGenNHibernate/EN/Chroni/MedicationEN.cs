
using System;
// Definición clase MedicationEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class MedicationEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo manufacturer
 */
private string manufacturer;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo form
 */
private ChroniGenNHibernate.Enumerated.Chroni.FormEnum form;



/**
 *	Atributo rate
 */
private double rate;



/**
 *	Atributo dosage
 */
private string dosage;



/**
 *	Atributo status
 */
private ChroniGenNHibernate.Enumerated.Chroni.MedicationStatusEnum status;



/**
 *	Atributo isOverTheCounter
 */
private bool isOverTheCounter;



/**
 *	Atributo ingredient
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> ingredient;



/**
 *	Atributo activity
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> activity;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Manufacturer {
        get { return manufacturer; } set { manufacturer = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.FormEnum Form {
        get { return form; } set { form = value;  }
}



public virtual double Rate {
        get { return rate; } set { rate = value;  }
}



public virtual string Dosage {
        get { return dosage; } set { dosage = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.MedicationStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual bool IsOverTheCounter {
        get { return isOverTheCounter; } set { isOverTheCounter = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> Ingredient {
        get { return ingredient; } set { ingredient = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> Activity {
        get { return activity; } set { activity = value;  }
}





public MedicationEN()
{
        ingredient = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.IngredientEN>();
        activity = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
}



public MedicationEN(int identifier, string name, string manufacturer, string description, ChroniGenNHibernate.Enumerated.Chroni.FormEnum form, double rate, string dosage, ChroniGenNHibernate.Enumerated.Chroni.MedicationStatusEnum status, bool isOverTheCounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> ingredient, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> activity
                    )
{
        this.init (Identifier, name, manufacturer, description, form, rate, dosage, status, isOverTheCounter, ingredient, activity);
}


public MedicationEN(MedicationEN medication)
{
        this.init (Identifier, medication.Name, medication.Manufacturer, medication.Description, medication.Form, medication.Rate, medication.Dosage, medication.Status, medication.IsOverTheCounter, medication.Ingredient, medication.Activity);
}

private void init (int identifier
                   , string name, string manufacturer, string description, ChroniGenNHibernate.Enumerated.Chroni.FormEnum form, double rate, string dosage, ChroniGenNHibernate.Enumerated.Chroni.MedicationStatusEnum status, bool isOverTheCounter, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> ingredient, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> activity)
{
        this.Identifier = identifier;


        this.Name = name;

        this.Manufacturer = manufacturer;

        this.Description = description;

        this.Form = form;

        this.Rate = rate;

        this.Dosage = dosage;

        this.Status = status;

        this.IsOverTheCounter = isOverTheCounter;

        this.Ingredient = ingredient;

        this.Activity = activity;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MedicationEN t = obj as MedicationEN;
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
