

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
 *      Definition of the class PatientCEN
 *
 */
public partial class PatientCEN
{
private IPatientCAD _IPatientCAD;

public PatientCEN()
{
        this._IPatientCAD = new PatientCAD ();
}

public PatientCEN(IPatientCAD _IPatientCAD)
{
        this._IPatientCAD = _IPatientCAD;
}

public IPatientCAD get_IPatientCAD ()
{
        return this._IPatientCAD;
}

public int New_ (string p_nif, bool p_active, string p_name, string p_surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, bool p_deceased, string p_address, string p_email, string p_phone, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum p_maritalStatus, string p_photo, System.Collections.Generic.IList<int> p_location, ChroniGenNHibernate.EN.Chroni.DiaryEN p_diary, String p_password)
{
        PatientEN patientEN = null;
        int oid;

        //Initialized PatientEN
        patientEN = new PatientEN ();
        patientEN.Nif = p_nif;

        patientEN.Active = p_active;

        patientEN.Name = p_name;

        patientEN.Surnames = p_surnames;

        patientEN.Gender = p_gender;

        patientEN.BirthDate = p_birthDate;

        patientEN.Deceased = p_deceased;

        patientEN.Address = p_address;

        patientEN.Email = p_email;

        patientEN.Phone = p_phone;

        patientEN.MaritalStatus = p_maritalStatus;

        patientEN.Photo = p_photo;


        patientEN.Location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
        if (p_location != null) {
                foreach (int item in p_location) {
                        ChroniGenNHibernate.EN.Chroni.LocationEN en = new ChroniGenNHibernate.EN.Chroni.LocationEN ();
                        en.Identifier = item;
                        patientEN.Location.Add (en);
                }
        }

        else{
                patientEN.Location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
        }

        patientEN.Diary = p_diary;

        patientEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        //Call to PatientCAD

        oid = _IPatientCAD.New_ (patientEN);
        return oid;
}

public void Modify (int p_Patient_OID, string p_nif, bool p_active, string p_name, string p_surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, bool p_deceased, string p_address, string p_email, string p_phone, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum p_maritalStatus, string p_photo, String p_password)
{
        PatientEN patientEN = null;

        //Initialized PatientEN
        patientEN = new PatientEN ();
        patientEN.Identifier = p_Patient_OID;
        patientEN.Nif = p_nif;
        patientEN.Active = p_active;
        patientEN.Name = p_name;
        patientEN.Surnames = p_surnames;
        patientEN.Gender = p_gender;
        patientEN.BirthDate = p_birthDate;
        patientEN.Deceased = p_deceased;
        patientEN.Address = p_address;
        patientEN.Email = p_email;
        patientEN.Phone = p_phone;
        patientEN.MaritalStatus = p_maritalStatus;
        patientEN.Photo = p_photo;
        patientEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        //Call to PatientCAD

        _IPatientCAD.Modify (patientEN);
}

public void Destroy (int identifier
                     )
{
        _IPatientCAD.Destroy (identifier);
}

public PatientEN ReadOID (int identifier
                          )
{
        PatientEN patientEN = null;

        patientEN = _IPatientCAD.ReadOID (identifier);
        return patientEN;
}

public System.Collections.Generic.IList<PatientEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PatientEN> list = null;

