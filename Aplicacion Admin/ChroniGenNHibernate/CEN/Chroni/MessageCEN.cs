

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;

using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


namespace ChroniGenNHibernate.CEN.Chroni
{
/*
 *      Definition of the class MessageCEN
 *
 */
public partial class MessageCEN
{
private IMessageCAD _IMessageCAD;

public MessageCEN()
{
        this._IMessageCAD = new MessageCAD ();
}

public MessageCEN(IMessageCAD _IMessageCAD)
{
        this._IMessageCAD = _IMessageCAD;
}

public IMessageCAD get_IMessageCAD ()
{
        return this._IMessageCAD;
}

public int New_ (Nullable<DateTime> p_date, string p_content, bool p_isRead, int p_conversation, string p_attachment)
{
        MessageEN messageEN = null;
        int oid;

        //Initialized MessageEN
        messageEN = new MessageEN ();
        messageEN.Date = p_date;

        messageEN.Content = p_content;

        messageEN.IsRead = p_isRead;


        if (p_conversation != -1) {
                // El argumento p_conversation -> Property conversation es oid = false
                // Lista de oids identifier
                messageEN.Conversation = new ChroniGenNHibernate.EN.Chroni.ConversationEN ();
                messageEN.Conversation.Identifier = p_conversation;
        }

        messageEN.Attachment = p_attachment;

        //Call to MessageCAD

        oid = _IMessageCAD.New_ (messageEN);
        return oid;
}

public void Modify (int p_Message_OID, Nullable<DateTime> p_date, string p_content, bool p_isRead, string p_attachment)
{
        MessageEN messageEN = null;

        //Initialized MessageEN
        messageEN = new MessageEN ();
        messageEN.Identifier = p_Message_OID;
        messageEN.Date = p_date;
        messageEN.Content = p_content;
        messageEN.IsRead = p_isRead;
        messageEN.Attachment = p_attachment;
        //Call to MessageCAD

        _IMessageCAD.Modify (messageEN);
}

public void Destroy (int identifier
                     )
{
        _IMessageCAD.Destroy (identifier);
}

public MessageEN ReadOID (int identifier
                          )
{
        MessageEN messageEN = null;

        messageEN = _IMessageCAD.ReadOID (identifier);
        return messageEN;
}

public System.Collections.Generic.IList<MessageEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MessageEN> list = null;

        list = _IMessageCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation_isRead (int p_Conversation_OID, bool ? p_isRead)
{
        return _IMessageCAD.GetMessagesByConversation_isRead (p_Conversation_OID, p_isRead);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation_Interval (int p_Conversation_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IMessageCAD.GetMessagesByConversation_Interval (p_Conversation_OID, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation ()
{
        return _IMessageCAD.GetMessagesByConversation ();
}
}
}
