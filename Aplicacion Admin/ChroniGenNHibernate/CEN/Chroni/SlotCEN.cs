

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;

using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


namespace ChroniGenNHibernate.CEN.Chroni
{
/*
 *      Definition of the class SlotCEN
 *
 */
public partial class SlotCEN
{
private ISlotCAD _ISlotCAD;

public SlotCEN()
{
        this._ISlotCAD = new SlotCAD ();
}

public SlotCEN(ISlotCAD _ISlotCAD)
{
        this._ISlotCAD = _ISlotCAD;
}

public ISlotCAD get_ISlotCAD ()
{
        return this._ISlotCAD;
}

public int New_ (ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum p_status, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, string p_note, int p_schedule)
{
        SlotEN slotEN = null;
        int oid;

        //Initialized SlotEN
        slotEN = new SlotEN ();
        slotEN.Status = p_status;

        slotEN.StartDate = p_startDate;

        slotEN.EndDate = p_endDate;

        slotEN.Note = p_note;


        if (p_schedule != -1) {
                // El argumento p_schedule -> Property schedule es oid = false
                // Lista de oids identifier
                slotEN.Schedule = new ChroniGenNHibernate.EN.Chroni.ScheduleEN ();
                slotEN.Schedule.Identifier = p_schedule;
        }

        //Call to SlotCAD

        oid = _ISlotCAD.New_ (slotEN);
        return oid;
}

public void Modify (int p_Slot_OID, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum p_status, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, string p_note)
{
        SlotEN slotEN = null;

        //Initialized SlotEN
        slotEN = new SlotEN ();
        slotEN.Identifier = p_Slot_OID;
        slotEN.Status = p_status;
        slotEN.StartDate = p_startDate;
        slotEN.EndDate = p_endDate;
        slotEN.Note = p_note;
        //Call to SlotCAD

        _ISlotCAD.Modify (slotEN);
}

public void Destroy (int identifier
                     )
{
        _ISlotCAD.Destroy (identifier);
}

public SlotEN ReadOID (int identifier
                       )
{
        SlotEN slotEN = null;

        slotEN = _ISlotCAD.ReadOID (identifier);
        return slotEN;
}

public System.Collections.Generic.IList<SlotEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SlotEN> list = null;

        list = _ISlotCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitioner_Interval_Status_LocationName (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum? p_status, string p_Location_name)
{
        return _ISlotCAD.GetSlotsByPractitioner_Interval_Status_LocationName (p_Practitioner_OID, p_dateFrom, p_dateTo, p_status, p_Location_name);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _ISlotCAD.GetSlotsByPatient_Interval (p_Patient_OID, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitionerNif_Interval_Status (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum ? p_status)
{
        return _ISlotCAD.GetSlotsByPractitionerNif_Interval_Status (p_Practitioner_nif, p_dateFrom, p_dateTo, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitionerNif_Interval_Status_LocationName (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum? p_status, string p_Location_name)
{
        return _ISlotCAD.GetSlotsByPractitionerNif_Interval_Status_LocationName (p_Practitioner_nif, p_dateFrom, p_dateTo, p_status, p_Location_name);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatientNif (string p_Patient_nif)
{
        return _ISlotCAD.GetSlotsByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatientName_Surnames (string p_Patient_name, string p_Parient_surnames)
{
        return _ISlotCAD.GetSlotsByPatientName_Surnames (p_Patient_name, p_Parient_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByEncounterType (ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum ? p_Encounter_type)
{
        return _ISlotCAD.GetSlotsByEncounterType (p_Encounter_type);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByEncounterStatus (ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_Encounter_status)
{
        return _ISlotCAD.GetSlotsByEncounterStatus (p_Encounter_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsBySpecialtyDisplay_LocationName_Interval_Status (string p_Specialty_display, string p_Location_name, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_date_to, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum ? p_status)
{
        return _ISlotCAD.GetSlotsBySpecialtyDisplay_LocationName_Interval_Status (p_Specialty_display, p_Location_name, p_dateFrom, p_date_to, p_status);
}
public void AssignEncounter (int p_Slot_OID, int p_encounter_OID)
{
        //Call to SlotCAD

        _ISlotCAD.AssignEncounter (p_Slot_OID, p_encounter_OID);
}
public void UnassignEncounter (int p_Slot_OID, int p_encounter_OID)
{
        //Call to SlotCAD

        _ISlotCAD.UnassignEncounter (p_Slot_OID, p_encounter_OID);
}
}
}
