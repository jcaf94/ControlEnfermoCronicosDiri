

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;

using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


namespace ChroniGenNHibernate.CEN.Chroni
{
/*
 *      Definition of the class RelationshipCEN
 *
 */
public partial class RelationshipCEN
{
private IRelationshipCAD _IRelationshipCAD;

public RelationshipCEN()
{
        this._IRelationshipCAD = new RelationshipCAD ();
}

public RelationshipCEN(IRelationshipCAD _IRelationshipCAD)
{
        this._IRelationshipCAD = _IRelationshipCAD;
}

public IRelationshipCAD get_IRelationshipCAD ()
{
        return this._IRelationshipCAD;
}

public int New_ (ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum p_relationship, int p_patientOID, int p_relatedPersonOID)
{
        RelationshipEN relationshipEN = null;
        int oid;

        //Initialized RelationshipEN
        relationshipEN = new RelationshipEN ();
        relationshipEN.Relationship = p_relationship;

        relationshipEN.PatientOID = p_patientOID;

        relationshipEN.RelatedPersonOID = p_relatedPersonOID;

        //Call to RelationshipCAD

        oid = _IRelationshipCAD.New_ (relationshipEN);
        return oid;
}

public void Modify (int p_Relationship_OID, ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum p_relationship, int p_patientOID, int p_relatedPersonOID)
{
        RelationshipEN relationshipEN = null;

        //Initialized RelationshipEN
        relationshipEN = new RelationshipEN ();
        relationshipEN.Identifier = p_Relationship_OID;
        relationshipEN.Relationship = p_relationship;
        relationshipEN.PatientOID = p_patientOID;
        relationshipEN.RelatedPersonOID = p_relatedPersonOID;
        //Call to RelationshipCAD

        _IRelationshipCAD.Modify (relationshipEN);
}

public void Destroy (int identifier
                     )
{
        _IRelationshipCAD.Destroy (identifier);
}

public RelationshipEN ReadOID (int identifier
                               )
{
        RelationshipEN relationshipEN = null;

        relationshipEN = _IRelationshipCAD.ReadOID (identifier);
        return relationshipEN;
}

public System.Collections.Generic.IList<RelationshipEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RelationshipEN> list = null;

        list = _IRelationshipCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> GetRelationshipByPatient (int p_Patient_OID)
{
        return _IRelationshipCAD.GetRelationshipByPatient (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> GetRelationshipByRelatedPerson (string p_RelatedPerson_OID)
{
        return _IRelationshipCAD.GetRelationshipByRelatedPerson (p_RelatedPerson_OID);
}
}
}
