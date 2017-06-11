
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Patient_setPhone) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PatientCEN
{
public void SetPhone (int p_oid, string p_phone)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Patient_setPhone) ENABLED START*/

        // Write here your custom code...

        PatientCAD patientCAD = new PatientCAD ();
        PatientCEN patientCEN = new PatientCEN (patientCAD);

        if (p_oid > 0) {
                PatientEN patient = patientCEN.ReadOID (p_oid);

                if (patient != null) {
                        if (!string.IsNullOrEmpty (p_phone)) {
                                patient.Phone = p_phone;
                                patientCAD.Modify (patient);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
