

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
 *      Definition of the class ReclamationCEN
 *
 */
public partial class ReclamationCEN
{
private IReclamationCAD _IReclamationCAD;

public ReclamationCEN()
{
        this._IReclamationCAD = new ReclamationCAD ();
}

public ReclamationCEN(IReclamationCAD _IReclamationCAD)
{
        this._IReclamationCAD = _IReclamationCAD;
}

public IReclamationCAD get_IReclamationCAD ()
{
        return this._IReclamationCAD;
}

public void Modify (int p_Reclamation_OID, ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum p_action, string p_subject, string p_content, Nullable<DateTime> p_startDate, string p_note, bool p_resolved, ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum p_type)
{
        ReclamationEN reclamationEN = null;

        //Initialized ReclamationEN
        reclamationEN = new ReclamationEN ();
        reclamationEN.Identifier = p_Reclamation_OID;
        reclamationEN.Action = p_action;
        reclamationEN.Subject = p_subject;
        reclamationEN.Content = p_content;
        reclamationEN.StartDate = p_startDate;
        reclamationEN.Note = p_note;
        reclamationEN.Resolved = p_resolved;
        reclamationEN.Type = p_type;
        //Call to ReclamationCAD

        _IReclamationCAD.Modify (reclamationEN);
}

public void Destroy (int identifier
                     )
{
        _IReclamationCAD.Destroy (identifier);
}

public ReclamationEN ReadOID (int identifier
                              )
{
        ReclamationEN reclamationEN = null;

        reclamationEN = _IReclamationCAD.ReadOID (identifier);
        return reclamationEN;
}

public System.Collections.Generic.IList<ReclamationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReclamationEN> list = null;

        list = _IReclamationCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByStartInterval (Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        return _IReclamationCAD.GetReclamationsByStartInterval (p_startDateFrom, p_startDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByResolved_ResponseInterval (bool? p_resolved, Nullable<DateTime> p_ReclamationResponse_createdDateFrom, Nullable<DateTime> p_ReclamationResponse_createdDateTo)
{
        return _IReclamationCAD.GetReclamationsByResolved_ResponseInterval (p_resolved, p_ReclamationResponse_createdDateFrom, p_ReclamationResponse_createdDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitionerNif (string p_Practitioner_nif)
{
        return _IReclamationCAD.GetReclamationsByPractitionerNif (p_Practitioner_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByType_StartInterval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum? p_type, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        return _IReclamationCAD.GetReclamationsByType_StartInterval (p_type, p_startDateFrom, p_startDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByResolved_StartInterval (bool? p_resolved, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        return _IReclamationCAD.GetReclamationsByResolved_StartInterval (p_resolved, p_startDateFrom, p_startDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByAction_StartInterval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum? p_reclamationType, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        return _IReclamationCAD.GetReclamationsByAction_StartInterval (p_reclamationType, p_startDateFrom, p_startDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByAction_StartInterval_Patient (ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum? p_action, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo, int p_Patient_OID)
{
        return _IReclamationCAD.GetReclamationsByAction_StartInterval_Patient (p_action, p_startDateFrom, p_startDateTo, p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByRelatedPersonNif (string p_RelatedPerson_nif)
{
        return _IReclamationCAD.GetReclamationByRelatedPersonNif (p_RelatedPerson_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByAction_StartInterval_RelatedPerson (ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum? p_action, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo, int p_RelatedPerson_OID)
{
        return _IReclamationCAD.GetReclamationByAction_StartInterval_RelatedPerson (p_action, p_startDateFrom, p_startDateTo, p_RelatedPerson_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByEndInterval (Nullable<DateTime> p_ReclamationResponse_createdDateFrom, Nullable<DateTime> p_ReclamationResponse_createdDateTo)
{
        return _IReclamationCAD.GetReclamationByEndInterval (p_ReclamationResponse_createdDateFrom, p_ReclamationResponse_createdDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPersonNif (string p_RelatedPerson_nif)
{
        return _IReclamationCAD.GetReclamationsByRelatedPersonNif (p_RelatedPerson_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByPatientNif (string p_Patient_nif)
{
        return _IReclamationCAD.GetReclamationByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPatient (int p_patient)
{
        return _IReclamationCAD.GetReclamationsByPatient (p_patient);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPerson (int p_RelatedPerson_OID)
{
        return _IReclamationCAD.GetReclamationsByRelatedPerson (p_RelatedPerson_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitioner (int p_Practitioner_OID)
{
        return _IReclamationCAD.GetReclamationsByPractitioner (p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByReclamationResponseActionState (ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum ? p_ReclamationResponse_actionState)
{
        return _IReclamationCAD.GetReclamationByReclamationResponseActionState (p_ReclamationResponse_actionState);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPatientSurnames (string p_Patient_surnames)
{
        return _IReclamationCAD.GetReclamationsByPatientSurnames (p_Patient_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPersonSurnames (string p_RelatedPerson_surnames)
{
        return _IReclamationCAD.GetReclamationsByRelatedPersonSurnames (p_RelatedPerson_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitionerSurnames (string p_Practitioner_surnames)
{
        return _IReclamationCAD.GetReclamationsByPractitionerSurnames (p_Practitioner_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsBySubject (string p_subject)
{
        return _IReclamationCAD.GetReclamationsBySubject (p_subject);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByContent (string p_content)
{
        return _IReclamationCAD.GetReclamationsByContent (p_content);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByNote (string p_note)
{
        return _IReclamationCAD.GetReclamationsByNote (p_note);
}
public void AssignPractitioner (int p_Reclamation_OID, int p_practitioner_OID)
{
        //Call to ReclamationCAD

        _IReclamationCAD.AssignPractitioner (p_Reclamation_OID, p_practitioner_OID);
}
public void UnassignPractitioner (int p_Reclamation_OID, int p_practitioner_OID)
{
        //Call to ReclamationCAD

        _IReclamationCAD.UnassignPractitioner (p_Reclamation_OID, p_practitioner_OID);
}
}
}
