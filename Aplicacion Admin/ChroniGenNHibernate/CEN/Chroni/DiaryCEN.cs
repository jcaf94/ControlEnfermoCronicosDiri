

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
 *      Definition of the class DiaryCEN
 *
 */
public partial class DiaryCEN
{
private IDiaryCAD _IDiaryCAD;

public DiaryCEN()
{
        this._IDiaryCAD = new DiaryCAD ();
}

public DiaryCEN(IDiaryCAD _IDiaryCAD)
{
        this._IDiaryCAD = _IDiaryCAD;
}

public IDiaryCAD get_IDiaryCAD ()
{
        return this._IDiaryCAD;
}

public void Modify (int p_Diary_OID)
{
        DiaryEN diaryEN = null;

        //Initialized DiaryEN
        diaryEN = new DiaryEN ();
        diaryEN.Identifier = p_Diary_OID;
        //Call to DiaryCAD

        _IDiaryCAD.Modify (diaryEN);
}

public void Destroy (int identifier
                     )
{
        _IDiaryCAD.Destroy (identifier);
}

public DiaryEN ReadOID (int identifier
                        )
{
        DiaryEN diaryEN = null;

        diaryEN = _IDiaryCAD.ReadOID (identifier);
        return diaryEN;
}

public System.Collections.Generic.IList<DiaryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DiaryEN> list = null;

        list = _IDiaryCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitioner (int p_Practitioner_OID)
{
        return _IDiaryCAD.GetDiariesByPractitioner (p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitionerNif (string p_Practitioner_nif)
{
        return _IDiaryCAD.GetDiariesByPractitionerNif (p_Practitioner_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitionerSurnames (string p_Practitioner_surnames)
{
        return _IDiaryCAD.GetDiariesByPractitionerSurnames (p_Practitioner_surnames);
}
public void AssignPractitioner (int p_Diary_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        //Call to DiaryCAD

        _IDiaryCAD.AssignPractitioner (p_Diary_OID, p_practitioner_OIDs);
}
public void UnassignPractitioner (int p_Diary_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        //Call to DiaryCAD

        _IDiaryCAD.UnassignPractitioner (p_Diary_OID, p_practitioner_OIDs);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatient (int p_Patient_OID)
{
        return _IDiaryCAD.GetDiaryByPatient (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatientNif (string p_Patient_nif)
{
        return _IDiaryCAD.GetDiaryByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatientSurnames (string p_Patient_surnames)
{
        return _IDiaryCAD.GetDiaryByPatientSurnames (p_Patient_surnames);
}
}
}
