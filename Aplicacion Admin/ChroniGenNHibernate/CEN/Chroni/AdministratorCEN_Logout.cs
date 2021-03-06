
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Administrator_logout) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class AdministratorCEN
{
public bool Logout (int p_oid)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Administrator_logout) ENABLED START*/

        // Write here your custom code...

        AdministratorCAD administratorCAD = new AdministratorCAD ();
        AdministratorCEN administratorCEN = new AdministratorCEN (administratorCAD);

        if (p_oid > 0) {
                AdministratorEN administrator = administratorCEN.ReadOID (p_oid);

                if (administrator != null) {
                        return true;
                }
        }

        return false;
        /*PROTECTED REGION END*/
}
}
}
