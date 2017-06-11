

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
 *      Definition of the class ActivityCEN
 *
 */
public partial class ActivityCEN
{
private IActivityCAD _IActivityCAD;

public ActivityCEN()
{
        this._IActivityCAD = new ActivityCAD ();
}

public ActivityCEN(IActivityCAD _IActivityCAD)
{
        this._IActivityCAD = _IActivityCAD;
}

public IActivityCAD get_IActivityCAD ()
{
        return this._IActivityCAD;
}

public int New_ (string p_progress, string p_description, int p_carePlan, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate)
{
        ActivityEN activityEN = null;
        int oid;

        //Initialized ActivityEN
        activityEN = new ActivityEN ();
        activityEN.Progress = p_progress;

        activityEN.Description = p_description;


        if (p_carePlan != -1) {
                // El argumento p_carePlan -> Property carePlan es oid = false
                // Lista de oids identifier
                activityEN.CarePlan = new ChroniGenNHibernate.EN.Chroni.CarePlanEN ();
                activityEN.CarePlan.Identifier = p_carePlan;
        }

        activityEN.StartDate = p_startDate;

        activityEN.EndDate = p_endDate;

        //Call to ActivityCAD

        oid = _IActivityCAD.New_ (activityEN);
        return oid;
}

public void Modify (int p_Activity_OID, string p_progress, string p_description, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate)
{
        ActivityEN activityEN = null;

        //Initialized ActivityEN
        activityEN = new ActivityEN ();
        activityEN.Identifier = p_Activity_OID;
        activityEN.Progress = p_progress;
        activityEN.Description = p_description;
        activityEN.StartDate = p_startDate;
        activityEN.EndDate = p_endDate;
        //Call to ActivityCAD

        _IActivityCAD.Modify (activityEN);
}

public void Destroy (int identifier
                     )
{
        _IActivityCAD.Destroy (identifier);
}

public ActivityEN ReadOID (int identifier
                           )
{
        ActivityEN activityEN = null;

        activityEN = _IActivityCAD.ReadOID (identifier);
        return activityEN;
}

public System.Collections.Generic.IList<ActivityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ActivityEN> list = null;

        list = _IActivityCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByInterval (Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IActivityCAD.GetActivitiesByInterval (p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IActivityCAD.GetActivitiesByPatient_Interval (p_Patient_OID, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPractitioner_Interval (int p_Practitioner_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IActivityCAD.GetActivitiesByPractitioner_Interval (p_Practitioner_OID, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByCarePlan (int p_CarePlan_OID)
{
        return _IActivityCAD.GetActivitiesByCarePlan (p_CarePlan_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByCarePlanCategoryDisplay (string p_CarePlanCategory_display)
{
        return _IActivityCAD.GetActivitiesByCarePlanCategoryDisplay (p_CarePlanCategory_display);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatientNif (string p_Patient_nif)
{
        return _IActivityCAD.GetActivitiesByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivityByPractitionerNif (string p_Practitioner_nif)
{
        return _IActivityCAD.GetActivityByPractitionerNif (p_Practitioner_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByPatientNif_Description (string p_Patient_nif, string p_description)
{
        return _IActivityCAD.GetActivitiesByPatientNif_Description (p_Patient_nif, p_description);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByDescription ()
{
        return _IActivityCAD.GetActivitiesByDescription ();
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ActivityEN> GetActivitiesByMedicationName (string p_Medication_name)
{
        return _IActivityCAD.GetActivitiesByMedicationName (p_Medication_name);
}
public void AssignMedication (int p_Activity_OID, System.Collections.Generic.IList<int> p_medication_OIDs)
{
        //Call to ActivityCAD

        _IActivityCAD.AssignMedication (p_Activity_OID, p_medication_OIDs);
}
public void UnassignMedication (int p_Activity_OID, System.Collections.Generic.IList<int> p_medication_OIDs)
{
        //Call to ActivityCAD

        _IActivityCAD.UnassignMedication (p_Activity_OID, p_medication_OIDs);
}
}
}
