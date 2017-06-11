
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
 * Clase Observation:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ObservationCAD : BasicCAD, IObservationCAD
{
public ObservationCAD() : base ()
{
}

public ObservationCAD(ISession sessionAux) : base (sessionAux)
{
}



public ObservationEN ReadOIDDefault (int identifier
                                     )
{
        ObservationEN observationEN = null;

        try
        {
                SessionInitializeTransaction ();
                observationEN = (ObservationEN)session.Get (typeof(ObservationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return observationEN;
}

public System.Collections.Generic.IList<ObservationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ObservationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ObservationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ObservationEN>();
                        else
                                result = session.CreateCriteria (typeof(ObservationEN)).List<ObservationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ObservationEN observation)
{
        try
        {
                SessionInitializeTransaction ();
                ObservationEN observationEN = (ObservationEN)session.Load (typeof(ObservationEN), observation.Identifier);

                observationEN.MeasureType = observation.MeasureType;


                observationEN.Name = observation.Name;


                observationEN.DateEntry = observation.DateEntry;


                observationEN.Note = observation.Note;


                observationEN.DateAdded = observation.DateAdded;



                observationEN.DateObservation = observation.DateObservation;


                observationEN.Category = observation.Category;


                observationEN.Grade = observation.Grade;


                observationEN.Value1 = observation.Value1;


                observationEN.Value2 = observation.Value2;


                observationEN.PersonOID = observation.PersonOID;

                session.Update (observationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ObservationEN observation)
{
        try
        {
                SessionInitializeTransaction ();
                if (observation.Diary != null) {
                        // Argumento OID y no colección.
                        observation.Diary = (ChroniGenNHibernate.EN.Chroni.DiaryEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.DiaryEN), observation.Diary.Identifier);

                        observation.Diary.Observation
                        .Add (observation);
                }

                session.Save (observation);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return observation.Identifier;
}

public void Modify (ObservationEN observation)
{
        try
        {
                SessionInitializeTransaction ();
                ObservationEN observationEN = (ObservationEN)session.Load (typeof(ObservationEN), observation.Identifier);

                observationEN.MeasureType = observation.MeasureType;


                observationEN.Name = observation.Name;


                observationEN.DateEntry = observation.DateEntry;


                observationEN.Note = observation.Note;


                observationEN.DateAdded = observation.DateAdded;


                observationEN.DateObservation = observation.DateObservation;


                observationEN.Category = observation.Category;


                observationEN.Grade = observation.Grade;


                observationEN.Value1 = observation.Value1;


                observationEN.Value2 = observation.Value2;


                observationEN.PersonOID = observation.PersonOID;

                session.Update (observationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
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
                ObservationEN observationEN = (ObservationEN)session.Load (typeof(ObservationEN), identifier);
                session.Delete (observationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ObservationEN
public ObservationEN ReadOID (int identifier
                              )
{
        ObservationEN observationEN = null;

        try
        {
                SessionInitializeTransaction ();
                observationEN = (ObservationEN)session.Get (typeof(ObservationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return observationEN;
}

public System.Collections.Generic.IList<ObservationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ObservationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ObservationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ObservationEN>();
                else
                        result = session.CreateCriteria (typeof(ObservationEN)).List<ObservationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByCategory_Interval (ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum? p_category, Nullable<DateTime> p_dateObservationFrom, Nullable<DateTime> p_dateObservationTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObservationEN self where FROM ObservationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObservationENgetObservationsByCategory_IntervalHQL");
                query.SetParameter ("p_category", p_category);
                query.SetParameter ("p_dateObservationFrom", p_dateObservationFrom);
                query.SetParameter ("p_dateObservationTo", p_dateObservationTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ObservationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByMesureType_Value1 (ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum? p_measureType, double ? p_value1)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObservationEN self where FROM ObservationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObservationENgetObservationsByMesureType_Value1HQL");
                query.SetParameter ("p_measureType", p_measureType);
                query.SetParameter ("p_value1", p_value1);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ObservationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByMesureType_Value2 (ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum? p_measureType, double ? p_value2)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObservationEN self where FROM ObservationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObservationENgetObservationsByMesureType_Value2HQL");
                query.SetParameter ("p_measureType", p_measureType);
                query.SetParameter ("p_value2", p_value2);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ObservationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByName_Interval (string p_name, Nullable<DateTime> p_observationDateFrom, Nullable<DateTime> p_observationDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObservationEN self where FROM ObservationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObservationENgetObservationsByName_IntervalHQL");
                query.SetParameter ("p_name", p_name);
                query.SetParameter ("p_observationDateFrom", p_observationDateFrom);
                query.SetParameter ("p_observationDateTo", p_observationDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ObservationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByInterval (Nullable<DateTime> p_observationDateFrom, Nullable<DateTime> p_observationDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObservationEN self where FROM ObservationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObservationENgetObservationsByIntervalHQL");
                query.SetParameter ("p_observationDateFrom", p_observationDateFrom);
                query.SetParameter ("p_observationDateTo", p_observationDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ObservationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ObservationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
