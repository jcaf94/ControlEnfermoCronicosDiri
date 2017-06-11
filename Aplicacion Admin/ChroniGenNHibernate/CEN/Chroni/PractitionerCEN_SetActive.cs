
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Practitioner_setActive) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PractitionerCEN
{
public void SetActive (int p_oid, bool p_active)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Practitioner_setActive) ENABLED START*/

        // Write here your custom code...

        PractitionerCAD practitionerCAD = new PractitionerCAD ();
        PractitionerCEN practitionerCEN = new PractitionerCEN (practitionerCAD);

        if (p_oid > 0) {
                PractitionerEN practitioner = practitionerCEN.ReadOID (p_oid);

                if (practitioner != null) {
                        practitioner.Active = p_active;
                        practitionerCAD.Modify (practitioner);
                }
        }

        /*PROTECTED REGION END*/
}
}
}
