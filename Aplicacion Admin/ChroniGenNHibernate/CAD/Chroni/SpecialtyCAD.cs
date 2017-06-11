
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
 * Clase Specialty:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class SpecialtyCAD : BasicCAD, ISpecialtyCAD
{
public SpecialtyCAD() : base ()
{
}

public SpecialtyCAD(ISession sessionAux) : base (sessionAux)
{
}



public SpecialtyEN ReadOIDDefault (int identifier
                                   )
{
        SpecialtyEN specialtyEN = null;

        try
        {
                SessionInitializeTransaction ();
                specialtyEN = (SpecialtyEN)session.Get (typeof(SpecialtyEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return specialtyEN;
}

public System.Collections.Generic.IList<SpecialtyEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SpecialtyEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SpecialtyEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SpecialtyEN>();
                        else
                                result = session.CreateCriteria (typeof(SpecialtyEN)).List<SpecialtyEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SpecialtyEN specialty)
{
        try
        {
                SessionInitializeTransaction ();
                SpecialtyEN specialtyEN = (SpecialtyEN)session.Load (typeof(SpecialtyEN), specialty.Identifier);

                specialtyEN.Code = specialty.Code;


                specialtyEN.Display = specialty.Display;


                session.Update (specialtyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SpecialtyEN specialty)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (specialty);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return specialty.Identifier;
}

public void Modify (SpecialtyEN specialty)
{
        try
        {
                SessionInitializeTransaction ();
                SpecialtyEN specialtyEN = (SpecialtyEN)session.Load (typeof(SpecialtyEN), specialty.Identifier);

                specialtyEN.Code = specialty.Code;


                specialtyEN.Display = specialty.Display;

                session.Update (specialtyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
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
                SpecialtyEN specialtyEN = (SpecialtyEN)session.Load (typeof(SpecialtyEN), identifier);
                session.Delete (specialtyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SpecialtyEN
public SpecialtyEN ReadOID (int identifier
                            )
{
        SpecialtyEN specialtyEN = null;

        try
        {
                SessionInitializeTransaction ();
                specialtyEN = (SpecialtyEN)session.Get (typeof(SpecialtyEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return specialtyEN;
}

public System.Collections.Generic.IList<SpecialtyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SpecialtyEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SpecialtyEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SpecialtyEN>();
                else
                        result = session.CreateCriteria (typeof(SpecialtyEN)).List<SpecialtyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtyByCode (string p_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SpecialtyEN self where FROM SpecialtyEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SpecialtyENgetSpecialtyByCodeHQL");
                query.SetParameter ("p_code", p_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SpecialtyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtyByDisplay (string p_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SpecialtyEN self where FROM SpecialtyEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SpecialtyENgetSpecialtyByDisplayHQL");
                query.SetParameter ("p_display", p_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SpecialtyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitioner (int p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SpecialtyEN self where FROM SpecialtyEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SpecialtyENgetSpecialtiesByPractitionerHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SpecialtyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitionerNif (string p_Practitioner_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SpecialtyEN self where FROM SpecialtyEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SpecialtyENgetSpecialtiesByPractitionerNifHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SpecialtyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitionerName_Surnames (string p_Practitioner_name, string p_Practitioner_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SpecialtyEN self where FROM SpecialtyEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SpecialtyENgetSpecialtiesByPractitionerName_SurnamesHQL");
                query.SetParameter ("p_Practitioner_name", p_Practitioner_name);
                query.SetParameter ("p_Practitioner_surnames", p_Practitioner_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SpecialtyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByLocationName (string p_Location_name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SpecialtyEN self where FROM SpecialtyEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SpecialtyENgetSpecialtiesByLocationNameHQL");
                query.SetParameter ("p_Location_name", p_Location_name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SpecialtyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SpecialtyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
