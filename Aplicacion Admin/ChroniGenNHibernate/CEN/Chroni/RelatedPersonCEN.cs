

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
 *      Definition of the class RelatedPersonCEN
 *
 */
public partial class RelatedPersonCEN
{
private IRelatedPersonCAD _IRelatedPersonCAD;

public RelatedPersonCEN()
{
        this._IRelatedPersonCAD = new RelatedPersonCAD ();
}

public RelatedPersonCEN(IRelatedPersonCAD _IRelatedPersonCAD)
{
        this._IRelatedPersonCAD = _IRelatedPersonCAD;
}

public IRelatedPersonCAD get_IRelatedPersonCAD ()
{
        return this._IRelatedPersonCAD;
}

public int New_ (string p_nif, string p_name, string p_surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, string p_address, string p_email, string p_phone, string p_photo, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, String p_password, bool p_active)
{
        RelatedPersonEN relatedPersonEN = null;
        int oid;

        //Initialized RelatedPersonEN
        relatedPersonEN = new RelatedPersonEN ();
        relatedPersonEN.Nif = p_nif;

        relatedPersonEN.Name = p_name;

        relatedPersonEN.Surnames = p_surnames;

        relatedPersonEN.Gender = p_gender;

        relatedPersonEN.BirthDate = p_birthDate;

        relatedPersonEN.Address = p_address;

        relatedPersonEN.Email = p_email;

        relatedPersonEN.Phone = p_phone;

        relatedPersonEN.Photo = p_photo;

        relatedPersonEN.StartDate = p_startDate;

        relatedPersonEN.EndDate = p_endDate;

        relatedPersonEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        relatedPersonEN.Active = p_active;

        //Call to RelatedPersonCAD

        oid = _IRelatedPersonCAD.New_ (relatedPersonEN);
        return oid;
}

public void Modify (int p_RelatedPerson_OID, string p_nif, string p_name, string p_surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, string p_address, string p_email, string p_phone, string p_photo, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, String p_password, bool p_active)
{
        RelatedPersonEN relatedPersonEN = null;

        //Initialized RelatedPersonEN
        relatedPersonEN = new RelatedPersonEN ();
        relatedPersonEN.Identifier = p_RelatedPerson_OID;
        relatedPersonEN.Nif = p_nif;
        relatedPersonEN.Name = p_name;
        relatedPersonEN.Surnames = p_surnames;
        relatedPersonEN.Gender = p_gender;
        relatedPersonEN.BirthDate = p_birthDate;
        relatedPersonEN.Address = p_address;
        relatedPersonEN.Email = p_email;
        relatedPersonEN.Phone = p_phone;
        relatedPersonEN.Photo = p_photo;
        relatedPersonEN.StartDate = p_startDate;
        relatedPersonEN.EndDate = p_endDate;
        relatedPersonEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        relatedPersonEN.Active = p_active;
        //Call to RelatedPersonCAD

        _IRelatedPersonCAD.Modify (relatedPersonEN);
}

public void Destroy (int identifier
                     )
{
        _IRelatedPersonCAD.Destroy (identifier);
}

public RelatedPersonEN ReadOID (int identifier
                                )
{
        RelatedPersonEN relatedPersonEN = null;

        relatedPersonEN = _IRelatedPersonCAD.ReadOID (identifier);
        return relatedPersonEN;
}

public System.Collections.Generic.IList<RelatedPersonEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RelatedPersonEN> list = null;

        list = _IRelatedPersonCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByRelationship (ChroniGenNHibernate.Enumerated.Chroni.RelationshipEnum ? p_Relationship_relationship)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByRelationship (p_Relationship_relationship);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByGender (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum ? p_gender)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByGender (p_gender);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByName_Surnames (string p_name, string p_surnames)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByName_Surnames (p_name, p_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByName_Surnames_BirthDate (string p_name, string p_surnames, Nullable<DateTime> p_birthDate)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByName_Surnames_BirthDate (p_name, p_surnames, p_birthDate);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonByNif (string p_nif)
{
        return _IRelatedPersonCAD.GetRelatedPersonByNif (p_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonByPatientNif (string p_patientNif)
{
        return _IRelatedPersonCAD.GetRelatedPersonByPatientNif (p_patientNif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientSurnames (string p_Patient_surnames)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByPatientSurnames (p_Patient_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByPatientName_Surnames (p_Patient_name, p_Patient_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsBySurnames (string p_surnames)
{
        return _IRelatedPersonCAD.GetRelatedPersonsBySurnames (p_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientNif_Interval (string p_Patient_nif, string p_StartDateFrom, string p_endDateTo)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByPatientNif_Interval (p_Patient_nif, p_StartDateFrom, p_endDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPatientNif_Active (string p_Patient_nif, bool ? p_active)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByPatientNif_Active (p_Patient_nif, p_active);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByPhone (string p_phone)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByPhone (p_phone);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelatedPersonEN> GetRelatedPersonsByEmail (string p_email)
{
        return _IRelatedPersonCAD.GetRelatedPersonsByEmail (p_email);
}
public void AssignPatient (int p_RelatedPerson_OID, System.Collections.Generic.IList<int> p_patient_OIDs)
{
        //Call to RelatedPersonCAD

        _IRelatedPersonCAD.AssignPatient (p_RelatedPerson_OID, p_patient_OIDs);
}
public void UnassignPatient (int p_RelatedPerson_OID, System.Collections.Generic.IList<int> p_patient_OIDs)
{
        //Call to RelatedPersonCAD

        _IRelatedPersonCAD.UnassignPatient (p_RelatedPerson_OID, p_patient_OIDs);
}
}
}
