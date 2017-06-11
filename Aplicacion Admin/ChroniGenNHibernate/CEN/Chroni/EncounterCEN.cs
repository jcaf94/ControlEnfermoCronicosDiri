

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
 *      Definition of the class EncounterCEN
 *
 */
public partial class EncounterCEN
{
private IEncounterCAD _IEncounterCAD;

public EncounterCEN()
{
        this._IEncounterCAD = new EncounterCAD ();
}

public EncounterCEN(IEncounterCAD _IEncounterCAD)
{
        this._IEncounterCAD = _IEncounterCAD;
}

public IEncounterCAD get_IEncounterCAD ()
{
        return this._IEncounterCAD;
}

public int New_ (ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum p_status, ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum p_type, ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum p_priority, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, string p_reason, string p_serviceProvider, int p_patient, System.Collections.Generic.IList<int> p_practitioner, ChroniGenNHibernate.EN.Chroni.ConditionEN p_condition, int p_slot, string p_note)
{
        EncounterEN encounterEN = null;
        int oid;

        //Initialized EncounterEN
        encounterEN = new EncounterEN ();
        encounterEN.Status = p_status;

        encounterEN.Type = p_type;

        encounterEN.Priority = p_priority;

        encounterEN.StartDate = p_startDate;

        encounterEN.EndDate = p_endDate;

        encounterEN.Reason = p_reason;

        encounterEN.ServiceProvider = p_serviceProvider;


        if (p_patient != -1) {
                // El argumento p_patient -> Property patient es oid = false
                // Lista de oids identifier
                encounterEN.Patient = new ChroniGenNHibernate.EN.Chroni.PatientEN ();
                encounterEN.Patient.Identifier = p_patient;
        }


        encounterEN.Practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
        if (p_practitioner != null) {
                foreach (int item in p_practitioner) {
                        ChroniGenNHibernate.EN.Chroni.PractitionerEN en = new ChroniGenNHibernate.EN.Chroni.PractitionerEN ();
                        en.Identifier = item;
                        encounterEN.Practitioner.Add (en);
                }
        }

        else{
                encounterEN.Practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
        }

        encounterEN.Condition = p_condition;


        if (p_slot != -1) {
                // El argumento p_slot -> Property slot es oid = false
                // Lista de oids identifier
                encounterEN.Slot = new ChroniGenNHibernate.EN.Chroni.SlotEN ();
                encounterEN.Slot.Identifier = p_slot;
        }

        encounterEN.Note = p_note;

        //Call to EncounterCAD

        oid = _IEncounterCAD.New_ (encounterEN);
        return oid;
}

public void Modify (int p_Encounter_OID, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum p_status, ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum p_type, ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum p_priority, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, string p_reason, string p_serviceProvider, string p_note)
{
        EncounterEN encounterEN = null;

        //Initialized EncounterEN
        encounterEN = new EncounterEN ();
        encounterEN.Identifier = p_Encounter_OID;
        encounterEN.Status = p_status;
        encounterEN.Type = p_type;
        encounterEN.Priority = p_priority;
        encounterEN.StartDate = p_startDate;
        encounterEN.EndDate = p_endDate;
        encounterEN.Reason = p_reason;
        encounterEN.ServiceProvider = p_serviceProvider;
        encounterEN.Note = p_note;
        //Call to EncounterCAD

        _IEncounterCAD.Modify (encounterEN);
}

public void Destroy (int identifier
                     )
{
        _IEncounterCAD.Destroy (identifier);
}

public EncounterEN ReadOID (int identifier
                            )
{
        EncounterEN encounterEN = null;

        encounterEN = _IEncounterCAD.ReadOID (identifier);
        return encounterEN;
}

public System.Collections.Generic.IList<EncounterEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EncounterEN> list = null;

