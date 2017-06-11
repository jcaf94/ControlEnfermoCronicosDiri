
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
 * Clase Slot:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class SlotCAD : BasicCAD, ISlotCAD
{
public SlotCAD() : base ()
{
}

public SlotCAD(ISession sessionAux) : base (sessionAux)
{
}



public SlotEN ReadOIDDefault (int identifier
                              )
{
        SlotEN slotEN = null;

        try
        {
                SessionInitializeTransaction ();
                slotEN = (SlotEN)session.Get (typeof(SlotEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return slotEN;
}

public System.Collections.Generic.IList<SlotEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SlotEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SlotEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SlotEN>();
                        else
                                result = session.CreateCriteria (typeof(SlotEN)).List<SlotEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SlotEN slot)
{
        try
        {
                SessionInitializeTransaction ();
                SlotEN slotEN = (SlotEN)session.Load (typeof(SlotEN), slot.Identifier);

                slotEN.Status = slot.Status;


                slotEN.StartDate = slot.StartDate;


                slotEN.EndDate = slot.EndDate;


                slotEN.Note = slot.Note;



                session.Update (slotEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SlotEN slot)
{
        try
        {
                SessionInitializeTransaction ();
                if (slot.Schedule != null) {
                        // Argumento OID y no colección.
                        slot.Schedule = (ChroniGenNHibernate.EN.Chroni.ScheduleEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.ScheduleEN), slot.Schedule.Identifier);

                        slot.Schedule.Slot
                        .Add (slot);
                }

                session.Save (slot);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return slot.Identifier;
}

public void Modify (SlotEN slot)
{
        try
        {
                SessionInitializeTransaction ();
                SlotEN slotEN = (SlotEN)session.Load (typeof(SlotEN), slot.Identifier);

                slotEN.Status = slot.Status;


                slotEN.StartDate = slot.StartDate;


                slotEN.EndDate = slot.EndDate;


                slotEN.Note = slot.Note;

                session.Update (slotEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
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
                SlotEN slotEN = (SlotEN)session.Load (typeof(SlotEN), identifier);
                session.Delete (slotEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SlotEN
public SlotEN ReadOID (int identifier
                       )
{
        SlotEN slotEN = null;

        try
        {
                SessionInitializeTransaction ();
                slotEN = (SlotEN)session.Get (typeof(SlotEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return slotEN;
}

public System.Collections.Generic.IList<SlotEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SlotEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SlotEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SlotEN>();
                else
                        result = session.CreateCriteria (typeof(SlotEN)).List<SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitioner_Interval_Status_LocationName (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum? p_status, string p_Location_name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByPractitioner_Interval_Status_LocationNameHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);
                query.SetParameter ("p_status", p_status);
                query.SetParameter ("p_Location_name", p_Location_name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByPatient_IntervalHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitionerNif_Interval_Status (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByPractitionerNif_Interval_StatusHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitionerNif_Interval_Status_LocationName (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum? p_status, string p_Location_name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByPractitionerNif_Interval_Status_LocationNameHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_dateTo", p_dateTo);
                query.SetParameter ("p_status", p_status);
                query.SetParameter ("p_Location_name", p_Location_name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatientName_Surnames (string p_Patient_name, string p_Parient_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByPatientName_SurnamesHQL");
                query.SetParameter ("p_Patient_name", p_Patient_name);
                query.SetParameter ("p_Parient_surnames", p_Parient_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByEncounterType (ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum ? p_Encounter_type)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByEncounterTypeHQL");
                query.SetParameter ("p_Encounter_type", p_Encounter_type);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByEncounterStatus (ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_Encounter_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsByEncounterStatusHQL");
                query.SetParameter ("p_Encounter_status", p_Encounter_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsBySpecialtyDisplay_LocationName_Interval_Status (string p_Specialty_display, string p_Location_name, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_date_to, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum ? p_status)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SlotEN self where FROM SlotEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SlotENgetSlotsBySpecialtyDisplay_LocationName_Interval_StatusHQL");
                query.SetParameter ("p_Specialty_display", p_Specialty_display);
                query.SetParameter ("p_Location_name", p_Location_name);
                query.SetParameter ("p_dateFrom", p_dateFrom);
                query.SetParameter ("p_date_to", p_date_to);
                query.SetParameter ("p_status", p_status);

                result = query.List<ChroniGenNHibernate.EN.Chroni.SlotEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignEncounter (int p_Slot_OID, int p_encounter_OID)
{
        ChroniGenNHibernate.EN.Chroni.SlotEN slotEN = null;
        try
        {
                SessionInitializeTransaction ();
                slotEN = (SlotEN)session.Load (typeof(SlotEN), p_Slot_OID);
                slotEN.Encounter = (ChroniGenNHibernate.EN.Chroni.EncounterEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.EncounterEN), p_encounter_OID);

                slotEN.Encounter.Slot = slotEN;




                session.Update (slotEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignEncounter (int p_Slot_OID, int p_encounter_OID)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.SlotEN slotEN = null;
                slotEN = (SlotEN)session.Load (typeof(SlotEN), p_Slot_OID);

                if (slotEN.Encounter.Identifier == p_encounter_OID) {
                        slotEN.Encounter = null;
                        ChroniGenNHibernate.EN.Chroni.EncounterEN encounterEN = (ChroniGenNHibernate.EN.Chroni.EncounterEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.EncounterEN), p_encounter_OID);
                        encounterEN.Slot = null;
                }
                else
                        throw new ModelException ("The identifier " + p_encounter_OID + " in p_encounter_OID you are trying to unrelationer, doesn't exist in SlotEN");

                session.Update (slotEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in SlotCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
