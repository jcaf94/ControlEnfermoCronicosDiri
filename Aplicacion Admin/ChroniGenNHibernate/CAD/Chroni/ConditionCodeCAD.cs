
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
 * Clase ConditionCode:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ConditionCodeCAD : BasicCAD, IConditionCodeCAD
{
public ConditionCodeCAD() : base ()
{
}

public ConditionCodeCAD(ISession sessionAux) : base (sessionAux)
{
}



public ConditionCodeEN ReadOIDDefault (int identifier
                                       )
{
        ConditionCodeEN conditionCodeEN = null;

        try
        {
                SessionInitializeTransaction ();
                conditionCodeEN = (ConditionCodeEN)session.Get (typeof(ConditionCodeEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conditionCodeEN;
}

public System.Collections.Generic.IList<ConditionCodeEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ConditionCodeEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ConditionCodeEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ConditionCodeEN>();
                        else
                                result = session.CreateCriteria (typeof(ConditionCodeEN)).List<ConditionCodeEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ConditionCodeEN conditionCode)
{
        try
        {
                SessionInitializeTransaction ();
                ConditionCodeEN conditionCodeEN = (ConditionCodeEN)session.Load (typeof(ConditionCodeEN), conditionCode.Identifier);

                conditionCodeEN.Code = conditionCode.Code;


                conditionCodeEN.Display = conditionCode.Display;


                session.Update (conditionCodeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ConditionCodeEN conditionCode)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (conditionCode);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conditionCode.Identifier;
}

public void Modify (ConditionCodeEN conditionCode)
{
        try
        {
                SessionInitializeTransaction ();
                ConditionCodeEN conditionCodeEN = (ConditionCodeEN)session.Load (typeof(ConditionCodeEN), conditionCode.Identifier);

                conditionCodeEN.Code = conditionCode.Code;


                conditionCodeEN.Display = conditionCode.Display;

                session.Update (conditionCodeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
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
                ConditionCodeEN conditionCodeEN = (ConditionCodeEN)session.Load (typeof(ConditionCodeEN), identifier);
                session.Delete (conditionCodeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ConditionCodeEN
public ConditionCodeEN ReadOID (int identifier
                                )
{
        ConditionCodeEN conditionCodeEN = null;

        try
        {
                SessionInitializeTransaction ();
                conditionCodeEN = (ConditionCodeEN)session.Get (typeof(ConditionCodeEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conditionCodeEN;
}

public System.Collections.Generic.IList<ConditionCodeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConditionCodeEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ConditionCodeEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ConditionCodeEN>();
                else
                        result = session.CreateCriteria (typeof(ConditionCodeEN)).List<ConditionCodeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> GetConditionCodeByCode (string p_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConditionCodeEN self where FROM ConditionCodeEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConditionCodeENGetConditionCodeByCodeHQL");
                query.SetParameter ("p_code", p_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> GetConditionCodeByDisplay (string p_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConditionCodeEN self where FROM ConditionCodeEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConditionCodeENGetConditionCodeByDisplayHQL");
                query.SetParameter ("p_display", p_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
