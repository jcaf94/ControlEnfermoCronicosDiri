
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
 * Clase Activity:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ActivityCAD : BasicCAD, IActivityCAD
{
public ActivityCAD() : base ()
{
}

public ActivityCAD(ISession sessionAux) : base (sessionAux)
{
}



public ActivityEN ReadOIDDefault (int identifier
                                  )
{
        ActivityEN activityEN = null;

        try
        {
                SessionInitializeTransaction ();
                activityEN = (ActivityEN)session.Get (typeof(ActivityEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return activityEN;
}

public System.Collections.Generic.IList<ActivityEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ActivityEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ActivityEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ActivityEN>();
                        else
                                result = session.CreateCriteria (typeof(ActivityEN)).List<ActivityEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ActivityEN activity)
{
        try
        {
                SessionInitializeTransaction ();
                ActivityEN activityEN = (ActivityEN)session.Load (typeof(ActivityEN), activity.Identifier);

                activityEN.Progress = activity.Progress;


                activityEN.Description = activity.Description;



                activityEN.StartDate = activity.StartDate;


                activityEN.EndDate = activity.EndDate;


                session.Update (activityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ActivityEN activity)
{
        try
        {
                SessionInitializeTransaction ();
                if (activity.CarePlan != null) {
                        // Argumento OID y no colección.
                        activity.CarePlan = (ChroniGenNHibernate.EN.Chroni.CarePlanEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.CarePlanEN), activity.CarePlan.Identifier);

                        activity.CarePlan.Activity
                        .Add (activity);
                }

                session.Save (activity);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return activity.Identifier;
}

public void Modify (ActivityEN activity)
{
        try
        {
                SessionInitializeTransaction ();
                ActivityEN activityEN = (ActivityEN)session.Load (typeof(ActivityEN), activity.Identifier);

                activityEN.Progress = activity.Progress;


                activityEN.Description = activity.Description;


                activityEN.StartDate = activity.StartDate;


                activityEN.EndDate = activity.EndDate;

                session.Update (activityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
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
                ActivityEN activityEN = (ActivityEN)session.Load (typeof(ActivityEN), identifier);
                session.Delete (activityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ActivityEN
public ActivityEN ReadOID (int identifier
                           )
{
        ActivityEN activityEN = null;

        try
        {
                SessionInitializeTransaction ();
                activityEN = (ActivityEN)session.Get (typeof(ActivityEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return activityEN;
}

public System.Collections.Generic.IList<ActivityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ActivityEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ActivityEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ActivityEN>();
                else
                        result = session.CreateCriteria (typeof(ActivityEN)).List<ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByInterval (Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByIntervalHQL");
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByPatient_IntervalHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPractitioner_Interval (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByPractitioner_IntervalHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByCarePlan (int p_CarePlan_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByCarePlanHQL");
                query.SetParameter ("p_CarePlan_OID", p_CarePlan_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByCarePlanCategoryDisplay (string p_CarePlanCategory_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByCarePlanCategoryDisplayHQL");
                query.SetParameter ("p_CarePlanCategory_display", p_CarePlanCategory_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivityByPractitionerNif (string p_Practitioner_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivityByPractitionerNifHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatientNif_Description (string p_Patient_nif, string p_description)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByPatientNif_DescriptionHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_description", p_description);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByDescription ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByDescriptionHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByMedicationName (string p_Medication_name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ActivityEN self where FROM ActivityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ActivityENgetActivitiesByMedicationNameHQL");
                query.SetParameter ("p_Medication_name", p_Medication_name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignMedication (int p_Activity_OID, System.Collections.Generic.IList<int> p_medication_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.ActivityEN activityEN = null;
        try
        {
                SessionInitializeTransaction ();
                activityEN = (ActivityEN)session.Load (typeof(ActivityEN), p_Activity_OID);
                ChroniGenNHibernate.EN.Chroni.MedicationEN medicationENAux = null;
                if (activityEN.Medication == null) {
                        activityEN.Medication = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                }

                foreach (int item in p_medication_OIDs) {
                        medicationENAux = new ChroniGenNHibernate.EN.Chroni.MedicationEN ();
                        medicationENAux = (ChroniGenNHibernate.EN.Chroni.MedicationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.MedicationEN), item);
                        medicationENAux.Activity.Add (activityEN);

                        activityEN.Medication.Add (medicationENAux);
                }


                session.Update (activityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignMedication (int p_Activity_OID, System.Collections.Generic.IList<int> p_medication_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.ActivityEN activityEN = null;
                activityEN = (ActivityEN)session.Load (typeof(ActivityEN), p_Activity_OID);

                ChroniGenNHibernate.EN.Chroni.MedicationEN medicationENAux = null;
                if (activityEN.Medication != null) {
                        foreach (int item in p_medication_OIDs) {
                                medicationENAux = (ChroniGenNHibernate.EN.Chroni.MedicationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.MedicationEN), item);
                                if (activityEN.Medication.Contains (medicationENAux) == true) {
                                        activityEN.Medication.Remove (medicationENAux);
                                        medicationENAux.Activity.Remove (activityEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_medication_OIDs you are trying to unrelationer, doesn't exist in ActivityEN");
                        }
                }

                session.Update (activityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
