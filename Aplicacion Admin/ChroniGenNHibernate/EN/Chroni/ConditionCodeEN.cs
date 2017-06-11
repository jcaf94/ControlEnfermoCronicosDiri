
using System;
// Definición clase ConditionCodeEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ConditionCodeEN
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
 *	Atributo condition
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> condition;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Code {
        get { return code; } set { code = value;  }
}



public virtual string Display {
        get { return display; } set { display = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> Condition {
        get { return condition; } set { condition = value;  }
}





public ConditionCodeEN()
{
        condition = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ConditionEN>();
}



public ConditionCodeEN(int identifier, string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> condition
                       )
{
        this.init (Identifier, code, display, condition);
}


public ConditionCodeEN(ConditionCodeEN conditionCode)
{
        this.init (Identifier, conditionCode.Code, conditionCode.Display, conditionCode.Condition);
}

private void init (int identifier
                   , string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> condition)
{
        this.Identifier = identifier;


        this.Code = code;

        this.Display = display;

        this.Condition = condition;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ConditionCodeEN t = obj as ConditionCodeEN;
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
