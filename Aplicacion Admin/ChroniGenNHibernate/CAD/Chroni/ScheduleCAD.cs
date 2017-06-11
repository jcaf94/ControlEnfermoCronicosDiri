
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
 * Clase Schedule:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ScheduleCAD : BasicCAD, IScheduleCAD
{
public ScheduleCAD() : base ()
{
}

public ScheduleCAD(ISession sessionAux) : base (sessionAux)
{
}



public ScheduleEN ReadOIDDefault (int identifier
                                  )
{
        ScheduleEN scheduleEN = null;

        try
        {
                SessionInitializeTransaction ();
                scheduleEN = (ScheduleEN)session.Get (typeof(ScheduleEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return scheduleEN;
}

public System.Collections.Generic.IList<ScheduleEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ScheduleEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ScheduleEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ScheduleEN>();
                        else
                                result = session.CreateCriteria (typeof(ScheduleEN)).List<ScheduleEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ScheduleEN schedule)
{
        try
        {
                SessionInitializeTransaction ();
                ScheduleEN scheduleEN = (ScheduleEN)session.Load (typeof(ScheduleEN), schedule.Identifier);




                scheduleEN.Active = schedule.Active;


                scheduleEN.MorningStart = schedule.MorningStart;


                scheduleEN.MorningEnd = schedule.MorningEnd;


                scheduleEN.AfternoonStart = schedule.AfternoonStart;


                scheduleEN.AfternoonEnd = schedule.AfternoonEnd;


                scheduleEN.DateStart = schedule.DateStart;


                scheduleEN.DateEnd = schedule.DateEnd;

                session.Update (scheduleEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ScheduleEN schedule)
{
        try
        {
                SessionInitializeTransaction ();
                if (schedule.Practitioner != null) {
                        // Argumento OID y no colección.
                        schedule.Practitioner = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), schedule.Practitioner.Identifier);

                        schedule.Practitioner.Schedule
                        .Add (schedule);
                }
                if (schedule.Location != null) {
                        // Argumento OID y no colección.
                        schedule.Location = (ChroniGenNHibernate.EN.Chroni.LocationEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.LocationEN), schedule.Location.Identifier);

                        schedule.Location.Schedule
                        .Add (schedule);
                }

                session.Save (schedule);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return schedule.Identifier;
}

public void Modify (ScheduleEN schedule)
{
        try
        {
                SessionInitializeTransaction ();
                ScheduleEN scheduleEN = (ScheduleEN)session.Load (typeof(ScheduleEN), schedule.Identifier);

                scheduleEN.Active = schedule.Active;


                scheduleEN.MorningStart = schedule.MorningStart;


                scheduleEN.MorningEnd = schedule.MorningEnd;


                scheduleEN.AfternoonStart = schedule.AfternoonStart;


                scheduleEN.AfternoonEnd = schedule.AfternoonEnd;


                scheduleEN.DateStart = schedule.DateStart;


                scheduleEN.DateEnd = schedule.DateEnd;

                session.Update (scheduleEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
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
                ScheduleEN scheduleEN = (ScheduleEN)session.Load (typeof(ScheduleEN), identifier);
                session.Delete (scheduleEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ScheduleEN
public ScheduleEN ReadOID (int identifier
                           )
{
        ScheduleEN scheduleEN = null;

        try
        {
                SessionInitializeTransaction ();
                scheduleEN = (ScheduleEN)session.Get (typeof(ScheduleEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return scheduleEN;
}

public System.Collections.Generic.IList<ScheduleEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ScheduleEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ScheduleEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ScheduleEN>();
                else
                        result = session.CreateCriteria (typeof(ScheduleEN)).List<ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner (int p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Interval (int p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitioner_IntervalHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Interval_Active (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, bool ? p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitioner_Interval_ActiveHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif_Interval (string p_practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerNif_IntervalHQL");
                query.SetParameter ("p_practitioner_nif", p_practitioner_nif);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitioner_Location (int p_Practitioner_OID, int p_Location_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitioner_LocationHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);
                query.SetParameter ("p_Location_OID", p_Location_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Interval (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerSurnames_IntervalHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Interval_Active (string p_Practitioner_surnames, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, bool ? p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerSurnames_Interval_ActiveHQL");
                query.SetParameter ("p_Practitioner_surnames", p_Practitioner_surnames);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif (string p_Practitioner_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerNifHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_Active (string p_Practitioner_Surnames, bool ? p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerSurnames_ActiveHQL");
                query.SetParameter ("p_Practitioner_Surnames", p_Practitioner_Surnames);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesBySpecialtyDisplay_Active (string p_Specialty_display, bool ? p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesBySpecialtyDisplay_ActiveHQL");
                query.SetParameter ("p_Specialty_display", p_Specialty_display);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSpecialty_LocationName_Active (string p_Specialty_display, string p_Location_name, bool ? p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerSpecialty_LocationName_ActiveHQL");
                query.SetParameter ("p_Specialty_display", p_Specialty_display);
                query.SetParameter ("p_Location_name", p_Location_name);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerSurnames_LocationName_Active (string p_Practitioner_surnames, string p_Location_name, string p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerSurnames_LocationName_ActiveHQL");
                query.SetParameter ("p_Practitioner_surnames", p_Practitioner_surnames);
                query.SetParameter ("p_Location_name", p_Location_name);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> GetSchedulesByPractitionerNif_LocationName_Active (string p_Practitioner_nif, string p_Location_name, bool ? p_active)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ScheduleEN self where FROM ScheduleEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ScheduleENgetSchedulesByPractitionerNif_LocationName_ActiveHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);
                query.SetParameter ("p_Location_name", p_Location_name);
                query.SetParameter ("p_active", p_active);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ScheduleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
