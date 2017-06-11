
using System;
// Definición clase RelationshipEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class RelationshipEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo relationship
 */
private ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum relationship;



/**
 *	Atributo patientOID
 */
private int patientOID;



/**
 *	Atributo relatedPersonOID
 */
private int relatedPersonOID;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum Relationship {
        get { return relationship; } set { relationship = value;  }
}



public virtual int PatientOID {
        get { return patientOID; } set { patientOID = value;  }
}



public virtual int RelatedPersonOID {
        get { return relatedPersonOID; } set { relatedPersonOID = value;  }
}





public RelationshipEN()
{
}



public RelationshipEN(int identifier, ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum relationship, int patientOID, int relatedPersonOID
                      )
{
        this.init (Identifier, relationship, patientOID, relatedPersonOID);
}


public RelationshipEN(RelationshipEN relationship)
{
        this.init (Identifier, relationship.Relationship, relationship.PatientOID, relationship.RelatedPersonOID);
}

private void init (int identifier
                   , ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum relationship, int patientOID, int relatedPersonOID)
{
        this.Identifier = identifier;


        this.Relationship = relationship;

        this.PatientOID = patientOID;

        this.RelatedPersonOID = relatedPersonOID;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RelationshipEN t = obj as RelationshipEN;
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
