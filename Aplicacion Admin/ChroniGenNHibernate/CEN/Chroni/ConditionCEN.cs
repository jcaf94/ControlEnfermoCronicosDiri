

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
 *      Definition of the class ConditionCEN
 *
 */
public partial class ConditionCEN
{
private IConditionCAD _IConditionCAD;

public ConditionCEN()
{
        this._IConditionCAD = new ConditionCAD ();
}

public ConditionCEN(IConditionCAD _IConditionCAD)
{
        this._IConditionCAD = _IConditionCAD;
}

public IConditionCAD get_IConditionCAD ()
{
        return this._IConditionCAD;
}

public int New_ (int p_encounter, ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum p_category, ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum p_clinicalStatus, ChroniGenNHibernate.Enumerated.Chroni.ConditionSeverityEnum p_severity, string p_onset, string p_abatement, string p_note)
{
        ConditionEN conditionEN = null;
        int oid;

        //Initialized ConditionEN
        conditionEN = new ConditionEN ();

        if (p_encounter != -1) {
                // El argumento p_encounter -> Property encounter es oid = false
                // Lista de oids identifier
                conditionEN.Encounter = new ChroniGenNHibernate.EN.Chroni.EncounterEN ();
                conditionEN.Encounter.Identifier = p_encounter;
        }

        conditionEN.Category = p_category;

        conditionEN.ClinicalStatus = p_clinicalStatus;

        conditionEN.Severity = p_severity;

        conditionEN.Onset = p_onset;

        conditionEN.Abatement = p_abatement;

        conditionEN.Note = p_note;

        //Call to ConditionCAD

        oid = _IConditionCAD.New_ (conditionEN);
        return oid;
}

public void Modify (int p_Condition_OID, ChroniGenNHibernate.Enumerated.Chroni.ConditionCategoryEnum p_category, ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum p_clinicalStatus, ChroniGenNHibernate.Enumerated.Chroni.ConditionSeverityEnum p_severity, string p_onset, string p_abatement, string p_note)
{
        ConditionEN conditionEN = null;

        //Initialized ConditionEN
        conditionEN = new ConditionEN ();
        conditionEN.Identifier = p_Condition_OID;
        conditionEN.Category = p_category;
        conditionEN.ClinicalStatus = p_clinicalStatus;
        conditionEN.Severity = p_severity;
        conditionEN.Onset = p_onset;
        conditionEN.Abatement = p_abatement;
        conditionEN.Note = p_note;
        //Call to ConditionCAD

        _IConditionCAD.Modify (conditionEN);
}

public void Destroy (int identifier
                     )
{
        _IConditionCAD.Destroy (identifier);
}

public ConditionEN ReadOID (int identifier
                            )
{
        ConditionEN conditionEN = null;

        conditionEN = _IConditionCAD.ReadOID (identifier);
        return conditionEN;
}

public System.Collections.Generic.IList<ConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConditionEN> list = null;

        list = _IConditionCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByPatient (int p_Patient_OID)
{
        return _IConditionCAD.GetConditionsByPatient (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByPatient_ClinicalStatus (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum ? p_clnicalStatus)
{
        return _IConditionCAD.GetConditionsByPatient_ClinicalStatus (p_Patient_OID, p_clnicalStatus);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByConditionCodeCode (string p_ConditionCode_code)
{
        return _IConditionCAD.GetConditionsByConditionCodeCode (p_ConditionCode_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByConditionCode_Display (string p_ConditionCode_Display)
{
        return _IConditionCAD.GetConditionsByConditionCode_Display (p_ConditionCode_Display);
}
public void AssignConditionCode (int p_Condition_OID, int p_conditionCode_OID)
{
        //Call to ConditionCAD

        _IConditionCAD.AssignConditionCode (p_Condition_OID, p_conditionCode_OID);
}
public void UnassignConditionCode (int p_Condition_OID, int p_conditionCode_OID)
{
        //Call to ConditionCAD

        _IConditionCAD.UnassignConditionCode (p_Condition_OID, p_conditionCode_OID);
}
}
}
