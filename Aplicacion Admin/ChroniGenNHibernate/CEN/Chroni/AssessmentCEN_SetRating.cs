
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Assessment_setRating) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class AssessmentCEN
{
public void SetRating (int p_oid, int p_rating)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Assessment_setRating) ENABLED START*/

        // Write here your custom code...

        AssessmentCAD assessmentCAD = new AssessmentCAD ();
        AssessmentCEN assessmentCEN = new AssessmentCEN (assessmentCAD);

        if (p_oid > 0) {
                AssessmentEN assessment = assessmentCEN.ReadOID (p_oid);

                if (assessment != null) {
                        if (p_rating >= 0) {
                                assessment.Rating = p_rating;
                                assessmentCAD.Modify (assessment);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
