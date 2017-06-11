
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
 * Clase Conversation:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ConversationCAD : BasicCAD, IConversationCAD
{
public ConversationCAD() : base ()
{
}

public ConversationCAD(ISession sessionAux) : base (sessionAux)
{
}



public ConversationEN ReadOIDDefault (int identifier
                                      )
{
        ConversationEN conversationEN = null;

        try
        {
                SessionInitializeTransaction ();
                conversationEN = (ConversationEN)session.Get (typeof(ConversationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conversationEN;
}

public System.Collections.Generic.IList<ConversationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ConversationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ConversationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ConversationEN>();
                        else
                                result = session.CreateCriteria (typeof(ConversationEN)).List<ConversationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ConversationEN conversation)
{
        try
        {
                SessionInitializeTransaction ();
                ConversationEN conversationEN = (ConversationEN)session.Load (typeof(ConversationEN), conversation.Identifier);

                conversationEN.StartDate = conversation.StartDate;





                session.Update (conversationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ConversationEN conversation)
{
        try
        {
                SessionInitializeTransaction ();
                if (conversation.Message != null) {
                        foreach (ChroniGenNHibernate.EN.Chroni.MessageEN item in conversation.Message) {
                                item.Conversation = conversation;
                                session.Save (item);
                        }
                }
                if (conversation.Practitioner != null) {
                        // Argumento OID y no colección.
                        conversation.Practitioner = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), conversation.Practitioner.Identifier);

                        conversation.Practitioner.Conversation
                        .Add (conversation);
                }

                session.Save (conversation);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conversation.Identifier;
}

public void Modify (ConversationEN conversation)
{
        try
        {
                SessionInitializeTransaction ();
                ConversationEN conversationEN = (ConversationEN)session.Load (typeof(ConversationEN), conversation.Identifier);

                conversationEN.StartDate = conversation.StartDate;

                session.Update (conversationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
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
                ConversationEN conversationEN = (ConversationEN)session.Load (typeof(ConversationEN), identifier);
                session.Delete (conversationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ConversationEN
public ConversationEN ReadOID (int identifier
                               )
{
        ConversationEN conversationEN = null;

        try
        {
                SessionInitializeTransaction ();
                conversationEN = (ConversationEN)session.Get (typeof(ConversationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conversationEN;
}

public System.Collections.Generic.IList<ConversationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConversationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ConversationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ConversationEN>();
                else
                        result = session.CreateCriteria (typeof(ConversationEN)).List<ConversationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPatient (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConversationEN self where FROM ConversationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConversationENgetConversationByPatientHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConversationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPractitioner (int p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConversationEN self where FROM ConversationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConversationENgetConversationByPractitionerHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConversationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByRelatedPerson (int p_RelatedPerson_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConversationEN self where FROM ConversationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConversationENgetConversationByRelatedPersonHQL");
                query.SetParameter ("p_RelatedPerson_OID", p_RelatedPerson_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConversationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignPatient (int p_Conversation_OID, int p_patient_OID)
{
        ChroniGenNHibernate.EN.Chroni.ConversationEN conversationEN = null;
        try
        {
                SessionInitializeTransaction ();
                conversationEN = (ConversationEN)session.Load (typeof(ConversationEN), p_Conversation_OID);
                conversationEN.Patient = (ChroniGenNHibernate.EN.Chroni.PatientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PatientEN), p_patient_OID);

                conversationEN.Patient.Conversation.Add (conversationEN);



                session.Update (conversationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AssignRelatedPerson (int p_Conversation_OID, int p_relatedPerson_OID)
{
        ChroniGenNHibernate.EN.Chroni.ConversationEN conversationEN = null;
        try
        {
                SessionInitializeTransaction ();
                conversationEN = (ConversationEN)session.Load (typeof(ConversationEN), p_Conversation_OID);
                conversationEN.RelatedPerson = (ChroniGenNHibernate.EN.Chroni.RelatedPersonEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.RelatedPersonEN), p_relatedPerson_OID);

                conversationEN.RelatedPerson.Conversation.Add (conversationEN);



                session.Update (conversationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> GetConversationByPatientNif ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConversationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConversationEN self where FROM ConversationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConversationENgetConversationByPatientNifHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConversationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConversationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
