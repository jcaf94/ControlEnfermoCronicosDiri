

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
 *      Definition of the class GoalCEN
 *
 */
public partial class GoalCEN
{
private IGoalCAD _IGoalCAD;

public GoalCEN()
{
        this._IGoalCAD = new GoalCAD ();
}

public GoalCEN(IGoalCAD _IGoalCAD)
{
        this._IGoalCAD = _IGoalCAD;
}

public IGoalCAD get_IGoalCAD ()
{
        return this._IGoalCAD;
}

public int New_ (string p_subject, Nullable<DateTime> p_statusDate, string p_target, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum p_category, string p_description, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum p_status, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum p_priority, string p_note, int p_carePlan)
{
        GoalEN goalEN = null;
        int oid;

        //Initialized GoalEN
        goalEN = new GoalEN ();
        goalEN.Subject = p_subject;

        goalEN.StatusDate = p_statusDate;

        goalEN.Target = p_target;

        goalEN.Category = p_category;

        goalEN.Description = p_description;

        goalEN.Status = p_status;

        goalEN.Priority = p_priority;

        goalEN.Note = p_note;


        if (p_carePlan != -1) {
                // El argumento p_carePlan -> Property carePlan es oid = false
                // Lista de oids identifier
                goalEN.CarePlan = new ChroniGenNHibernate.EN.Chroni.CarePlanEN ();
                goalEN.CarePlan.Identifier = p_carePlan;
        }

        //Call to GoalCAD

        oid = _IGoalCAD.New_ (goalEN);
        return oid;
}

public void Modify (int p_Goal_OID, string p_subject, Nullable<DateTime> p_statusDate, string p_target, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum p_category, string p_description, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum p_status, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum p_priority, string p_note)
{
        GoalEN goalEN = null;

        //Initialized GoalEN
        goalEN = new GoalEN ();
        goalEN.Identifier = p_Goal_OID;
        goalEN.Subject = p_subject;
        goalEN.StatusDate = p_statusDate;
        goalEN.Target = p_target;
        goalEN.Category = p_category;
        goalEN.Description = p_description;
        goalEN.Status = p_status;
        goalEN.Priority = p_priority;
        goalEN.Note = p_note;
        //Call to GoalCAD

        _IGoalCAD.Modify (goalEN);
}

public void Destroy (int identifier
                     )
{
        _IGoalCAD.Destroy (identifier);
}

public GoalEN ReadOID (int identifier
                       )
{
        GoalEN goalEN = null;

        goalEN = _IGoalCAD.ReadOID (identifier);
        return goalEN;
}

public System.Collections.Generic.IList<GoalEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<GoalEN> list = null;

        list = _IGoalCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetCoalsByPatient_Interval (int p_Patient_OID, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IGoalCAD.GetCoalsByPatient_Interval (p_Patient_OID, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Category_Interval (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IGoalCAD.GetGoalsByPatient_Category_Interval (p_Patient_OID, p_category, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status)
{
        return _IGoalCAD.GetGoalsByPatient_Status (p_Patient_OID, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Category_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status)
{
        return _IGoalCAD.GetGoalsByPatient_Category_Status (p_Patient_OID, p_category, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatient_Priority_Interval (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum? p_priority, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IGoalCAD.GetGoalsByPatient_Priority_Interval (p_Patient_OID, p_priority, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByCarePlan (int p_CarePlan_OID)
{
        return _IGoalCAD.GetGoalsByCarePlan (p_CarePlan_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif (string p_Patient_nif)
{
        return _IGoalCAD.GetGoalsByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Interval (string p_Patient_nif)
{
        return _IGoalCAD.GetGoalsByPatientNif_Interval (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Category_Status (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.GoalCategoryEnum? p_category, ChroniGenNHibernate.Enumerated.Chroni.GoalStatusEnum ? p_status)
{
        return _IGoalCAD.GetGoalsByPatientNif_Category_Status (p_Patient_nif, p_category, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.GoalEN> GetGoalsByPatientNif_Priority_Interval (string p_Patient_nif, ChroniGenNHibernate.Enumerated.Chroni.GoalPriorityEnum? p_priority, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IGoalCAD.GetGoalsByPatientNif_Priority_Interval (p_Patient_nif, p_priority, p_dateFrom, p_dateTo);
}
}
}
