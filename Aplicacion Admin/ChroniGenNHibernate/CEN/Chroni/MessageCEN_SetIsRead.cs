
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Message_setIsRead) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class MessageCEN
{
public void SetIsRead (int p_oid, bool p_isRead)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Message_setIsRead) ENABLED START*/

        // Write here your custom code...

        MessageCAD messageCAD = new MessageCAD ();
        MessageCEN messageCEN = new MessageCEN (messageCAD);

        if (p_oid > 0) {
                MessageEN medication = messageCEN.ReadOID (p_oid);

                if (medication != null) {
                        medication.IsRead = p_isRead;
                        messageCAD.Modify (medication);
                }
        }

        /*PROTECTED REGION END*/
}
}
}
