
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Relationship_setRelationshipType) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class RelationshipCEN
{
public void SetRelationshipType (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum p_relationship)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Relationship_setRelationshipType) ENABLED START*/

        // Write here your custom code...

        RelationshipCAD relationshipCAD = new RelationshipCAD ();
        RelationshipCEN relationshipCEN = new RelationshipCEN (relationshipCAD);

        if (p_oid > 0) {
                RelationshipEN relationship = relationshipCEN.ReadOID (p_oid);

                if (relationship != null) {
                        if (p_relationship > 0) {
                                relationship.Relationship = p_relationship;
                                relationshipCAD.Modify (relationship);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
