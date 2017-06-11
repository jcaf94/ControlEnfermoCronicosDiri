
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Administrator_setPassword) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class AdministratorCEN
{
public void SetPassword (int p_oid, string p_passwordCurrent, string p_passwordNew)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Administrator_setPassword) ENABLED START*/

        // Write here your custom code...

        AdministratorCAD administratorCAD = new AdministratorCAD ();
        AdministratorCEN adminitratorCEN = new AdministratorCEN (administratorCAD);

        if (p_oid > 0) {
                AdministratorEN administrator = adminitratorCEN.ReadOID (p_oid);

                if (administrator != null) {
                        if (!string.IsNullOrEmpty (p_passwordCurrent) && !string.IsNullOrEmpty (p_passwordNew)) {
                                if (Utils.Util.GetEncondeMD5 (p_passwordCurrent).Equals (administrator.Password)) {
                                        administrator.Password = Utils.Util.GetEncondeMD5 (p_passwordNew);
                                        administratorCAD.Modify (administrator);
                                }
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
