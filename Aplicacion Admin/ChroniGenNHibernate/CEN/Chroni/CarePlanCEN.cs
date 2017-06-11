

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
 *      Definition of the class CarePlanCEN
 *
 */
public partial class CarePlanCEN
{
private ICarePlanCAD _ICarePlanCAD;

public CarePlanCEN()
{
        this._ICarePlanCAD = new CarePlanCAD ();
}

public CarePlanCEN(ICarePlanCAD _ICarePlanCAD)
{
        this._ICarePlanCAD = _ICarePlanCAD;
}

public ICarePlanCAD get_ICarePlanCAD ()
{
        return this._ICarePlanCAD;
}

public int New_ (string p_subject, ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum p_status, string p_context, Nullable<DateTime> p_startDate, Nullable<DateTime> p_modified, string p_description, string p_note, int p_encounter, Nullable<DateTime> p_endDate)
{
        CarePlanEN carePlanEN = null;
        int oid;

        //Initialized CarePlanEN
        carePlanEN = new CarePlanEN ();
        carePlanEN.Subject = p_subject;

        carePlanEN.Status = p_status;

        carePlanEN.Context = p_context;

        carePlanEN.StartDate = p_startDate;

        carePlanEN.Modified = p_modified;

        carePlanEN.Description = p_description;

        carePlanEN.Note = p_note;


        if (p_encounter != -1) {
                // El argumento p_encounter -> Property encounter es oid = false
                // Lista de oids identifier
                carePlanEN.Encounter = new ChroniGenNHibernate.EN.Chroni.EncounterEN ();
                carePlanEN.Encounter.Identifier = p_encounter;
        }

        carePlanEN.EndDate = p_endDate;

        //Call to CarePlanCAD

        oid = _ICarePlanCAD.New_ (carePlanEN);
        return oid;
}

public void Modify (int p_CarePlan_OID, string p_subject, ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum p_status, string p_context, Nullable<DateTime> p_startDate, Nullable<DateTime> p_modified, string p_description, string p_note, Nullable<DateTime> p_endDate)
{
        CarePlanEN carePlanEN = null;

        //Initialized CarePlanEN
        carePlanEN = new CarePlanEN ();
        carePlanEN.Identifier = p_CarePlan_OID;
        carePlanEN.Subject = p_subject;
        carePlanEN.Status = p_status;
        carePlanEN.Context = p_context;
        carePlanEN.StartDate = p_startDate;
        carePlanEN.Modified = p_modified;
        carePlanEN.Description = p_description;
        carePlanEN.Note = p_note;
        carePlanEN.EndDate = p_endDate;
        //Call to CarePlanCAD

        _ICarePlanCAD.Modify (carePlanEN);
}

public void Destroy (int identifier
                     )
{
        _ICarePlanCAD.Destroy (identifier);
}

public CarePlanEN ReadOID (int identifier
                           )
{
        CarePlanEN carePlanEN = null;

        carePlanEN = _ICarePlanCAD.ReadOID (identifier);
        return carePlanEN;
}

public System.Collections.Generic.IList<CarePlanEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanEN> list = null;

        list = _ICarePlanCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByCategoryCode_Period (string p_CarePlanCategory_code, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _ICarePlanCAD.GetCarePlansByCategoryCode_Period (p_CarePlanCategory_code, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByStatus_Period (ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum? p_status, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _ICarePlanCAD.GetCarePlansByStatus_Period (p_status, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient (int p_Patient_OID)
{
        return _ICarePlanCAD.GetCarePlansByPatient (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient_Practitioner (int p_Patient_OID, Nullable<DateTime> p_Practitioner_OID)
{
        return _ICarePlanCAD.GetCarePlansByPatient_Practitioner (p_Patient_OID, p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByPatient_Status (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.CarePlanStatusEnum ? p_status)
{
        return _ICarePlanCAD.GetCarePlansByPatient_Status (p_Patient_OID, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanEN> GetCarePlansByCategoryDisplay_Period (string p_CarePlanCategory_display, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _ICarePlanCAD.GetCarePlansByCategoryDisplay_Period (p_CarePlanCategory_display, p_dateFrom, p_dateTo);
}
public void AssignCategory (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_carePlanCategory_OIDs)
{
        //Call to CarePlanCAD

        _ICarePlanCAD.AssignCategory (p_CarePlan_OID, p_carePlanCategory_OIDs);
}
public void UnassignCategory (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_carePlanCategory_OIDs)
{
        //Call to CarePlanCAD

        _ICarePlanCAD.UnassignCategory (p_CarePlan_OID, p_carePlanCategory_OIDs);
}
public void AssignGoal (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_goal_OIDs)
{
        //Call to CarePlanCAD

        _ICarePlanCAD.AssignGoal (p_CarePlan_OID, p_goal_OIDs);
}
public void UnassignGoal (int p_CarePlan_OID, System.Collections.Generic.IList<int> p_goal_OIDs)
{
        //Call to CarePlanCAD

        _ICarePlanCAD.UnassignGoal (p_CarePlan_OID, p_goal_OIDs);
}
}
}
