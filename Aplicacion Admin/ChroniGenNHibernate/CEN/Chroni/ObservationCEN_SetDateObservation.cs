
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Observation_setDateObservation) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ObservationCEN
{
public void SetDateObservation (int p_oid, Nullable<DateTime> p_dateObservation)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Observation_setDateObservation) ENABLED START*/

        // Write here your custom code...

        ObservationCAD observationCAD = new ObservationCAD ();
        ObservationCEN observationCEN = new ObservationCEN (observationCAD);

        if (p_oid > 0) {
                ObservationEN observation = observationCEN.ReadOID (p_oid);

                if (observation != null) {
                        if (p_dateObservation != null) {
                                observation.DateObservation = p_dateObservation;
                                observationCAD.Modify (observation);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