        list = _IEncounterCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient (int p_Patient_OID)
{
        return _IEncounterCAD.GetEncountersByPatient (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Status (string p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status)
{
        return _IEncounterCAD.GetEncountersByPatient_Status (p_Patient_OID, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IEncounterCAD.GetEncountersByPatient_Interval (p_Patient_OID, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatient_Practitioner (int p_Patient_OID)
{
        return _IEncounterCAD.GetEncountersByPatient_Practitioner (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitioner (int p_Practitioner_OID)
{
        return _IEncounterCAD.GetEncountersByPractitioner (p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEnconntersByPractitioner_Status (int p_Practitioner_OID, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status)
{
        return _IEncounterCAD.GetEnconntersByPractitioner_Status (p_Practitioner_OID, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCategory (ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum ? p_ConditionCategory)
{
        return _IEncounterCAD.GetEncountersByConditionCategory (p_ConditionCategory);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByCondidionClinicalStatus (ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum ? p_Condition_clinicalStatus)
{
        return _IEncounterCAD.GetEncountersByCondidionClinicalStatus (p_Condition_clinicalStatus);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCodeCode (string p_Condition_code)
{
        return _IEncounterCAD.GetEncountersByConditionCodeCode (p_Condition_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByConditionCodeDisplay (string p_ConditionCode_display)
{
        return _IEncounterCAD.GetEncountersByConditionCodeDisplay (p_ConditionCode_display);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif (string p_Patient_nif)
{
        return _IEncounterCAD.GetEncountersByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif (string p_Practitioner_nif)
{
        return _IEncounterCAD.GetEncountersByPractitionerNif (p_Practitioner_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames)
{
        return _IEncounterCAD.GetEncountersByPatientName_Surnames (p_Patient_name, p_Patient_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerName_Surnames ()
{
        return _IEncounterCAD.GetEncountersByPractitionerName_Surnames ();
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersBySpecialtyCode (string p_SpecialtyCode)
{
        return _IEncounterCAD.GetEncountersBySpecialtyCode (p_SpecialtyCode);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersBySpecialtyDisplay (string p_Specialty_Display)
{
        return _IEncounterCAD.GetEncountersBySpecialtyDisplay (p_Specialty_Display);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_PractitionerSpecialtyDisplay (string p_Patient_nif, string p_Specialty_display)
{
        return _IEncounterCAD.GetEncountersByPatientNif_PractitionerSpecialtyDisplay (p_Patient_nif, p_Specialty_display);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByInterval_Priority (Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.EncounterPriorityEnum ? p_priority)
{
        return _IEncounterCAD.GetEncountersByInterval_Priority (p_dateFrom, p_dateTo, p_priority);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_Status (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_status)
{
        return _IEncounterCAD.GetEncountersByPatientNif_Status (p_Patient_nif, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_Interval (string p_patient_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IEncounterCAD.GetEncountersByPatientNif_Interval (p_patient_nif, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPatientNif_PractitionerName_Surnames (string p_Patient_nif, string p_Practitioner_name, string p_Practitioner_surnames)
{
        return _IEncounterCAD.GetEncountersByPatientNif_PractitionerName_Surnames (p_Patient_nif, p_Practitioner_name, p_Practitioner_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif_Interval (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IEncounterCAD.GetEncountersByPractitionerNif_Interval (p_Practitioner_nif, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.EncounterEN> GetEncountersByPractitionerNif_Status ()
{
        return _IEncounterCAD.GetEncountersByPractitionerNif_Status ();
}
public void AssignCarePlan (int p_Encounter_OID, System.Collections.Generic.IList<int> p_carePlan_OIDs)
{
        //Call to EncounterCAD

        _IEncounterCAD.AssignCarePlan (p_Encounter_OID, p_carePlan_OIDs);
}
public void UnassignCarePlan (int p_Encounter_OID, System.Collections.Generic.IList<int> p_carePlan_OIDs)
{
        //Call to EncounterCAD

        _IEncounterCAD.UnassignCarePlan (p_Encounter_OID, p_carePlan_OIDs);
}
}
}
