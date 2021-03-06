
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Location_setStatus) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class LocationCEN
{
public void SetStatus (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum p_status)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Location_setStatus) ENABLED START*/

        // Write here your custom code...

        LocationCAD locationCAD = new LocationCAD ();
        LocationCEN locationCEN = new LocationCEN (locationCAD);

        if (p_oid > 0) {
                LocationEN location = locationCEN.ReadOID (p_oid);

                if (location != null) {
                        if (p_status > 0) {
                                location.Status = p_status;
                                locationCAD.Modify (location);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
