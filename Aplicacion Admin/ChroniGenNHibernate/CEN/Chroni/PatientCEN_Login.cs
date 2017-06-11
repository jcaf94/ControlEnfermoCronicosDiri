
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Patient_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PatientCEN
{
public bool Login (string p_nif, string p_password)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Patient_login) ENABLED START*/

        // Write here your custom code...
        bool resultado = false;

        PatientCAD patientCAD = new PatientCAD ();
        PatientCEN patientCEN = new PatientCEN (patientCAD);

        if (!string.IsNullOrEmpty (p_nif)) {
                IList<PatientEN> patient = patientCEN.GetPatientByNif (p_nif);
                if (patient != null && patient.Count == 1) {
                        if (!string.IsNullOrEmpty (p_password)) {
                                if (patient [0].Password.Equals (Utils.Util.GetEncondeMD5 (p_password))) {
                                        resultado = true;
                                }
                        }
                }
        }


        return resultado;
        /*PROTECTED REGION END*/
}
}
}
