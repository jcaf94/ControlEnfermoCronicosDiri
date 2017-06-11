
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
 * Clase Practitioner:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class PractitionerCAD : BasicCAD, IPractitionerCAD
{
public PractitionerCAD() : base ()
{
}

public PractitionerCAD(ISession sessionAux) : base (sessionAux)
{
}



public PractitionerEN ReadOIDDefault (int identifier
                                      )
{
        PractitionerEN practitionerEN = null;

        try
        {
                SessionInitializeTransaction ();
                practitionerEN = (PractitionerEN)session.Get (typeof(PractitionerEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return practitionerEN;
}

public System.Collections.Generic.IList<PractitionerEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PractitionerEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PractitionerEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PractitionerEN>();
                        else
                                result = session.CreateCriteria (typeof(PractitionerEN)).List<PractitionerEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PractitionerEN practitioner)
{
        try
        {
                SessionInitializeTransaction ();
                PractitionerEN practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), practitioner.Identifier);

                practitionerEN.Nif = practitioner.Nif;


                practitionerEN.Active = practitioner.Active;


                practitionerEN.Role = practitioner.Role;


                practitionerEN.Name = practitioner.Name;


                practitionerEN.Surnames = practitioner.Surnames;


                practitionerEN.Gender = practitioner.Gender;


                practitionerEN.BirthDate = practitioner.BirthDate;


                practitionerEN.Address = practitioner.Address;


                practitionerEN.Email = practitioner.Email;


                practitionerEN.Phone = practitioner.Phone;


                practitionerEN.Photo = practitioner.Photo;


                practitionerEN.StartDate = practitioner.StartDate;


                practitionerEN.EndDate = practitioner.EndDate;








                practitionerEN.Password = practitioner.Password;




                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PractitionerEN practitioner)
{
        try
        {
                SessionInitializeTransaction ();
                if (practitioner.Location != null) {
                        for (int i = 0; i < practitioner.Location.Count; i++) {
                                practitioner.Location [i] = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), practitioner.Location [i].Identifier);
                                practitioner.Location [i].Practitioner.Add (practitioner);
                        }
                }

                session.Save (practitioner);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return practitioner.Identifier;
}

public void Modify (PractitionerEN practitioner)
{
        try
        {
                SessionInitializeTransaction ();
                PractitionerEN practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), practitioner.Identifier);

                practitionerEN.Nif = practitioner.Nif;


                practitionerEN.Active = practitioner.Active;


                practitionerEN.Role = practitioner.Role;


                practitionerEN.Name = practitioner.Name;


                practitionerEN.Surnames = practitioner.Surnames;


                practitionerEN.Gender = practitioner.Gender;


                practitionerEN.BirthDate = practitioner.BirthDate;


                practitionerEN.Address = practitioner.Address;


                practitionerEN.Email = practitioner.Email;


                practitionerEN.Phone = practitioner.Phone;


                practitionerEN.Photo = practitioner.Photo;


                practitionerEN.StartDate = practitioner.StartDate;


                practitionerEN.EndDate = practitioner.EndDate;


                practitionerEN.Password = practitioner.Password;

                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
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
                PractitionerEN practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), identifier);
                session.Delete (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PractitionerEN
public PractitionerEN ReadOID (int identifier
                               )
{
        PractitionerEN practitionerEN = null;

        try
        {
                SessionInitializeTransaction ();
                practitionerEN = (PractitionerEN)session.Get (typeof(PractitionerEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return practitionerEN;
}

public System.Collections.Generic.IList<PractitionerEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PractitionerEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PractitionerEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PractitionerEN>();
                else
                        result = session.CreateCriteria (typeof(PractitionerEN)).List<PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByRole_Location (ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum? p_role, int p_location)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByRole_LocationHQL");
                query.SetParameter ("p_role", p_role);
                query.SetParameter ("p_location", p_location);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByActive_Location (bool? p_active, int p_Location_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByActive_LocationHQL");
                query.SetParameter ("p_active", p_active);
                query.SetParameter ("p_Location_OID", p_Location_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByName_Surname_Location (string p_name, int p_Location_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByName_Surname_LocationHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_Location_OID", p_Location_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignLocation (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerEN = null;
        try
        {
                SessionInitializeTransaction ();
                practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), p_Practitioner_OID);
                ChroniGenNHibernate.EN.Chroni.LocationEN locationENAux = null;
                if (practitionerEN.Location == null) {
                        practitionerEN.Location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                }

                foreach (int item in p_location_OIDs) {
                        locationENAux = new ChroniGenNHibernate.EN.Chroni.LocationEN ();
                        locationENAux = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), item);
                        locationENAux.Practitioner.Add (practitionerEN);

                        practitionerEN.Location.Add (locationENAux);
                }


                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignLocation (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerEN = null;
                practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), p_Practitioner_OID);

                ChroniGenNHibernate.EN.Chroni.LocationEN locationENAux = null;
                if (practitionerEN.Location != null) {
                        foreach (int item in p_location_OIDs) {
                                locationENAux = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), item);
                                if (practitionerEN.Location.Contains (locationENAux) == true) {
                                        practitionerEN.Location.Remove (locationENAux);
                                        locationENAux.Practitioner.Remove (practitionerEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_location_OIDs you are trying to unrelationer, doesn't exist in PractitionerEN");
                        }
                }

                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignSpecialty (int p_Practitioner_OID, int p_specialty_OID)
{
        ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerEN = null;
        try
        {
                SessionInitializeTransaction ();
                practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), p_Practitioner_OID);
                practitionerEN.Specialty = (ChroniGenNHibernate.EN.Chroni.SpecialtyEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.SpecialtyEN), p_specialty_OID);

                practitionerEN.Specialty.Practitioner.Add (practitionerEN);



                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignSpecialty (int p_Practitioner_OID, int p_specialty_OID)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerEN = null;
                practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), p_Practitioner_OID);

                if (practitionerEN.Specialty.Identifier == p_specialty_OID) {
                        practitionerEN.Specialty = null;
                }
                else
                        throw new ModelException ("The identifier " + p_specialty_OID + " in p_specialty_OID you are trying to unrelationer, doesn't exist in PractitionerEN");

                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByGender_Location (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, int p_Location_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByGender_LocationHQL");
                query.SetParameter ("p_gender", p_gender);
                query.SetParameter ("p_Location_OID", p_Location_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByRole_LocationName (ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum? p_role, string p_Location_name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByRole_LocationNameHQL");
                query.SetParameter ("p_role", p_role);
                query.SetParameter ("p_Location_name", p_Location_name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByNif (string p_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN as prac WHERE prac.Nif = :p_nif";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionerByNifHQL");
                query.SetParameter ("p_nif", p_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByLocation (int p_location)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where SELECT pra FROM PractitionerEN as pra inner join pra.Location as loc where loc.Identifier = :p_location";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByLocationHQL");
                query.SetParameter ("p_location", p_location);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByLocationName (string p_Location_name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByLocationNameHQL");
                query.SetParameter ("p_Location_name", p_Location_name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByPhone (string p_phone)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionerByPhoneHQL");
                query.SetParameter ("p_phone", p_phone);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerBySpecialtyDisplay (string p_Specialty_Display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionerBySpecialtyDisplayHQL");
                query.SetParameter ("p_Specialty_Display", p_Specialty_Display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersBySpecialtyCode (string p_Specialty_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersBySpecialtyCodeHQL");
                query.SetParameter ("p_Specialty_code", p_Specialty_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersBySpecialtyDisplay_Interval (string p_Specialty_display, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersBySpecialtyDisplay_IntervalHQL");
                query.SetParameter ("p_Specialty_display", p_Specialty_display);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByBirthInterval (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByBirthIntervalHQL");
                query.SetParameter ("p_birthDateFrom", p_birthDateFrom);
                query.SetParameter ("p_birthDateTo", p_birthDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionersByPatientName_SurnamesHQL");
                query.SetParameter ("p_Patient_name", p_Patient_name);
                query.SetParameter ("p_Patient_surnames", p_Patient_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByEmail (string email)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PractitionerEN self where FROM PractitionerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PractitionerENgetPractitionerByEmailHQL");
                query.SetParameter ("email", email);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignSchedule (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_schedule_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerEN = null;
        try
        {
                SessionInitializeTransaction ();
                practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), p_Practitioner_OID);
                ChroniGenNHibernate.EN.Chroni.ScheduleEN scheduleENAux = null;
                if (practitionerEN.Schedule == null) {
                        practitionerEN.Schedule = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                }

                foreach (int item in p_schedule_OIDs) {
                        scheduleENAux = new ChroniGenNHibernate.EN.Chroni.ScheduleEN ();
                        scheduleENAux = (ChroniGenNHibernate.EN.Chroni.ScheduleEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.ScheduleEN), item);
                        scheduleENAux.Practitioner = practitionerEN;

                        practitionerEN.Schedule.Add (scheduleENAux);
                }


                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignSchedule (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_schedule_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerEN = null;
                practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), p_Practitioner_OID);

                ChroniGenNHibernate.EN.Chroni.ScheduleEN scheduleENAux = null;
                if (practitionerEN.Schedule != null) {
                        foreach (int item in p_schedule_OIDs) {
                                scheduleENAux = (ChroniGenNHibernate.EN.Chroni.ScheduleEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.ScheduleEN), item);
                                if (practitionerEN.Schedule.Contains (scheduleENAux) == true) {
                                        practitionerEN.Schedule.Remove (scheduleENAux);
                                        scheduleENAux.Practitioner = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_schedule_OIDs you are trying to unrelationer, doesn't exist in PractitionerEN");
                        }
                }

                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
