
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
 * Clase SubstanceCode:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class SubstanceCodeCAD : BasicCAD, ISubstanceCodeCAD
{
public SubstanceCodeCAD() : base ()
{
}

public SubstanceCodeCAD(ISession sessionAux) : base (sessionAux)
{
}



public SubstanceCodeEN ReadOIDDefault (int identifier
                                       )
{
        SubstanceCodeEN substanceCodeEN = null;

        try
        {
                SessionInitializeTransaction ();
                substanceCodeEN = (SubstanceCodeEN)session.Get (typeof(SubstanceCodeEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return substanceCodeEN;
}

public System.Collections.Generic.IList<SubstanceCodeEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SubstanceCodeEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SubstanceCodeEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SubstanceCodeEN>();
                        else
                                result = session.CreateCriteria (typeof(SubstanceCodeEN)).List<SubstanceCodeEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SubstanceCodeEN substanceCode)
{
        try
        {
                SessionInitializeTransaction ();
                SubstanceCodeEN substanceCodeEN = (SubstanceCodeEN)session.Load (typeof(SubstanceCodeEN), substanceCode.Identifier);

                substanceCodeEN.Code = substanceCode.Code;


                substanceCodeEN.Display = substanceCode.Display;


                session.Update (substanceCodeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SubstanceCodeEN substanceCode)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (substanceCode);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return substanceCode.Identifier;
}

public void Modify (SubstanceCodeEN substanceCode)
{
        try
        {
                SessionInitializeTransaction ();
                SubstanceCodeEN substanceCodeEN = (SubstanceCodeEN)session.Load (typeof(SubstanceCodeEN), substanceCode.Identifier);

                substanceCodeEN.Code = substanceCode.Code;


                substanceCodeEN.Display = substanceCode.Display;

                session.Update (substanceCodeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
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
                SubstanceCodeEN substanceCodeEN = (SubstanceCodeEN)session.Load (typeof(SubstanceCodeEN), identifier);
                session.Delete (substanceCodeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SubstanceCodeEN
public SubstanceCodeEN ReadOID (int identifier
                                )
{
        SubstanceCodeEN substanceCodeEN = null;

        try
        {
                SessionInitializeTransaction ();
                substanceCodeEN = (SubstanceCodeEN)session.Get (typeof(SubstanceCodeEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return substanceCodeEN;
}

public System.Collections.Generic.IList<SubstanceCodeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SubstanceCodeEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SubstanceCodeEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SubstanceCodeEN>();
                else
                        result = session.CreateCriteria (typeof(SubstanceCodeEN)).List<SubstanceCodeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> GetSubstanceCodeByCode (string p_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SubstanceCodeEN self where FROM SubstanceCodeEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SubstanceCodeENgetSubstanceCodeByCodeHQL");
                query.SetParameter ("p_code", p_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> GetSubstanceCodeByDisplay (string p_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SubstanceCodeEN self where FROM SubstanceCodeEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SubstanceCodeENgetSubstanceCodeByDisplayHQL");
                query.SetParameter ("p_display", p_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SubstanceCodeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
