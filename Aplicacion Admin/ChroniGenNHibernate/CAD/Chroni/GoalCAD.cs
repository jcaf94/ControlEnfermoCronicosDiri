
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
 * Clase Goal:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class GoalCAD : BasicCAD, IGoalCAD
{
public GoalCAD() : base ()
{
}

public GoalCAD(ISession sessionAux) : base (sessionAux)
{
}



public GoalEN ReadOIDDefault (int identifier
                              )
{
        GoalEN goalEN = null;

        try
        {
                SessionInitializeTransaction ();
                goalEN = (GoalEN)session.Get (typeof(GoalEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return goalEN;
}

public System.Collections.Generic.IList<GoalEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<GoalEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(GoalEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<GoalEN>();
                        else
                                result = session.CreateCriteria (typeof(GoalEN)).List<GoalEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (GoalEN goal)
{
        try
        {
                SessionInitializeTransaction ();
                GoalEN goalEN = (GoalEN)session.Load (typeof(GoalEN), goal.Identifier);

                goalEN.Subject = goal.Subject;


                goalEN.StatusDate = goal.StatusDate;


                goalEN.Target = goal.Target;


                goalEN.Category = goal.Category;


                goalEN.Description = goal.Description;


                goalEN.Status = goal.Status;


                goalEN.Priority = goal.Priority;


                goalEN.Note = goal.Note;


                session.Update (goalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (GoalEN goal)
{
        try
        {
                SessionInitializeTransaction ();
                if (goal.CarePlan != null) {
                        // Argumento OID y no colección.
                        goal.CarePlan = (ChroniGenNHibernate.EN.Chroni.CarePlanEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.CarePlanEN), goal.CarePlan.Identifier);

                        goal.CarePlan.Goal
                        .Add (goal);
                }

                session.Save (goal);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return goal.Identifier;
}

public void Modify (GoalEN goal)
{
        try
        {
                SessionInitializeTransaction ();
                GoalEN goalEN = (GoalEN)session.Load (typeof(GoalEN), goal.Identifier);

                goalEN.Subject = goal.Subject;


                goalEN.StatusDate = goal.StatusDate;


                goalEN.Target = goal.Target;


                goalEN.Category = goal.Category;


                goalEN.Description = goal.Description;


                goalEN.Status = goal.Status;


                goalEN.Priority = goal.Priority;


                goalEN.Note = goal.Note;

                session.Update (goalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
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
                GoalEN goalEN = (GoalEN)session.Load (typeof(GoalEN), identifier);
                session.Delete (goalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: GoalEN
public GoalEN ReadOID (int identifier
                       )
{
        GoalEN goalEN = null;

        try
        {
                SessionInitializeTransaction ();
                goalEN = (GoalEN)session.Get (typeof(GoalEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return goalEN;
}

public System.Collections.Generic.IList<GoalEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<GoalEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(GoalEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<GoalEN>();
                else
                        result = session.CreateCriteria (typeof(GoalEN)).List<GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetCoalsByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetCoalsByPatient_IntervalHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Category_Interval (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatient_Category_IntervalHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_category", p_category);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatient_StatusHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Category_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatient_Category_StatusHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_category", p_category);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Priority_Interval (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum? p_priority, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatient_Priority_IntervalHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_priority", p_priority);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByCarePlan (int p_CarePlan_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByCarePlanHQL");
                query.SetParameter ("p_CarePlan_OID", p_CarePlan_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Interval (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatientNif_IntervalHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Category_Status (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatientNif_Category_StatusHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_category", p_category);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Priority_Interval (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum? p_priority, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GoalEN self where FROM GoalEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GoalENgetGoalsByPatientNif_Priority_IntervalHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);
                query.SetParameter ("p_priority", p_priority);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
