
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
 * Clase Administrator:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class AdministratorCAD : BasicCAD, IAdministratorCAD
{
public AdministratorCAD() : base ()
{
}

public AdministratorCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdministratorEN ReadOIDDefault (int identifier
                                       )
{
        AdministratorEN administratorEN = null;

        try
        {
                SessionInitializeTransaction ();
                administratorEN = (AdministratorEN)session.Get (typeof(AdministratorEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administratorEN;
}

public System.Collections.Generic.IList<AdministratorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AdministratorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdministratorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdministratorEN>();
                        else
                                result = session.CreateCriteria (typeof(AdministratorEN)).List<AdministratorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AdministratorEN administrator)
{
        try
        {
                SessionInitializeTransaction ();
                AdministratorEN administratorEN = (AdministratorEN)session.Load (typeof(AdministratorEN), administrator.Identifier);

                administratorEN.Name = administrator.Name;


                administratorEN.Gender = administrator.Gender;


                administratorEN.BirthDate = administrator.BirthDate;


                administratorEN.Photo = administrator.Photo;


                administratorEN.Email = administrator.Email;


                administratorEN.Password = administrator.Password;


                administratorEN.Surnames = administrator.Surnames;


                administratorEN.Nif = administrator.Nif;


                administratorEN.Address = administrator.Address;


                administratorEN.Phone = administrator.Phone;

                session.Update (administratorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AdministratorEN administrator)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (administrator);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administrator.Identifier;
}

public void Modify (AdministratorEN administrator)
{
        try
        {
                SessionInitializeTransaction ();
                AdministratorEN administratorEN = (AdministratorEN)session.Load (typeof(AdministratorEN), administrator.Identifier);

                administratorEN.Name = administrator.Name;


                administratorEN.Gender = administrator.Gender;


                administratorEN.BirthDate = administrator.BirthDate;


                administratorEN.Photo = administrator.Photo;


                administratorEN.Email = administrator.Email;


                administratorEN.Password = administrator.Password;


                administratorEN.Surnames = administrator.Surnames;


                administratorEN.Nif = administrator.Nif;


                administratorEN.Address = administrator.Address;


                administratorEN.Phone = administrator.Phone;

                session.Update (administratorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
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
                AdministratorEN administratorEN = (AdministratorEN)session.Load (typeof(AdministratorEN), identifier);
                session.Delete (administratorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AdministratorEN
public AdministratorEN ReadOID (int identifier
                                )
{
        AdministratorEN administratorEN = null;

        try
        {
                SessionInitializeTransaction ();
                administratorEN = (AdministratorEN)session.Get (typeof(AdministratorEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return administratorEN;
}

public System.Collections.Generic.IList<AdministratorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministratorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdministratorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdministratorEN>();
                else
                        result = session.CreateCriteria (typeof(AdministratorEN)).List<AdministratorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorByNif (string p_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AdministratorEN self where FROM AdministratorEN adm WHERE adm.Nif = :p_nif";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AdministratorENgetAdministratorByNifHQL");
                query.SetParameter ("p_nif", p_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.AdministratorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsBySurnames (string p_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AdministratorEN self where FROM AdministratorEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AdministratorENgetAdministratorsBySurnamesHQL");
                query.SetParameter ("p_surnames", p_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.AdministratorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByNames_Surnames (string p_name, string p_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AdministratorEN self where FROM AdministratorEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AdministratorENgetAdministratorsByNames_SurnamesHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_surnames", p_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.AdministratorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByPhone (string p_phone)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AdministratorEN self where FROM AdministratorEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AdministratorENgetAdministratorsByPhoneHQL");
                query.SetParameter ("p_phone", p_phone);

                result = query.List<ChroniGenNHibernate.EN.Chroni.AdministratorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByEmail (string p_email)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AdministratorEN self where FROM AdministratorEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AdministratorENgetAdministratorsByEmailHQL");
                query.SetParameter ("p_email", p_email);

                result = query.List<ChroniGenNHibernate.EN.Chroni.AdministratorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AdministratorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
