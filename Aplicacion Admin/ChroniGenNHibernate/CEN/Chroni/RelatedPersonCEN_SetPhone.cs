
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_RelatedPerson_setPhone) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class RelatedPersonCEN
{
public void SetPhone (int p_oid, string p_phone)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_RelatedPerson_setPhone) ENABLED START*/

        // Write here your custom code...

        RelatedPersonCAD relatedPersonCAD = new RelatedPersonCAD ();
        RelatedPersonCEN relatedPersonCEN = new RelatedPersonCEN (relatedPersonCAD);

        if (p_oid > 0) {
                RelatedPersonEN relatedPerson = relatedPersonCEN.ReadOID (p_oid);

                if (relatedPerson != null) {
                        if (!string.IsNullOrEmpty (p_phone)) {
                                relatedPerson.Phone = p_phone;
                                relatedPersonCAD.Modify (relatedPerson);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
