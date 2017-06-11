
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_CarePlan_setModified) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class CarePlanCEN
{
public void SetModified (int p_oid, Nullable<DateTime> p_modified)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_CarePlan_setModified) ENABLED START*/

        // Write here your custom code...

        CarePlanCAD carePlanCAD = new CarePlanCAD ();
        CarePlanCEN carePlanCEN = new CarePlanCEN (carePlanCAD);

        if (p_oid > 0) {
                CarePlanEN carePlan = carePlanCEN.ReadOID (p_oid);

                if (carePlan != null) {
                        if (p_modified != null) {
                                carePlan.Modified = p_modified;
                                carePlanCAD.Modify (carePlan);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
