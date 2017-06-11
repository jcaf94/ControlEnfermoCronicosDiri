
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Practitioner_setEndDate) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PractitionerCEN
{
public void SetEndDate (int p_oid, Nullable<DateTime> p_endDate)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Practitioner_setEndDate) ENABLED START*/

        // Write here your custom code...

        PractitionerCAD practitionerCAD = new PractitionerCAD ();
        PractitionerCEN practitionerCEN = new PractitionerCEN (practitionerCAD);

        if (p_oid > 0) {
                PractitionerEN practitioner = practitionerCEN.ReadOID (p_oid);

                if (practitioner != null) {
                        if (p_endDate != null && p_endDate >= practitioner.StartDate) {
                                practitioner.EndDate = p_endDate;
                                practitionerCAD.Modify (practitioner);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
