
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
 * Clase RelatedPerson:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class RelatedPersonCAD : BasicCAD, IRelatedPersonCAD
{
public RelatedPersonCAD() : base ()
{
}

public RelatedPersonCAD(ISession sessionAux) : base (sessionAux)
{
}



public RelatedPersonEN ReadOIDDefault (int identifier
                                       )
{
        RelatedPersonEN relatedPersonEN = null;

        try
        {
                SessionInitializeTransaction ();
                relatedPersonEN = (RelatedPersonEN)session.Get (typeof(RelatedPersonEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relatedPersonEN;
}

public System.Collections.Generic.IList<RelatedPersonEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RelatedPersonEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RelatedPersonEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RelatedPersonEN>();
                        else
                                result = session.CreateCriteria (typeof(RelatedPersonEN)).List<RelatedPersonEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RelatedPersonEN relatedPerson)
{
        try
        {
                SessionInitializeTransaction ();
                RelatedPersonEN relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), relatedPerson.Identifier);

                relatedPersonEN.Nif = relatedPerson.Nif;


                relatedPersonEN.Name = relatedPerson.Name;


                relatedPersonEN.Surnames = relatedPerson.Surnames;


                relatedPersonEN.Gender = relatedPerson.Gender;


                relatedPersonEN.BirthDate = relatedPerson.BirthDate;


                relatedPersonEN.Address = relatedPerson.Address;


                relatedPersonEN.Email = relatedPerson.Email;


                relatedPersonEN.Phone = relatedPerson.Phone;


                relatedPersonEN.Photo = relatedPerson.Photo;


                relatedPersonEN.StartDate = relatedPerson.StartDate;


                relatedPersonEN.EndDate = relatedPerson.EndDate;



                relatedPersonEN.Password = relatedPerson.Password;




                relatedPersonEN.Active = relatedPerson.Active;


                session.Update (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RelatedPersonEN relatedPerson)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (relatedPerson);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relatedPerson.Identifier;
}

public void Modify (RelatedPersonEN relatedPerson)
{
        try
        {
                SessionInitializeTransaction ();
                RelatedPersonEN relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), relatedPerson.Identifier);

                relatedPersonEN.Nif = relatedPerson.Nif;


                relatedPersonEN.Name = relatedPerson.Name;


                relatedPersonEN.Surnames = relatedPerson.Surnames;


                relatedPersonEN.Gender = relatedPerson.Gender;


                relatedPersonEN.BirthDate = relatedPerson.BirthDate;


                relatedPersonEN.Address = relatedPerson.Address;


                relatedPersonEN.Email = relatedPerson.Email;


                relatedPersonEN.Phone = relatedPerson.Phone;


                relatedPersonEN.Photo = relatedPerson.Photo;


                relatedPersonEN.StartDate = relatedPerson.StartDate;


                relatedPersonEN.EndDate = relatedPerson.EndDate;


                relatedPersonEN.Password = relatedPerson.Password;


                relatedPersonEN.Active = relatedPerson.Active;

                session.Update (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
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
                RelatedPersonEN relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), identifier);
                session.Delete (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RelatedPersonEN
public RelatedPersonEN ReadOID (int identifier
                                )
{
        RelatedPersonEN relatedPersonEN = null;

        try
        {
                SessionInitializeTransaction ();
                relatedPersonEN = (RelatedPersonEN)session.Get (typeof(RelatedPersonEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relatedPersonEN;
}

public System.Collections.Generic.IList<RelatedPersonEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RelatedPersonEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RelatedPersonEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RelatedPersonEN>();
                else
                        result = session.CreateCriteria (typeof(RelatedPersonEN)).List<RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByRelationship (ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum ? p_Relationship_relationship)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByRelationshipHQL");
                query.SetParameter ("p_Relationship_relationship", p_Relationship_relationship);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByGender (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum ? p_gender)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByGenderHQL");
                query.SetParameter ("p_gender", p_gender);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByName_Surnames (string p_name, string p_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByName_SurnamesHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_surnames", p_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByName_Surnames_BirthDate (string p_name, string p_surnames, Nullable<DateTime> p_birthDate)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByName_Surnames_BirthDateHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_surnames", p_surnames);
                query.SetParameter ("p_birthDate", p_birthDate);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonByNif (string p_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN as rel WHERE rel.Nif = :p_nif";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonByNifHQL");
                query.SetParameter ("p_nif", p_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonByPatientNif (string p_patientNif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonByPatientNifHQL");
                query.SetParameter ("p_patientNif", p_patientNif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientSurnames (string p_Patient_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByPatientSurnamesHQL");
                query.SetParameter ("p_Patient_surnames", p_Patient_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByPatientName_SurnamesHQL");
                query.SetParameter ("p_Patient_name", p_Patient_name);
                query.SetParameter ("p_Patient_surnames", p_Patient_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsBySurnames (string p_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsBySurnamesHQL");
                query.SetParameter ("p_surnames", p_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientNif_Interval (string p_Patient_nif, string p_StartDateFrom, string p_endDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByPatientNif_IntervalHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_StartDateFrom", p_StartDateFrom);
                query.SetParameter ("p_endDateTo", p_endDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientNif_Active (string p_Patient_nif, bool ? p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByPatientNif_ActiveHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPhone (string p_phone)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByPhoneHQL");
                query.SetParameter ("p_phone", p_phone);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByEmail (string p_email)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelatedPersonEN self where FROM RelatedPersonEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelatedPersonENgetRelatedPersonsByEmailHQL");
                query.SetParameter ("p_email", p_email);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignPatient (int p_RelatedPerson_OID, System.Collections.Generic.IList<int> p_patient_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPersonEN = null;
        try
        {
                SessionInitializeTransaction ();
                relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), p_RelatedPerson_OID);
                ChroniGenNHibernate.EN.Chroni.PatientEN patientENAux = null;
                if (relatedPersonEN.Patient == null) {
                        relatedPersonEN.Patient = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                }

                foreach (int item in p_patient_OIDs) {
                        patientENAux = new ChroniGenNHibernate.EN.Chroni.PatientEN ();
                        patientENAux = (ChroniGenNHibernate.EN.Chroni.PatientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PatientEN), item);
                        patientENAux.RelatedPerson.Add (relatedPersonEN);

                        relatedPersonEN.Patient.Add (patientENAux);
                }


                session.Update (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignPatient (int p_RelatedPerson_OID, System.Collections.Generic.IList<int> p_patient_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPersonEN = null;
                relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), p_RelatedPerson_OID);

                ChroniGenNHibernate.EN.Chroni.PatientEN patientENAux = null;
                if (relatedPersonEN.Patient != null) {
                        foreach (int item in p_patient_OIDs) {
                                patientENAux = (ChroniGenNHibernate.EN.Chroni.PatientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PatientEN), item);
                                if (relatedPersonEN.Patient.Contains (patientENAux) == true) {
                                        relatedPersonEN.Patient.Remove (patientENAux);
                                        patientENAux.RelatedPerson.Remove (relatedPersonEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_patient_OIDs you are trying to unrelationer, doesn't exist in RelatedPersonEN");
                        }
                }

                session.Update (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
