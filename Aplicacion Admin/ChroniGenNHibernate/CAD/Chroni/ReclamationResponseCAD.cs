
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
 * Clase ReclamationResponse:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ReclamationResponseCAD : BasicCAD, IReclamationResponseCAD
{
public ReclamationResponseCAD() : base ()
{
}

public ReclamationResponseCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReclamationResponseEN ReadOIDDefault (int identifier
                                             )
{
        ReclamationResponseEN reclamationResponseEN = null;

        try
        {
                SessionInitializeTransaction ();
                reclamationResponseEN = (ReclamationResponseEN)session.Get (typeof(ReclamationResponseEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reclamationResponseEN;
}

public System.Collections.Generic.IList<ReclamationResponseEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReclamationResponseEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReclamationResponseEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReclamationResponseEN>();
                        else
                                result = session.CreateCriteria (typeof(ReclamationResponseEN)).List<ReclamationResponseEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReclamationResponseEN reclamationResponse)
{
        try
        {
                SessionInitializeTransaction ();
                ReclamationResponseEN reclamationResponseEN = (ReclamationResponseEN)session.Load (typeof(ReclamationResponseEN), reclamationResponse.Identifier);

                reclamationResponseEN.Response = reclamationResponse.Response;


                reclamationResponseEN.ActionState = reclamationResponse.ActionState;


                reclamationResponseEN.CreatedDate = reclamationResponse.CreatedDate;


                session.Update (reclamationResponseEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReclamationResponseEN reclamationResponse)
{
        try
        {
                SessionInitializeTransaction ();
                if (reclamationResponse.Reclamation != null) {
                        // Argumento OID y no colección.
                        reclamationResponse.Reclamation = (ChroniGenNHibernate.EN.Chroni.ReclamationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.ReclamationEN), reclamationResponse.Reclamation.Identifier);

                        reclamationResponse.Reclamation.ReclamationResponse
                                = reclamationResponse;
                }

                session.Save (reclamationResponse);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reclamationResponse.Identifier;
}

public void Modify (ReclamationResponseEN reclamationResponse)
{
        try
        {
                SessionInitializeTransaction ();
                ReclamationResponseEN reclamationResponseEN = (ReclamationResponseEN)session.Load (typeof(ReclamationResponseEN), reclamationResponse.Identifier);

                reclamationResponseEN.Response = reclamationResponse.Response;


                reclamationResponseEN.ActionState = reclamationResponse.ActionState;


                reclamationResponseEN.CreatedDate = reclamationResponse.CreatedDate;

                session.Update (reclamationResponseEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
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
                ReclamationResponseEN reclamationResponseEN = (ReclamationResponseEN)session.Load (typeof(ReclamationResponseEN), identifier);
                session.Delete (reclamationResponseEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ReclamationResponseEN
public ReclamationResponseEN ReadOID (int identifier
                                      )
{
        ReclamationResponseEN reclamationResponseEN = null;

        try
        {
                SessionInitializeTransaction ();
                reclamationResponseEN = (ReclamationResponseEN)session.Get (typeof(ReclamationResponseEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reclamationResponseEN;
}

public System.Collections.Generic.IList<ReclamationResponseEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReclamationResponseEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReclamationResponseEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReclamationResponseEN>();
                else
                        result = session.CreateCriteria (typeof(ReclamationResponseEN)).List<ReclamationResponseEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponsesByInterval (Nullable<DateTime> p_createdDateFrom, Nullable<DateTime> p_createdDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationResponseEN self where FROM ReclamationResponseEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationResponseENgetReclamationResponsesByIntervalHQL");
                query.SetParameter ("p_createdDateFrom", p_createdDateFrom);
                query.SetParameter ("p_createdDateTo", p_createdDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponsesByActionState_Interval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum? p_actionState, Nullable<DateTime> p_createdDateFrom, Nullable<DateTime> p_createdDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationResponseEN self where FROM ReclamationResponseEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationResponseENgetReclamationResponsesByActionState_IntervalHQL");
                query.SetParameter ("p_actionState", p_actionState);
                query.SetParameter ("p_createdDateFrom", p_createdDateFrom);
                query.SetParameter ("p_createdDateTo", p_createdDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponseByReclamation (int p_Reclamation_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationResponseEN self where FROM ReclamationResponseEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationResponseENgetReclamationResponseByReclamationHQL");
                query.SetParameter ("p_Reclamation_OID", p_Reclamation_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationResponseCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
