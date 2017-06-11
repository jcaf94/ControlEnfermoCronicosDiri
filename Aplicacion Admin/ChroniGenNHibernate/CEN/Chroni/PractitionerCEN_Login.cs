
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Practitioner_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class PractitionerCEN
{
public bool Login (string p_nif, string p_password)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Practitioner_login) ENABLED START*/

        // Write here your custom code...

        bool resultado = false;

        PractitionerCAD practitionerCAD = new PractitionerCAD ();
        PractitionerCEN practitionerCEN = new PractitionerCEN (practitionerCAD);

        if (!string.IsNullOrEmpty (p_nif)) {
                IList<PractitionerEN> practitioner = practitionerCEN.GetPractitionerByNif (p_nif);
                if (practitioner != null && practitioner.Count == 1) {
                        if (!string.IsNullOrEmpty (p_password)) {
                                if (practitioner [0].Password.Equals (Utils.Util.GetEncondeMD5 (p_password))) {
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
