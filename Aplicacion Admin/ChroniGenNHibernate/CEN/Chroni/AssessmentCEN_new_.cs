
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Assessment_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class AssessmentCEN
{
public int New_ (int p_rating, int p_practitioner, int p_patient, int p_relatedPerson)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Assessment_new__customized) START*/

        AssessmentEN assessmentEN = null;

        int oid;

        //Initialized AssessmentEN
        assessmentEN = new AssessmentEN ();
        assessmentEN.Rating = p_rating;


        if (p_practitioner != -1) {
                assessmentEN.Practitioner = new ChroniGenNHibernate.EN.Chroni.PractitionerEN ();
                assessmentEN.Practitioner.Identifier = p_practitioner;
        }


        if (p_patient != -1) {
                assessmentEN.Patient = new ChroniGenNHibernate.EN.Chroni.PatientEN ();
                assessmentEN.Patient.Identifier = p_patient;
        }


        if (p_relatedPerson != -1) {
                assessmentEN.RelatedPerson = new ChroniGenNHibernate.EN.Chroni.RelatedPersonEN ();
                assessmentEN.RelatedPerson.Identifier = p_relatedPerson;
        }

        //Call to AssessmentCAD

        oid = _IAssessmentCAD.New_ (assessmentEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
