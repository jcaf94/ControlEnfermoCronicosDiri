
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Goal_setStatus) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class GoalCEN
{
public void SetStatus (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum p_status)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Goal_setStatus) ENABLED START*/

        // Write here your custom code...

        GoalCAD goalCAD = new GoalCAD ();
        GoalCEN goalCEN = new GoalCEN (goalCAD);

        if (p_oid > 0) {
                GoalEN goal = goalCEN.ReadOID (p_oid);

                if (goal != null) {
                        if (p_status > 0) {
                                goal.Status = p_status;
                                goalCAD.Modify (goal);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
