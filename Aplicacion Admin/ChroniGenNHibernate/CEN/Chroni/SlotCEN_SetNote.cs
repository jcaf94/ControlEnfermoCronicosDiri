
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Slot_setNote) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class SlotCEN
{
public void SetNote (int p_oid, string p_note)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Slot_setNote) ENABLED START*/

        // Write here your custom code...

        SlotCAD slotCAD = new SlotCAD ();
        SlotCEN slotCEN = new SlotCEN (slotCAD);

        if (p_oid > 0) {
                SlotEN slot = slotCEN.ReadOID (p_oid);

                if (slot != null) {
                        if (!string.IsNullOrEmpty (p_note)) {
                                slot.Note = p_note;
                                slotCAD.Modify (slot);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
