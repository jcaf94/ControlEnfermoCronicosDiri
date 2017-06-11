
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Condition_setNote) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ConditionCEN
{
public void SetNote (int p_oid, string p_note)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Condition_setNote) ENABLED START*/

        // Write here your custom code...

        ConditionCAD conditionCAD = new ConditionCAD ();
        ConditionCEN conditionCEN = new ConditionCEN (conditionCAD);

        if (p_oid > 0) {
                ConditionEN condition = conditionCEN.ReadOID (p_oid);

                if (condition != null) {
                        if (!string.IsNullOrEmpty (p_note)) {
                                condition.Note = p_note;
                                conditionCAD.Modify (condition);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
