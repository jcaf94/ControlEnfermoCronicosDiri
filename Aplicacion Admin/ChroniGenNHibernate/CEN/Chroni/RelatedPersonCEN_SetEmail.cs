
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_RelatedPerson_setEmail) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class RelatedPersonCEN
{
public void SetEmail (int p_oid, string p_email)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_RelatedPerson_setEmail) ENABLED START*/

        // Write here your custom code...

        RelatedPersonCAD relatedPersonCAD = new RelatedPersonCAD ();
        RelatedPersonCEN relatedPersonCEN = new RelatedPersonCEN (relatedPersonCAD);

        if (p_oid > 0) {
                RelatedPersonEN relatedPerson = relatedPersonCEN.ReadOID (p_oid);

                if (relatedPerson != null) {
                        if (!string.IsNullOrEmpty (p_email)) {
                                relatedPerson.Email = p_email;
                                relatedPersonCAD.Modify (relatedPerson);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
