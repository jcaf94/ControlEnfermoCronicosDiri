
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
 * Clase Encounter:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class EncounterCAD : BasicCAD, IEncounterCAD
{
public EncounterCAD() : base ()
{
}

public EncounterCAD(ISession sessionAux) : base (sessionAux)
{
}



public EncounterEN ReadOIDDefault (int identifier
                                   )
{
        EncounterEN encounterEN = null;

        try
        {
                SessionInitializeTransaction ();
                encounterEN = (EncounterEN)session.Get (typeof(EncounterEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return encounterEN;
}

public System.Collections.Generic.IList<EncounterEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EncounterEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EncounterEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EncounterEN>();
                        else
                                result = session.CreateCriteria (typeof(EncounterEN)).List<EncounterEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EncounterEN encounter)
{
        try
        {
                SessionInitializeTransaction ();
                EncounterEN encounterEN = (EncounterEN)session.Load (typeof(EncounterEN), encounter.Identifier);

                encounterEN.Status = encounter.Status;


                encounterEN.Type = encounter.Type;


                encounterEN.Priority = encounter.Priority;


                encounterEN.StartDate = encounter.StartDate;


                encounterEN.EndDate = encounter.EndDate;


                encounterEN.Reason = encounter.Reason;


                encounterEN.ServiceProvider = encounter.ServiceProvider;







                encounterEN.Note = encounter.Note;

                session.Update (encounterEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EncounterEN encounter)
{
        try
        {
                SessionInitializeTransaction ();
                if (encounter.Patient != null) {
                        // Argumento OID y no colección.
                        encounter.Patient = (ChroniGenNHibernate.EN.Chroni.PatientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PatientEN), encounter.Patient.Identifier);

                        encounter.Patient.Encounter
                        .Add (encounter);
                }
                if (encounter.Practitioner != null) {
                        for (int i = 0; i < encounter.Practitioner.Count; i++) {
                                encounter.Practitioner [i] = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), encounter.Practitioner [i].Identifier);
                                encounter.Practitioner [i].Encounter.Add (encounter);
                        }
                }
                if (encounter.Condition != null) {
                        // p_condition
                        encounter.Condition.Encounter = encounter;
                        session.Save (encounter.Condition);
                }
                if (encounter.Slot != null) {
                        // Argumento OID y no colección.
                        encounter.Slot = (ChroniGenNHibernate.EN.Chroni.SlotEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.SlotEN), encounter.Slot.Identifier);

                        encounter.Slot.Encounter
                                = encounter;
                }

                session.Save (encounter);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return encounter.Identifier;
}

public void Modify (EncounterEN encounter)
{
        try
        {
                SessionInitializeTransaction ();
                EncounterEN encounterEN = (EncounterEN)session.Load (typeof(EncounterEN), encounter.Identifier);

                encounterEN.Status = encounter.Status;


                encounterEN.Type = encounter.Type;


                encounterEN.Priority = encounter.Priority;


                encounterEN.StartDate = encounter.StartDate;


                encounterEN.EndDate = encounter.EndDate;


                encounterEN.Reason = encounter.Reason;


                encounterEN.ServiceProvider = encounter.ServiceProvider;


                encounterEN.Note = encounter.Note;

                session.Update (encounterEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
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
                EncounterEN encounterEN = (EncounterEN)session.Load (typeof(EncounterEN), identifier);
                session.Delete (encounterEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: EncounterEN
public EncounterEN ReadOID (int identifier
                            )
{
        EncounterEN encounterEN = null;

        try
        {
                SessionInitializeTransaction ();
                encounterEN = (EncounterEN)session.Get (typeof(EncounterEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return encounterEN;
}

public System.Collections.Generic.IList<EncounterEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EncounterEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EncounterEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EncounterEN>();
                else
                        result = session.CreateCriteria (typeof(EncounterEN)).List<EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatientHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Status (string p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatient_StatusHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatient_IntervalHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Practitioner (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatient_PractitionerHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitioner (int p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPractitionerHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEnconntersByPractitioner_Status (int p_Practitioner_OID, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEnconntersByPractitioner_StatusHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCategory (ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum ? p_ConditionCategory)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByConditionCategoryHQL");
                query.SetParameter ("p_ConditionCategory", p_ConditionCategory);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByCondidionClinicalStatus (ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum ? p_Condition_clinicalStatus)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByCondidionClinicalStatusHQL");
                query.SetParameter ("p_Condition_clinicalStatus", p_Condition_clinicalStatus);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCodeCode (string p_Condition_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByConditionCodeCodeHQL");
                query.SetParameter ("p_Condition_code", p_Condition_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCodeDisplay (string p_ConditionCode_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByConditionCodeDisplayHQL");
                query.SetParameter ("p_ConditionCode_display", p_ConditionCode_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif (string p_Practitioner_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPractitionerNifHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatientName_SurnamesHQL");
                query.SetParameter ("p_Patient_name", p_Patient_name);
                query.SetParameter ("p_Patient_surnames", p_Patient_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerName_Surnames ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPractitionerName_SurnamesHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersBySpecialtyCode (string p_SpecialtyCode)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersBySpecialtyCodeHQL");
                query.SetParameter ("p_SpecialtyCode", p_SpecialtyCode);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersBySpecialtyDisplay (string p_Specialty_Display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersBySpecialtyDisplayHQL");
                query.SetParameter ("p_Specialty_Display", p_Specialty_Display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_PractitionerSpecialtyDisplay (string p_Patient_nif, string p_Specialty_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatientNif_PractitionerSpecialtyDisplayHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_Specialty_display", p_Specialty_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByInterval_Priority (Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum ? p_priority)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByInterval_PriorityHQL");
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);
                query.SetParameter ("p_priority", p_priority);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_Status (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatientNif_StatusHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_Interval (string p_patient_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatientNif_IntervalHQL");
                query.SetParameter ("p_patient_nif", p_patient_nif);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_PractitionerName_Surnames (string p_Patient_nif, string p_Practitioner_name, string p_Practitioner_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPatientNif_PractitionerName_SurnamesHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_Practitioner_name", p_Practitioner_name);
                query.SetParameter ("p_Practitioner_surnames", p_Practitioner_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif_Interval (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPractitionerNif_IntervalHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif_Status ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EncounterEN self where FROM EncounterEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EncounterENgetEncountersByPractitionerNif_StatusHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.EncounterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignCarePlan (int p_Encounter_OID, System.Collections.Generic.IList<int> p_carePlan_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.EncounterEN encounterEN = null;
        try
        {
                SessionInitializeTransaction ();
                encounterEN = (EncounterEN)session.Load (typeof(EncounterEN), p_Encounter_OID);
                ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlanENAux = null;
                if (encounterEN.CarePlan == null) {
                        encounterEN.CarePlan = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
                }

                foreach (int item in p_carePlan_OIDs) {
                        carePlanENAux = new ChroniGenNHibernate.EN.Chroni.CarePlanEN ();
                        carePlanENAux = (ChroniGenNHibernate.EN.Chroni.CarePlanEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.CarePlanEN), item);
                        carePlanENAux.Encounter = encounterEN;

                        encounterEN.CarePlan.Add (carePlanENAux);
                }


                session.Update (encounterEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignCarePlan (int p_Encounter_OID, System.Collections.Generic.IList<int> p_carePlan_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.EncounterEN encounterEN = null;
                encounterEN = (EncounterEN)session.Load (typeof(EncounterEN), p_Encounter_OID);

                ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlanENAux = null;
                if (encounterEN.CarePlan != null) {
                        foreach (int item in p_carePlan_OIDs) {
                                carePlanENAux = (ChroniGenNHibernate.EN.Chroni.CarePlanEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.CarePlanEN), item);
                                if (encounterEN.CarePlan.Contains (carePlanENAux) == true) {
                                        encounterEN.CarePlan.Remove (carePlanENAux);
                                        carePlanENAux.Encounter = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_carePlan_OIDs you are trying to unrelationer, doesn't exist in EncounterEN");
                        }
                }

                session.Update (encounterEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in EncounterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
