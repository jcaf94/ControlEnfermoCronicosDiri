
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Administrator_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class AdministratorCEN
{
public int Login (string p_nif, String p_password)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Administrator_login) ENABLED START*/

        // Write here your custom code...

        // Write here your custom code...
        int resultado = -1;

        AdministratorCAD administratorCAD = new AdministratorCAD ();
        AdministratorCEN administratorCEN = new AdministratorCEN (administratorCAD);

        if (!string.IsNullOrEmpty (p_nif)) {
                IList<AdministratorEN> admin = administratorCEN.GetAdministratorByNif (p_nif);
                if (admin != null && admin.Count == 1) {
                        if (!string.IsNullOrEmpty (p_password)) {
                                if (admin [0].Password.Equals (Utils.Util.GetEncondeMD5 (p_password))) {
                                        resultado = admin [0].Identifier;
                                }
                        }
                }
        }

        return resultado;
        /*PROTECTED REGION END*/
}
}
}
