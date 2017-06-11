
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Location_setType) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class LocationCEN
{
public void SetType (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum p_type)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Location_setType) ENABLED START*/

        // Write here your custom code...

        LocationCAD locationCAD = new LocationCAD ();
        LocationCEN locationCEN = new LocationCEN (locationCAD);

        if (p_oid > 0) {
                LocationEN location = locationCEN.ReadOID (p_oid);

                if (location != null) {
                        if (p_type > 0) {
                                location.Type = p_type;
                                locationCAD.Modify (location);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
