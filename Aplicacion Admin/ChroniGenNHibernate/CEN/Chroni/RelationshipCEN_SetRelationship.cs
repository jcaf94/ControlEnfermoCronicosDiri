
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Relationship_setRelationship) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class RelationshipCEN
{
public void SetRelationship (int p_oid, int p_oid_patient, int p_oid_relatedPerson)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Relationship_setRelationship) ENABLED START*/

        // Write here your custom code...

        RelationshipCAD relationshipCAD = new RelationshipCAD ();
        RelationshipCEN relationshipCEN = new RelationshipCEN (relationshipCAD);

        PatientCAD patientCAD = new PatientCAD ();
        PatientCEN patientCen = new PatientCEN (patientCAD);

        RelatedPersonCAD relatedPersonCAD = new RelatedPersonCAD ();
        RelatedPersonCEN relatedPersonCEN = new RelatedPersonCEN (relatedPersonCAD);

        if (p_oid > 0) {
                RelationshipEN relationship = relationshipCEN.ReadOID (p_oid);

                if (relationship != null) {
                        if (p_oid_patient > 0) {
                                PatientEN patient = patientCen.ReadOID (p_oid_patient);

                                if (patient != null) {
                                        if (p_oid_relatedPerson > 0) {
                                                RelatedPersonEN relatedPerson = relatedPersonCEN.ReadOID (p_oid_relatedPerson);

                                                if (relatedPerson != null) {
                                                        relationship.PatientOID = p_oid_patient;
                                                        relationship.RelatedPersonOID = p_oid_relatedPerson;
                                                        relationshipCAD.Modify (relationship);
                                                }
                                        }
                                }
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
