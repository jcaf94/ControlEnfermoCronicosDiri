
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Observation_setSymptomGrade) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ObservationCEN
{
public void SetSymptomGrade (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.SymptomGradeEnum p_symptomGrade)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Observation_setSymptomGrade) ENABLED START*/

        // Write here your custom code...

        ObservationCAD observationCAD = new ObservationCAD ();
        ObservationCEN observationCEN = new ObservationCEN (observationCAD);

        if (p_oid > 0) {
                ObservationEN observation = observationCEN.ReadOID (p_oid);

                if (observation != null) {
                        if (p_symptomGrade > 0) {
                                observation.Grade = p_symptomGrade;
                                observationCAD.Modify (observation);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
