
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Encounter_setStatus) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class EncounterCEN
{
public void SetStatus (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum p_status)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Encounter_setStatus) ENABLED START*/

        // Write here your custom code...

        EncounterCAD encounterCAD = new EncounterCAD ();
        EncounterCEN encounterCEN = new EncounterCEN (encounterCAD);

        if (p_oid > 0) {
                EncounterEN encounter = encounterCEN.ReadOID (p_oid);

                if (encounter != null) {
                        if (p_status > 0) {
                                encounter.Status = p_status;
                                encounterCAD.Modify (encounter);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
