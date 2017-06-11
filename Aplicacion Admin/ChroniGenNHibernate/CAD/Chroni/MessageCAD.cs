
using System;
using System.Text;
using ChroniGenNHibernate.CEN.Chroni;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.Exceptions;


/*
 * Clase Message:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class MessageCAD : BasicCAD, IMessageCAD
{
public MessageCAD() : base ()
{
}

public MessageCAD(ISession sessionAux) : base (sessionAux)
{
}



public MessageEN ReadOIDDefault (int identifier
                                 )
{
        MessageEN messageEN = null;

        try
        {
                SessionInitializeTransaction ();
                messageEN = (MessageEN)session.Get (typeof(MessageEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return messageEN;
}

public System.Collections.Generic.IList<MessageEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MessageEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MessageEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MessageEN>();
                        else
                                result = session.CreateCriteria (typeof(MessageEN)).List<MessageEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MessageEN message)
{
        try
        {
                SessionInitializeTransaction ();
                MessageEN messageEN = (MessageEN)session.Load (typeof(MessageEN), message.Identifier);

                messageEN.Date = message.Date;


                messageEN.Content = message.Content;


                messageEN.IsRead = message.IsRead;



                messageEN.Attachment = message.Attachment;

                session.Update (messageEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MessageEN message)
{
        try
        {
                SessionInitializeTransaction ();
                if (message.Conversation != null) {
                        // Argumento OID y no colección.
                        message.Conversation = (ChroniGenNHibernate.EN.Chroni.ConversationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.ConversationEN), message.Conversation.Identifier);

                        message.Conversation.Message
                        .Add (message);
                }

                session.Save (message);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return message.Identifier;
}

public void Modify (MessageEN message)
{
        try
        {
                SessionInitializeTransaction ();
                MessageEN messageEN = (MessageEN)session.Load (typeof(MessageEN), message.Identifier);

                messageEN.Date = message.Date;


                messageEN.Content = message.Content;


                messageEN.IsRead = message.IsRead;


                messageEN.Attachment = message.Attachment;

                session.Update (messageEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int identifier
                     )
{
        try
        {
                SessionInitializeTransaction ();
                MessageEN messageEN = (MessageEN)session.Load (typeof(MessageEN), identifier);
                session.Delete (messageEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MessageEN
public MessageEN ReadOID (int identifier
                          )
{
        MessageEN messageEN = null;

        try
        {
                SessionInitializeTransaction ();
                messageEN = (MessageEN)session.Get (typeof(MessageEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return messageEN;
}

public System.Collections.Generic.IList<MessageEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MessageEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MessageEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MessageEN>();
                else
                        result = session.CreateCriteria (typeof(MessageEN)).List<MessageEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation_isRead (int p_Conversation_OID, bool ? p_isRead)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MessageEN self where FROM MessageEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MessageENgetMessagesByConversation_isReadHQL");
                query.SetParameter ("p_Conversation_OID", p_Conversation_OID);
                query.SetParameter ("p_isRead", p_isRead);

                result = query.List<ChroniGenNHibernate.EN.Chroni.MessageEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation_Interval (int p_Conversation_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MessageEN self where FROM MessageEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MessageENgetMessagesByConversation_IntervalHQL");
                query.SetParameter ("p_Conversation_OID", p_Conversation_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.MessageEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> GetMessagesByConversation ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MessageEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MessageEN self where FROM MessageEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MessageENgetMessagesByConversationHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.MessageEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MessageCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
