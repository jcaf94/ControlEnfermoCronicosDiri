
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IMessageCAD
{
MessageEN ReadOIDDefault (int identifier
                          );

void ModifyDefault (MessageEN message);

System.Collections.Generic.IList<MessageEN> ReadAllDefault (int first, int size);



int New_ (MessageEN message);

void Modify (MessageEN message);


void Destroy (int identifier
              );


MessageEN ReadOID (int identifier
                   );


System.Collections.Generic.IList<MessageEN> ReadAll (int first, int size);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation_isRead (int p_Conversation_OID, bool ? p_isRead);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation_Interval (int p_Conversation_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation ();
}
}
