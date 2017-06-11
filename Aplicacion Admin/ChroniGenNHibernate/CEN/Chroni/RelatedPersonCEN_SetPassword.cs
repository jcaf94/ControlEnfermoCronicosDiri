
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_RelatedPerson_setPassword) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class RelatedPersonCEN
{
public void SetPassword (int p_oid, string p_passwordCurrent, string p_passwordNew)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_RelatedPerson_setPassword) ENABLED START*/

        // Write here your custom code...

        RelatedPersonCAD relatedPersonCAD = new RelatedPersonCAD ();
        RelatedPersonCEN relatedPersonCEN = new RelatedPersonCEN (relatedPersonCAD);

        if (p_oid > 0) {
                RelatedPersonEN relatedPerson = relatedPersonCEN.ReadOID (p_oid);

                if (relatedPerson != null) {
                        if (!string.IsNullOrEmpty (p_passwordCurrent) && !string.IsNullOrEmpty (p_passwordNew)) {
                                if (Utils.Util.GetEncondeMD5 (p_passwordCurrent).Equals (relatedPerson.Password)) {
                                        relatedPerson.Password = Utils.Util.GetEncondeMD5 (p_passwordNew);
                                        relatedPersonCAD.Modify (relatedPerson);
                                }
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
