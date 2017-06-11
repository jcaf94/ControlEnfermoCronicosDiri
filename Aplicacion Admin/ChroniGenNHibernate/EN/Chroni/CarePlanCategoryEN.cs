
using System;
// Definición clase CarePlanCategoryEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class CarePlanCategoryEN
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
 *	Atributo carePlan
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> carePlan;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Code {
        get { return code; } set { code = value;  }
}



public virtual string Display {
        get { return display; } set { display = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> CarePlan {
        get { return carePlan; } set { carePlan = value;  }
}





public CarePlanCategoryEN()
{
        carePlan = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
}



public CarePlanCategoryEN(int identifier, string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> carePlan
                          )
{
        this.init (Identifier, code, display, carePlan);
}


public CarePlanCategoryEN(CarePlanCategoryEN carePlanCategory)
{
        this.init (Identifier, carePlanCategory.Code, carePlanCategory.Display, carePlanCategory.CarePlan);
}

private void init (int identifier
                   , string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> carePlan)
{
        this.Identifier = identifier;


        this.Code = code;

        this.Display = display;

        this.CarePlan = carePlan;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CarePlanCategoryEN t = obj as CarePlanCategoryEN;
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
