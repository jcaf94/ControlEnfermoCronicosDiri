
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Administrator_setGender) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class AdministratorCEN
{
public void SetGender (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Administrator_setGender) ENABLED START*/

        // Write here your custom code...

        AdministratorCAD administratorCAD = new AdministratorCAD ();
        AdministratorCEN adminitratorCEN = new AdministratorCEN (administratorCAD);

        if (p_oid > 0) {
                AdministratorEN administrator = adminitratorCEN.ReadOID (p_oid);

                if (administrator != null) {
                        if (p_gender > 0) {
                                administrator.Gender = p_gender;
                                administratorCAD.Modify (administrator);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
