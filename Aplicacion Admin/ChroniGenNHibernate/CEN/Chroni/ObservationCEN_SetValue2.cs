
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Observation_setValue2) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ObservationCEN
{
public void SetValue2 (int p_oid, double p_value2)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Observation_setValue2) ENABLED START*/

        // Write here your custom code...

        ObservationCAD observationCAD = new ObservationCAD ();
        ObservationCEN observationCEN = new ObservationCEN (observationCAD);

        if (p_oid > 0) {
                ObservationEN observation = observationCEN.ReadOID (p_oid);

                if (observation != null) {
                        if (p_value2 >= 0) {
                                observation.Value2 = p_value2;
                                observationCAD.Modify (observation);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
