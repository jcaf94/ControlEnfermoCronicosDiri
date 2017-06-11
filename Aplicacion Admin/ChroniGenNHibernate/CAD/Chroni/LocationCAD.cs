
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
 * Clase Location:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class LocationCAD : BasicCAD, ILocationCAD
{
public LocationCAD() : base ()
{
}

public LocationCAD(ISession sessionAux) : base (sessionAux)
{
}



public LocationEN ReadOIDDefault (int identifier
                                  )
{
        LocationEN locationEN = null;

        try
        {
                SessionInitializeTransaction ();
                locationEN = (LocationEN)session.Get (typeof(LocationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return locationEN;
}

public System.Collections.Generic.IList<LocationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LocationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LocationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LocationEN>();
                        else
                                result = session.CreateCriteria (typeof(LocationEN)).List<LocationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LocationEN location)
{
        try
        {
                SessionInitializeTransaction ();
                LocationEN locationEN = (LocationEN)session.Load (typeof(LocationEN), location.Identifier);

                locationEN.Status = location.Status;


                locationEN.Name = location.Name;


                locationEN.Description = location.Description;


                locationEN.Mode = location.Mode;


                locationEN.Type = location.Type;


                locationEN.Address = location.Address;


                locationEN.PhysicalType = location.PhysicalType;


                locationEN.ManagingOrganization = location.ManagingOrganization;





                locationEN.Phone = location.Phone;


                locationEN.Email = location.Email;


                locationEN.PostalCode = location.PostalCode;


                session.Update (locationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LocationEN location)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (location);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return location.Identifier;
}

public void Modify (LocationEN location)
{
        try
        {
                SessionInitializeTransaction ();
                LocationEN locationEN = (LocationEN)session.Load (typeof(LocationEN), location.Identifier);

                locationEN.Status = location.Status;


                locationEN.Name = location.Name;


                locationEN.Description = location.Description;


                locationEN.Mode = location.Mode;


                locationEN.Type = location.Type;


                locationEN.Address = location.Address;


                locationEN.PhysicalType = location.PhysicalType;


                locationEN.ManagingOrganization = location.ManagingOrganization;


                locationEN.Phone = location.Phone;


                locationEN.Email = location.Email;


                locationEN.PostalCode = location.PostalCode;

                session.Update (locationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
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
                LocationEN locationEN = (LocationEN)session.Load (typeof(LocationEN), identifier);
                session.Delete (locationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: LocationEN
public LocationEN ReadOID (int identifier
                           )
{
        LocationEN locationEN = null;

        try
        {
                SessionInitializeTransaction ();
                locationEN = (LocationEN)session.Get (typeof(LocationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return locationEN;
}

public System.Collections.Generic.IList<LocationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LocationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LocationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<LocationEN>();
                else
                        result = session.CreateCriteria (typeof(LocationEN)).List<LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByType (ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum ? p_type)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByTypeHQL");
                query.SetParameter ("p_type", p_type);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByType_Status (ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum? p_type, ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByType_StatusHQL");
                query.SetParameter ("p_type", p_type);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPostalCode (string p_postalCode)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByPostalCodeHQL");
                query.SetParameter ("p_postalCode", p_postalCode);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPractitioner (int p_Practitioner_oid)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByPractitionerHQL");
                query.SetParameter ("p_Practitioner_oid", p_Practitioner_oid);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatient (int p_Patient_oid, string arg1)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByPatientHQL");
                query.SetParameter ("p_Patient_oid", p_Patient_oid);
                query.SetParameter ("arg1", arg1);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPhysicalType (ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum ? p_physicalType)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByPhysicalTypeHQL");
                query.SetParameter ("p_physicalType", p_physicalType);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatientSurnames (string p_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationsByPatientSurnamesHQL");
                query.SetParameter ("p_surnames", p_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationByPosition (int p_Position_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LocationEN self where FROM LocationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LocationENgetLocationByPositionHQL");
                query.SetParameter ("p_Position_OID", p_Position_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignPosition (int p_Location_OID, int p_position_OID)
{
        ChroniGenNHibernate.EN.Chroni.LocationEN locationEN = null;
        try
        {
                SessionInitializeTransaction ();
                locationEN = (LocationEN)session.Load (typeof(LocationEN), p_Location_OID);
                locationEN.Position = (ChroniGenNHibernate.EN.Chroni.PositionEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PositionEN), p_position_OID);

                locationEN.Position.Location = locationEN;




                session.Update (locationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignPosition (int p_Location_OID, int p_position_OID)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.LocationEN locationEN = null;
                locationEN = (LocationEN)session.Load (typeof(LocationEN), p_Location_OID);

                if (locationEN.Position.Identifier == p_position_OID) {
                        locationEN.Position = null;
                        ChroniGenNHibernate.EN.Chroni.PositionEN positionEN = (ChroniGenNHibernate.EN.Chroni.PositionEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PositionEN), p_position_OID);
                        positionEN.Location = null;
                }
                else
                        throw new ModelException ("The identifier " + p_position_OID + " in p_position_OID you are trying to unrelationer, doesn't exist in LocationEN");

                session.Update (locationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in LocationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
