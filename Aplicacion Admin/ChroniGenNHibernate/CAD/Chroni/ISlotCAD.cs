
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface ISlotCAD
{
SlotEN ReadOIDDefault (int identifier
                       );

void ModifyDefault (SlotEN slot);

System.Collections.Generic.IList<SlotEN> ReadAllDefault (int first, int size);



int New_ (SlotEN slot);

void Modify (SlotEN slot);


void Destroy (int identifier
              );


SlotEN ReadOID (int identifier
                );


System.Collections.Generic.IList<SlotEN> ReadAll (int first, int size);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitioner_Interval_Status_LocationName (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum? p_status, string p_Location_name);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitionerNif_Interval_Status (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPractitionerNif_Interval_Status_LocationName (string p_Practitioner_nif, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum? p_status, string p_Location_name);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatientNif (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByPatientName_Surnames (string p_Patient_name, string p_Parient_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByEncounterType (ChroniGenNHibernate.Enumerated.Chroni.EncounterTypeEnum ? p_Encounter_type);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsByEncounterStatus (ChroniGenNHibernate.Enumerated.Chroni.EncounterStatusEnum ? p_Encounter_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SlotEN> GetSlotsBySpecialtyDisplay_LocationName_Interval_Status (string p_Specialty_display, string p_Location_name, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_date_to, ChroniGenNHibernate.Enumerated.Chroni.SlotStatusEnum ? p_status);




void AssignEncounter (int p_Slot_OID, int p_encounter_OID);

void UnassignEncounter (int p_Slot_OID, int p_encounter_OID);
}
}
