
using System;
// Definición clase ReclamationResponseEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class ReclamationResponseEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo response
 */
private string response;



/**
 *	Atributo actionState
 */
private ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum actionState;



/**
 *	Atributo createdDate
 */
private Nullable<DateTime> createdDate;



/**
 *	Atributo reclamation
 */
private ChroniGenNHibernate.EN.Chroni.ReclamationEN reclamation;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Response {
        get { return response; } set { response = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum ActionState {
        get { return actionState; } set { actionState = value;  }
}



public virtual Nullable<DateTime> CreatedDate {
        get { return createdDate; } set { createdDate = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.ReclamationEN Reclamation {
        get { return reclamation; } set { reclamation = value;  }
}





public ReclamationResponseEN()
{
}



public ReclamationResponseEN(int identifier, string response, ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum actionState, Nullable<DateTime> createdDate, ChroniGenNHibernate.EN.Chroni.ReclamationEN reclamation
                             )
{
        this.init (Identifier, response, actionState, createdDate, reclamation);
}


public ReclamationResponseEN(ReclamationResponseEN reclamationResponse)
{
        this.init (Identifier, reclamationResponse.Response, reclamationResponse.ActionState, reclamationResponse.CreatedDate, reclamationResponse.Reclamation);
}

private void init (int identifier
                   , string response, ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum actionState, Nullable<DateTime> createdDate, ChroniGenNHibernate.EN.Chroni.ReclamationEN reclamation)
{
        this.Identifier = identifier;


        this.Response = response;

        this.ActionState = actionState;

        this.CreatedDate = createdDate;

        this.Reclamation = reclamation;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReclamationResponseEN t = obj as ReclamationResponseEN;
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