        list = _IPatientCAD.ReadAll (first, size);
        return list;
}
public void AssignLocation (int p_Patient_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        //Call to PatientCAD

        _IPatientCAD.AssignLocation (p_Patient_OID, p_location_OIDs);
}
public void UnassignLocation (int p_Patient_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        //Call to PatientCAD

        _IPatientCAD.UnassignLocation (p_Patient_OID, p_location_OIDs);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByGender_Location (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, int p_location)
{
        return _IPatientCAD.GetPatientsByGender_Location (p_gender, p_location);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval_Location (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo, int p_location)
{
        return _IPatientCAD.GetPatientsByBirthInterval_Location (p_birthDateFrom, p_birthDateTo, p_location);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByActive_Location (bool? p_active, int p_location)
{
        return _IPatientCAD.GetPatientsByActive_Location (p_active, p_location);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByName_Surnames_Location (string p_name, string p_surname, int p_location)
{
        return _IPatientCAD.GetPatientsByName_Surnames_Location (p_name, p_surname, p_location);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientByNif (string p_nif)
{
        return _IPatientCAD.GetPatientByNif (p_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByGender_MaritalStatus (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, ChroniGenNHibernate.Enumerated.Chroni.MaritalStatusEnum ? p_maritalStatus)
{
        return _IPatientCAD.GetPatientsByGender_MaritalStatus (p_gender, p_maritalStatus);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval_Gender (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum ? p_gender)
{
        return _IPatientCAD.GetPatientsByBirthInterval_Gender (p_birthDateFrom, p_birthDateTo, p_gender);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCode (string p_conditionCode)
{
        return _IPatientCAD.GetPatientsByConditionCode (p_conditionCode);
}
public void AssignPractitioner (int p_Patient_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        //Call to PatientCAD

        _IPatientCAD.AssignPractitioner (p_Patient_OID, p_practitioner_OIDs);
}
public void UnassignPractitioner (int p_Patient_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        //Call to PatientCAD

        _IPatientCAD.UnassignPractitioner (p_Patient_OID, p_practitioner_OIDs);
}
public void AssignRelatedPerson (int p_Patient_OID, System.Collections.Generic.IList<int> p_relatedPerson_OIDs)
{
        //Call to PatientCAD

        _IPatientCAD.AssignRelatedPerson (p_Patient_OID, p_relatedPerson_OIDs);
}
public void UnassignRelatedPerson (int p_Patient_OID, System.Collections.Generic.IList<int> p_relatedPerson_OIDs)
{
        //Call to PatientCAD

        _IPatientCAD.UnassignRelatedPerson (p_Patient_OID, p_relatedPerson_OIDs);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByPractitionerNif (string p_practitionerNif)
{
        return _IPatientCAD.GetPatientsByPractitionerNif (p_practitionerNif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByRelatedPersonNif (string p_relatedPersonNif)
{
        return _IPatientCAD.GetPatientsByRelatedPersonNif (p_relatedPersonNif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByBirthInterval (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo)
{
        return _IPatientCAD.GetPatientsByBirthInterval (p_birthDateFrom, p_birthDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByNameSurnames (string p_name, string p_surnames)
{
        return _IPatientCAD.GetPatientsByNameSurnames (p_name, p_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByName_Surnames_BirthDate (string p_name, string p_surnames, Nullable<DateTime> p_birthDate)
{
        return _IPatientCAD.GetPatientsByName_Surnames_BirthDate (p_name, p_surnames, p_birthDate);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsBySurnames (string p_surnames)
{
        return _IPatientCAD.GetPatientsBySurnames (p_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByPhone (string p_phone)
{
        return _IPatientCAD.GetPatientsByPhone (p_phone);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByEmail (string p_email)
{
        return _IPatientCAD.GetPatientsByEmail (p_email);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByDeseased (bool ? p_deseased)
{
        return _IPatientCAD.GetPatientsByDeseased (p_deseased);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByEncounter (int p_Encounter_OID)
{
        return _IPatientCAD.GetPatientsByEncounter (p_Encounter_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCodeCode (string p_ConditionCode_code)
{
        return _IPatientCAD.GetPatientsByConditionCodeCode (p_ConditionCode_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByConditionCodeDisplay (string p_ConditionCode_display)
{
        return _IPatientCAD.GetPatientsByConditionCodeDisplay (p_ConditionCode_display);
}
public void AssignDiary (int p_Patient_OID, int p_diary_OID)
{
        //Call to PatientCAD

        _IPatientCAD.AssignDiary (p_Patient_OID, p_diary_OID);
}
public void UnassignDiary (int p_Patient_OID, int p_diary_OID)
{
        //Call to PatientCAD

        _IPatientCAD.UnassignDiary (p_Patient_OID, p_diary_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> GetPatientsByLocation (int p_location)
{
        return _IPatientCAD.GetPatientsByLocation (p_location);
}
}
}
