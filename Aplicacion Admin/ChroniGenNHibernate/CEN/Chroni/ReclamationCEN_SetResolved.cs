
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Reclamation_setResolved) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ReclamationCEN
{
public void SetResolved (int p_oid, bool p_resolved)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Reclamation_setResolved) ENABLED START*/

        // Write here your custom code...

        ReclamationCAD reclamationCAD = new ReclamationCAD ();
        ReclamationCEN reclamationCEN = new ReclamationCEN (reclamationCAD);

        if (p_oid > 0) {
                ReclamationEN reclamation = reclamationCEN.ReadOID (p_oid);

                if (reclamation != null) {
                        reclamation.Resolved = p_resolved;
                        reclamationCAD.Modify (reclamation);
                }
        }

        /*PROTECTED REGION END*/
}
}
}
