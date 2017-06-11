
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
 * Clase Position:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class PositionCAD : BasicCAD, IPositionCAD
{
public PositionCAD() : base ()
{
}

public PositionCAD(ISession sessionAux) : base (sessionAux)
{
}



public PositionEN ReadOIDDefault (int identifier
                                  )
{
        PositionEN positionEN = null;

        try
        {
                SessionInitializeTransaction ();
                positionEN = (PositionEN)session.Get (typeof(PositionEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return positionEN;
}

public System.Collections.Generic.IList<PositionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PositionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PositionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PositionEN>();
                        else
                                result = session.CreateCriteria (typeof(PositionEN)).List<PositionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PositionEN position)
{
        try
        {
                SessionInitializeTransaction ();
                PositionEN positionEN = (PositionEN)session.Load (typeof(PositionEN), position.Identifier);

                positionEN.Latitude = position.Latitude;


                positionEN.Longitude = position.Longitude;


                positionEN.Altitude = position.Altitude;


                session.Update (positionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PositionEN position)
{
        try
        {
                SessionInitializeTransaction ();
                if (position.Location != null) {
                        // Argumento OID y no colección.
                        position.Location = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), position.Location.Identifier);

                        position.Location.Position
                                = position;
                }

                session.Save (position);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return position.Identifier;
}

public void Modify (PositionEN position)
{
        try
        {
                SessionInitializeTransaction ();
                PositionEN positionEN = (PositionEN)session.Load (typeof(PositionEN), position.Identifier);

                positionEN.Latitude = position.Latitude;


                positionEN.Longitude = position.Longitude;


                positionEN.Altitude = position.Altitude;

                session.Update (positionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
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
                PositionEN positionEN = (PositionEN)session.Load (typeof(PositionEN), identifier);
                session.Delete (positionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PositionEN
public PositionEN ReadOID (int identifier
                           )
{
        PositionEN positionEN = null;

        try
        {
                SessionInitializeTransaction ();
                positionEN = (PositionEN)session.Get (typeof(PositionEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return positionEN;
}

public System.Collections.Generic.IList<PositionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PositionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PositionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PositionEN>();
                else
                        result = session.CreateCriteria (typeof(PositionEN)).List<PositionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionByLocation (int p_Location_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PositionEN self where FROM PositionEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PositionENgetPositionByLocationHQL");
                query.SetParameter ("p_Location_OID", p_Location_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PositionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionByLocationName (string p_Location_name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PositionEN self where FROM PositionEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PositionENgetPositionByLocationNameHQL");
                query.SetParameter ("p_Location_name", p_Location_name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PositionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionsByLocationPostalCode (string p_Location_postalCode)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PositionEN self where FROM PositionEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PositionENgetPositionsByLocationPostalCodeHQL");
                query.SetParameter ("p_Location_postalCode", p_Location_postalCode);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PositionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PositionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
