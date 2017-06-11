
using System;
// Definición clase SubstanceCodeEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class SubstanceCodeEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo code
 */
private string code;



/**
 *	Atributo display
 */
private string display;



/**
 *	Atributo ingredient
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> ingredient;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Code {
        get { return code; } set { code = value;  }
}



public virtual string Display {
        get { return display; } set { display = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> Ingredient {
        get { return ingredient; } set { ingredient = value;  }
}





public SubstanceCodeEN()
{
        ingredient = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.IngredientEN>();
}



public SubstanceCodeEN(int identifier, string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> ingredient
                       )
{
        this.init (Identifier, code, display, ingredient);
}


public SubstanceCodeEN(SubstanceCodeEN substanceCode)
{
        this.init (Identifier, substanceCode.Code, substanceCode.Display, substanceCode.Ingredient);
}

private void init (int identifier
                   , string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> ingredient)
{
        this.Identifier = identifier;


        this.Code = code;

        this.Display = display;

        this.Ingredient = ingredient;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SubstanceCodeEN t = obj as SubstanceCodeEN;
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
