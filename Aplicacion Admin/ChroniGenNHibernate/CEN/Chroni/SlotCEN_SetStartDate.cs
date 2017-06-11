
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Slot_setStartDate) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class SlotCEN
{
public void SetStartDate (int p_oid, Nullable<DateTime> p_startDate)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Slot_setStartDate) ENABLED START*/

        // Write here your custom code...

        SlotCAD slotCAD = new SlotCAD ();
        SlotCEN slotCEN = new SlotCEN (slotCAD);

        if (p_oid > 0) {
                SlotEN slot = slotCEN.ReadOID (p_oid);

                if (slot != null) {
                        if (p_startDate != null && p_startDate < slot.EndDate) {
                                slot.StartDate = p_startDate;
                                slotCAD.Modify (slot);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
