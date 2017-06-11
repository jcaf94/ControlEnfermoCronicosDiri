
using System;
// Definición clase SpecialtyEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class SpecialtyEN
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
 *	Atributo practitioner
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Code {
        get { return code; } set { code = value;  }
}



public virtual string Display {
        get { return display; } set { display = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}





public SpecialtyEN()
{
        practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
}



public SpecialtyEN(int identifier, string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner
                   )
{
        this.init (Identifier, code, display, practitioner);
}


public SpecialtyEN(SpecialtyEN specialty)
{
        this.init (Identifier, specialty.Code, specialty.Display, specialty.Practitioner);
}

private void init (int identifier
                   , string code, string display, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner)
{
        this.Identifier = identifier;


        this.Code = code;

        this.Display = display;

        this.Practitioner = practitioner;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SpecialtyEN t = obj as SpecialtyEN;
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
