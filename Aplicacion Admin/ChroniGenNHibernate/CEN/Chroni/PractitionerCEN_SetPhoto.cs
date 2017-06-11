
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Practitioner_setPhoto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PractitionerCEN
{
public void SetPhoto (int p_oid, string p_photo)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Practitioner_setPhoto) ENABLED START*/

        // Write here your custom code...

        PractitionerCAD practitionerCAD = new PractitionerCAD ();
        PractitionerCEN practitionerCEN = new PractitionerCEN (practitionerCAD);

        if (p_oid > 0) {
                PractitionerEN practitioner = practitionerCEN.ReadOID (p_oid);

                if (practitioner != null) {
                        if (!string.IsNullOrEmpty (p_photo)) {
                                practitioner.Photo = p_photo;
                                practitionerCAD.Modify (practitioner);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
