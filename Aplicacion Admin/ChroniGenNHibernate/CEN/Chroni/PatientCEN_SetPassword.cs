
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Patient_setPassword) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PatientCEN
{
public void SetPassword (int p_oid, string p_passwordCurrent, string p_passwordNew)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Patient_setPassword) ENABLED START*/

        // Write here your custom code...

        PatientCAD patientCAD = new PatientCAD ();
        PatientCEN patientCEN = new PatientCEN (patientCAD);

        if (p_oid > 0) {
                PatientEN patient = patientCEN.ReadOID (p_oid);

                if (patient != null) {
                        if (!string.IsNullOrEmpty (p_passwordCurrent) && !string.IsNullOrEmpty (p_passwordNew)) {
                                if (Utils.Util.GetEncondeMD5 (p_passwordCurrent).Equals (patient.Password)) {
                                        patient.Password = Utils.Util.GetEncondeMD5 (p_passwordNew);
                                        patientCAD.Modify (patient);
                                }
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
