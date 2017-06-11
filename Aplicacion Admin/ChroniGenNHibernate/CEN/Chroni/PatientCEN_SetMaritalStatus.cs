
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Patient_setMaritalStatus) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PatientCEN
{
public void SetMaritalStatus (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum p_maritalStatus)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Patient_setMaritalStatus) ENABLED START*/

        // Write here your custom code...


        PatientCAD patientCAD = new PatientCAD ();
        PatientCEN patientCEN = new PatientCEN (patientCAD);

        if (p_oid > 0) {
                PatientEN patient = patientCEN.ReadOID (p_oid);

                if (patient != null) {
                        if (p_maritalStatus > 0) {
                                patient.MaritalStatus = p_maritalStatus;
                                patientCAD.Modify (patient);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
