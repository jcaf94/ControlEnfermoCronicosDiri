
using System;
// Definición clase IngredientEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class IngredientEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo amount
 */
private string amount;



/**
 *	Atributo medication
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> medication;



/**
 *	Atributo isActive
 */
private bool isActive;



/**
 *	Atributo substanceCode
 */
private ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN substanceCode;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Amount {
        get { return amount; } set { amount = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> Medication {
        get { return medication; } set { medication = value;  }
}



public virtual bool IsActive {
        get { return isActive; } set { isActive = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN SubstanceCode {
        get { return substanceCode; } set { substanceCode = value;  }
}





public IngredientEN()
{
        medication = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
}



public IngredientEN(int identifier, string amount, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> medication, bool isActive, ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN substanceCode
                    )
{
        this.init (Identifier, amount, medication, isActive, substanceCode);
}


public IngredientEN(IngredientEN ingredient)
{
        this.init (Identifier, ingredient.Amount, ingredient.Medication, ingredient.IsActive, ingredient.SubstanceCode);
}

private void init (int identifier
                   , string amount, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> medication, bool isActive, ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN substanceCode)
{
        this.Identifier = identifier;


        this.Amount = amount;

        this.Medication = medication;

        this.IsActive = isActive;

        this.SubstanceCode = substanceCode;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IngredientEN t = obj as IngredientEN;
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
