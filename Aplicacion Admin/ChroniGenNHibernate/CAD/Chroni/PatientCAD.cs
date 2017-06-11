
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
 * Clase Patient:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class PatientCAD : BasicCAD, IPatientCAD
{
public PatientCAD() : base ()
{
}

public PatientCAD(ISession sessionAux) : base (sessionAux)
{
}



public PatientEN ReadOIDDefault (int identifier
                                 )
{
        PatientEN patientEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Get (typeof(PatientEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientEN;
}

public System.Collections.Generic.IList<PatientEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PatientEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PatientEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PatientEN>();
                        else
                                result = session.CreateCriteria (typeof(PatientEN)).List<PatientEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PatientEN patient)
{
        try
        {
                SessionInitializeTransaction ();
                PatientEN patientEN = (PatientEN)session.Load (typeof(PatientEN), patient.Identifier);

                patientEN.Nif = patient.Nif;


                patientEN.Active = patient.Active;


                patientEN.Name = patient.Name;


                patientEN.Surnames = patient.Surnames;


                patientEN.Gender = patient.Gender;


                patientEN.BirthDate = patient.BirthDate;


                patientEN.Deceased = patient.Deceased;


                patientEN.Address = patient.Address;


                patientEN.Email = patient.Email;


                patientEN.Phone = patient.Phone;


                patientEN.MaritalStatus = patient.MaritalStatus;


                patientEN.Photo = patient.Photo;








                patientEN.Password = patient.Password;



                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PatientEN patient)
{
        try
        {
                SessionInitializeTransaction ();
                if (patient.Location != null) {
                        for (int i = 0; i < patient.Location.Count; i++) {
                                patient.Location [i] = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), patient.Location [i].Identifier);
                                patient.Location [i].Patient.Add (patient);
                        }
                }
                if (patient.Diary != null) {
                        // p_diary
                        patient.Diary.Patient = patient;
                        session.Save (patient.Diary);
                }

                session.Save (patient);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patient.Identifier;
}

public void Modify (PatientEN patient)
{
        try
        {
                SessionInitializeTransaction ();
                PatientEN patientEN = (PatientEN)session.Load (typeof(PatientEN), patient.Identifier);

                patientEN.Nif = patient.Nif;


                patientEN.Active = patient.Active;


                patientEN.Name = patient.Name;


                patientEN.Surnames = patient.Surnames;


                patientEN.Gender = patient.Gender;


                patientEN.BirthDate = patient.BirthDate;


                patientEN.Deceased = patient.Deceased;


                patientEN.Address = patient.Address;


                patientEN.Email = patient.Email;


                patientEN.Phone = patient.Phone;


                patientEN.MaritalStatus = patient.MaritalStatus;


                patientEN.Photo = patient.Photo;


                patientEN.Password = patient.Password;

                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
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
                PatientEN patientEN = (PatientEN)session.Load (typeof(PatientEN), identifier);
                session.Delete (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PatientEN
public PatientEN ReadOID (int identifier
                          )
{
        PatientEN patientEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Get (typeof(PatientEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientEN;
}

public System.Collections.Generic.IList<PatientEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PatientEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PatientEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PatientEN>();
                else
                        result = session.CreateCriteria (typeof(PatientEN)).List<PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignLocation (int p_Patient_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);
                ChroniGenNHibernate.EN.Chroni.LocationEN locationENAux = null;
                if (patientEN.Location == null) {
                        patientEN.Location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
                }

                foreach (int item in p_location_OIDs) {
                        locationENAux = new ChroniGenNHibernate.EN.Chroni.LocationEN ();
                        locationENAux = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), item);
                        locationENAux.Patient.Add (patientEN);

                        patientEN.Location.Add (locationENAux);
                }


                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignLocation (int p_Patient_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);

                ChroniGenNHibernate.EN.Chroni.LocationEN locationENAux = null;
                if (patientEN.Location != null) {
                        foreach (int item in p_location_OIDs) {
                                locationENAux = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), item);
                                if (patientEN.Location.Contains (locationENAux) == true) {
                                        patientEN.Location.Remove (locationENAux);
                                        locationENAux.Patient.Remove (patientEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_location_OIDs you are trying to unrelationer, doesn't exist in PatientEN");
                        }
                }

                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByGender_Location (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, int p_location)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where SELECT pac FROM PatientEN as pac inner join pac.Location as loc WHERE (pac.Gender =  :p_gender AND loc.Identifier = :p_location)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByGender_LocationHQL");
                query.SetParameter ("p_gender", p_gender);
                query.SetParameter ("p_location", p_location);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval_Location (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo, int p_location)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByBirthInterval_LocationHQL");
                query.SetParameter ("p_birthDateFrom", p_birthDateFrom);
                query.SetParameter ("p_birthDateTo", p_birthDateTo);
                query.SetParameter ("p_location", p_location);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByActive_Location (bool? p_active, int p_location)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where SELECT pac FROM PatientEN as pac inner join pac.Location as loc WHERE (pac.Active = :p_active AND loc.Identifier = :p_location)";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByActive_LocationHQL");
                query.SetParameter ("p_active", p_active);
                query.SetParameter ("p_location", p_location);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByName_Surnames_Location (string p_name, string p_surname, int p_location)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where SELECT pac FROM PatientEN as pac inner join pac.Location as loc WHERE (pac.Name LIKE ('%' + :p_name+ '%') AND loc.Identifier = :p_location) ";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByName_Surnames_LocationHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_surname", p_surname);
                query.SetParameter ("p_location", p_location);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientByNif (string p_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN as pac WHERE pac.Nif = :p_nif ";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientByNifHQL");
                query.SetParameter ("p_nif", p_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByGender_MaritalStatus (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum ? p_maritalStatus)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByGender_MaritalStatusHQL");
                query.SetParameter ("p_gender", p_gender);
                query.SetParameter ("p_maritalStatus", p_maritalStatus);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval_Gender (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum ? p_gender)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByBirthInterval_GenderHQL");
                query.SetParameter ("p_birthDateFrom", p_birthDateFrom);
                query.SetParameter ("p_birthDateTo", p_birthDateTo);
                query.SetParameter ("p_gender", p_gender);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCode (string p_conditionCode)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByConditionCodeHQL");
                query.SetParameter ("p_conditionCode", p_conditionCode);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignPractitioner (int p_Patient_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);
                ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerENAux = null;
                if (patientEN.Practitioner == null) {
                        patientEN.Practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                }

                foreach (int item in p_practitioner_OIDs) {
                        practitionerENAux = new ChroniGenNHibernate.EN.Chroni.PractitionerEN ();
                        practitionerENAux = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), item);
                        practitionerENAux.Patient.Add (patientEN);

                        patientEN.Practitioner.Add (practitionerENAux);
                }


                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignPractitioner (int p_Patient_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);

                ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerENAux = null;
                if (patientEN.Practitioner != null) {
                        foreach (int item in p_practitioner_OIDs) {
                                practitionerENAux = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), item);
                                if (patientEN.Practitioner.Contains (practitionerENAux) == true) {
                                        patientEN.Practitioner.Remove (practitionerENAux);
                                        practitionerENAux.Patient.Remove (patientEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_practitioner_OIDs you are trying to unrelationer, doesn't exist in PatientEN");
                        }
                }

                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void AssignRelatedPerson (int p_Patient_OID, System.Collections.Generic.IList<int> p_relatedPerson_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);
                ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPersonENAux = null;
                if (patientEN.RelatedPerson == null) {
                        patientEN.RelatedPerson = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN>();
                }

                foreach (int item in p_relatedPerson_OIDs) {
                        relatedPersonENAux = new ChroniGenNHibernate.EN.Chroni.RelatedPersonEN ();
                        relatedPersonENAux = (ChroniGenNHibernate.EN.Chroni.RelatedPersonEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.RelatedPersonEN), item);
                        relatedPersonENAux.Patient.Add (patientEN);

                        patientEN.RelatedPerson.Add (relatedPersonENAux);
                }


                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignRelatedPerson (int p_Patient_OID, System.Collections.Generic.IList<int> p_relatedPerson_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);

                ChroniGenNHibernate.EN.Chroni.RelatedPersonEN relatedPersonENAux = null;
                if (patientEN.RelatedPerson != null) {
                        foreach (int item in p_relatedPerson_OIDs) {
                                relatedPersonENAux = (ChroniGenNHibernate.EN.Chroni.RelatedPersonEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.RelatedPersonEN), item);
                                if (patientEN.RelatedPerson.Contains (relatedPersonENAux) == true) {
                                        patientEN.RelatedPerson.Remove (relatedPersonENAux);
                                        relatedPersonENAux.Patient.Remove (patientEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_relatedPerson_OIDs you are trying to unrelationer, doesn't exist in PatientEN");
                        }
                }

                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByPractitionerNif (string p_practitionerNif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByPractitionerNifHQL");
                query.SetParameter ("p_practitionerNif", p_practitionerNif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByRelatedPersonNif (string p_relatedPersonNif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByRelatedPersonNifHQL");
                query.SetParameter ("p_relatedPersonNif", p_relatedPersonNif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByBirthIntervalHQL");
                query.SetParameter ("p_birthDateFrom", p_birthDateFrom);
                query.SetParameter ("p_birthDateTo", p_birthDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByNameSurnames (string p_name, string p_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByNameSurnamesHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_surnames", p_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByName_Surnames_BirthDate (string p_name, string p_surnames, Nullable<DateTime> p_birthDate)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByName_Surnames_BirthDateHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_surnames", p_surnames);
                query.SetParameter ("p_birthDate", p_birthDate);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsBySurnames (string p_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsBySurnamesHQL");
                query.SetParameter ("p_surnames", p_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByPhone (string p_phone)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByPhoneHQL");
                query.SetParameter ("p_phone", p_phone);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByEmail (string p_email)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByEmailHQL");
                query.SetParameter ("p_email", p_email);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByDeseased (bool ? p_deseased)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByDeseasedHQL");
                query.SetParameter ("p_deseased", p_deseased);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByEncounter (int p_Encounter_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByEncounterHQL");
                query.SetParameter ("p_Encounter_OID", p_Encounter_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCodeCode (string p_ConditionCode_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByConditionCodeCodeHQL");
                query.SetParameter ("p_ConditionCode_code", p_ConditionCode_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCodeDisplay (string p_ConditionCode_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where FROM PatientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByConditionCodeDisplayHQL");
                query.SetParameter ("p_ConditionCode_display", p_ConditionCode_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignDiary (int p_Patient_OID, int p_diary_OID)
{
        ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);
                patientEN.Diary = (ChroniGenNHibernate.EN.Chroni.DiaryEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.DiaryEN), p_diary_OID);

                patientEN.Diary.Patient = patientEN;




                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignDiary (int p_Patient_OID, int p_diary_OID)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.PatientEN patientEN = null;
                patientEN = (PatientEN)session.Load (typeof(PatientEN), p_Patient_OID);

                if (patientEN.Diary.Identifier == p_diary_OID) {
                        patientEN.Diary = null;
                        ChroniGenNHibernate.EN.Chroni.DiaryEN diaryEN = (ChroniGenNHibernate.EN.Chroni.DiaryEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.DiaryEN), p_diary_OID);
                        diaryEN.Patient = null;
                }
                else
                        throw new ModelException ("The identifier " + p_diary_OID + " in p_diary_OID you are trying to unrelationer, doesn't exist in PatientEN");

                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByLocation (int p_location)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PatientEN self where SELECT pat FROM PatientEN as pat inner join pat.Location as loc where loc.Identifier = :p_location";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PatientENgetPatientsByLocationHQL");
                query.SetParameter ("p_location", p_location);

                result = query.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
