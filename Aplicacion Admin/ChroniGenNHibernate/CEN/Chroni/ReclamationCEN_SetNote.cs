
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Reclamation_setNote) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ReclamationCEN
{
public void SetNote (int p_oid, string p_note)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Reclamation_setNote) ENABLED START*/

        // Write here your custom code...

        ReclamationCAD reclamationCAD = new ReclamationCAD ();
        ReclamationCEN reclamationCEN = new ReclamationCEN (reclamationCAD);

        if (p_oid > 0) {
                ReclamationEN reclamation = reclamationCEN.ReadOID (p_oid);

                if (reclamation != null) {
                        if (!string.IsNullOrEmpty (p_note)) {
                                reclamation.Note = p_note;
                                reclamationCAD.Modify (reclamation);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
