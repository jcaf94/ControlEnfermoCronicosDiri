
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Administrator_setBirthDate) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class AdministratorCEN
{
public void SetBirthDate (int p_oid, Nullable<DateTime> p_birthDate)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Administrator_setBirthDate) ENABLED START*/

        // Write here your custom code...

        AdministratorCAD administratorCAD = new AdministratorCAD ();
        AdministratorCEN adminitratorCEN = new AdministratorCEN (administratorCAD);

        if (p_oid > 0) {
                AdministratorEN administrator = adminitratorCEN.ReadOID (p_oid);

                if (administrator != null) {
                        if (p_birthDate != null) {
                                administrator.BirthDate = p_birthDate;
                                administratorCAD.Modify (administrator);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
