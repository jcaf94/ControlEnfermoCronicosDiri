
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IRelationshipCAD
{
RelationshipEN ReadOIDDefault (int identifier
                               );

void ModifyDefault (RelationshipEN relationship);

System.Collections.Generic.IList<RelationshipEN> ReadAllDefault (int first, int size);



int New_ (RelationshipEN relationship);

void Modify (RelationshipEN relationship);


void Destroy (int identifier
              );


RelationshipEN ReadOID (int identifier
                        );


System.Collections.Generic.IList<RelationshipEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> GetRelationshipByPatient (int p_Patient_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> GetRelationshipByRelatedPerson (string p_RelatedPerson_OID);
}
}
