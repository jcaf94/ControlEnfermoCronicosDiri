
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
 * Clase CarePlan:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class CarePlanCAD : BasicCAD, ICarePlanCAD
{
public CarePlanCAD() : base ()
{
}

public CarePlanCAD(ISession sessionAux) : base (sessionAux)
{
}



public CarePlanEN ReadOIDDefault (int identifier
                                  )
{
        CarePlanEN carePlanEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanEN = (CarePlanEN)session.Get (typeof(CarePlanEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanEN;
}

public System.Collections.Generic.IList<CarePlanEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CarePlanEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CarePlanEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CarePlanEN>();
                        else
                                result = session.CreateCriteria (typeof(CarePlanEN)).List<CarePlanEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CarePlanEN carePlan)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanEN carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), carePlan.Identifier);

                carePlanEN.Subject = carePlan.Subject;


                carePlanEN.Status = carePlan.Status;


                carePlanEN.Context = carePlan.Context;


                carePlanEN.StartDate = carePlan.StartDate;


                carePlanEN.Modified = carePlan.Modified;


                carePlanEN.Description = carePlan.Description;


                carePlanEN.Note = carePlan.Note;





                carePlanEN.EndDate = carePlan.EndDate;


                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CarePlanEN carePlan)
{
        try
        {
                SessionInitializeTransaction ();
                if (carePlan.Encounter != null) {
                        // Argumento OID y no colección.
                        carePlan.Encounter = (ChroniGenNHibernate.EN.Chroni.EncounterEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.EncounterEN), carePlan.Encounter.Identifier);

                        carePlan.Encounter.CarePlan
                        .Add (carePlan);
                }

                session.Save (carePlan);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlan.Identifier;
}

public void Modify (CarePlanEN carePlan)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanEN carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), carePlan.Identifier);

                carePlanEN.Subject = carePlan.Subject;


                carePlanEN.Status = carePlan.Status;


                carePlanEN.Context = carePlan.Context;


                carePlanEN.StartDate = carePlan.StartDate;


                carePlanEN.Modified = carePlan.Modified;


                carePlanEN.Description = carePlan.Description;


                carePlanEN.Note = carePlan.Note;


                carePlanEN.EndDate = carePlan.EndDate;

                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
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
                CarePlanEN carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), identifier);
                session.Delete (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CarePlanEN
public CarePlanEN ReadOID (int identifier
                           )
{
        CarePlanEN carePlanEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanEN = (CarePlanEN)session.Get (typeof(CarePlanEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanEN;
}

public System.Collections.Generic.IList<CarePlanEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CarePlanEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CarePlanEN>();
                else
                        result = session.CreateCriteria (typeof(CarePlanEN)).List<CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByCategoryCode_Period (string p_CarePlanCategory_code, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanEN self where FROM CarePlanEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanENgetCarePlansByCategoryCode_PeriodHQL");
                query.SetParameter ("p_CarePlanCategory_code", p_CarePlanCategory_code);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByStatus_Period (ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum? p_status, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanEN self where FROM CarePlanEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanENgetCarePlansByStatus_PeriodHQL");
                query.SetParameter ("p_status", p_status);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanEN self where FROM CarePlanEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanENgetCarePlansByPatientHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient_Practitioner (int p_Patient_OID, Nullable<DateTime> p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanEN self where FROM CarePlanEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanENgetCarePlansByPatient_PractitionerHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanEN self where FROM CarePlanEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanENgetCarePlansByPatient_StatusHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByCategoryDisplay_Period (string p_CarePlanCategory_display, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanEN self where FROM CarePlanEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanENgetCarePlansByCategoryDisplay_PeriodHQL");
                query.SetParameter ("p_CarePlanCategory_display", p_CarePlanCategory_display);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignCategory (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_carePlanCategory_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlanEN = null;
        try
        {
                SessionInitializeTransaction ();
                carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), p_CarePlan_OID);
                ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN carePlanCategoryENAux = null;
                if (carePlanEN.CarePlanCategory == null) {
                        carePlanEN.CarePlanCategory = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN>();
                }

                foreach (int item in p_carePlanCategory_OIDs) {
                        carePlanCategoryENAux = new ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN ();
                        carePlanCategoryENAux = (ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN), item);
                        carePlanCategoryENAux.CarePlan.Add (carePlanEN);

                        carePlanEN.CarePlanCategory.Add (carePlanCategoryENAux);
                }


                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignCategory (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_carePlanCategory_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlanEN = null;
                carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), p_CarePlan_OID);

                ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN carePlanCategoryENAux = null;
                if (carePlanEN.CarePlanCategory != null) {
                        foreach (int item in p_carePlanCategory_OIDs) {
                                carePlanCategoryENAux = (ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN), item);
                                if (carePlanEN.CarePlanCategory.Contains (carePlanCategoryENAux) == true) {
                                        carePlanEN.CarePlanCategory.Remove (carePlanCategoryENAux);
                                        carePlanCategoryENAux.CarePlan.Remove (carePlanEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_carePlanCategory_OIDs you are trying to unrelationer, doesn't exist in CarePlanEN");
                        }
                }

                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void AssignGoal (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_goal_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlanEN = null;
        try
        {
                SessionInitializeTransaction ();
                carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), p_CarePlan_OID);
                ChroniGenNHibernate.EN.Chroni.GoalEN goalENAux = null;
                if (carePlanEN.Goal == null) {
                        carePlanEN.Goal = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.GoalEN>();
                }

                foreach (int item in p_goal_OIDs) {
                        goalENAux = new ChroniGenNHibernate.EN.Chroni.GoalEN ();
                        goalENAux = (ChroniGenNHibernate.EN.Chroni.GoalEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.GoalEN), item);
                        goalENAux.CarePlan = carePlanEN;

                        carePlanEN.Goal.Add (goalENAux);
                }


                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignGoal (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_goal_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.CarePlanEN carePlanEN = null;
                carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), p_CarePlan_OID);

                ChroniGenNHibernate.EN.Chroni.GoalEN goalENAux = null;
                if (carePlanEN.Goal != null) {
                        foreach (int item in p_goal_OIDs) {
                                goalENAux = (ChroniGenNHibernate.EN.Chroni.GoalEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.GoalEN), item);
                                if (carePlanEN.Goal.Contains (goalENAux) == true) {
                                        carePlanEN.Goal.Remove (goalENAux);
                                        goalENAux.CarePlan = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_goal_OIDs you are trying to unrelationer, doesn't exist in CarePlanEN");
                        }
                }

                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
