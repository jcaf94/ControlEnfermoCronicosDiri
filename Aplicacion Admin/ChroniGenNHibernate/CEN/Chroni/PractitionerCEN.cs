

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
 *      Definition of the class PractitionerCEN
 *
 */
public partial class PractitionerCEN
{
private IPractitionerCAD _IPractitionerCAD;

public PractitionerCEN()
{
        this._IPractitionerCAD = new PractitionerCAD ();
}

public PractitionerCEN(IPractitionerCAD _IPractitionerCAD)
{
        this._IPractitionerCAD = _IPractitionerCAD;
}

public IPractitionerCAD get_IPractitionerCAD ()
{
        return this._IPractitionerCAD;
}

public int New_ (string p_nif, bool p_active, ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum p_role, string p_name, string p_surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, string p_address, string p_email, string p_phone, string p_photo, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, System.Collections.Generic.IList<int> p_location, String p_password)
{
        PractitionerEN practitionerEN = null;
        int oid;

        //Initialized PractitionerEN
        practitionerEN = new PractitionerEN ();
        practitionerEN.Nif = p_nif;

        practitionerEN.Active = p_active;

        practitionerEN.Role = p_role;

        practitionerEN.Name = p_name;

        practitionerEN.Surnames = p_surnames;

        practitionerEN.Gender = p_gender;

        practitionerEN.BirthDate = p_birthDate;

        practitionerEN.Address = p_address;

        practitionerEN.Email = p_email;

        practitionerEN.Phone = p_phone;

        practitionerEN.Photo = p_photo;

        practitionerEN.StartDate = p_startDate;

        practitionerEN.EndDate = p_endDate;


        practitionerEN.Location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
        if (p_location != null) {
                foreach (int item in p_location) {
                        ChroniGenNHibernate.EN.Chroni.LocationEN en = new ChroniGenNHibernate.EN.Chroni.LocationEN ();
                        en.Identifier = item;
                        practitionerEN.Location.Add (en);
                }
        }

        else{
                practitionerEN.Location = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.LocationEN>();
        }

        practitionerEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        //Call to PractitionerCAD

        oid = _IPractitionerCAD.New_ (practitionerEN);
        return oid;
}

public void Modify (int p_Practitioner_OID, string p_nif, bool p_active, ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum p_role, string p_name, string p_surnames, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, string p_address, string p_email, string p_phone, string p_photo, Nullable<DateTime> p_startDate, Nullable<DateTime> p_endDate, String p_password)
{
        PractitionerEN practitionerEN = null;

        //Initialized PractitionerEN
        practitionerEN = new PractitionerEN ();
        practitionerEN.Identifier = p_Practitioner_OID;
        practitionerEN.Nif = p_nif;
        practitionerEN.Active = p_active;
        practitionerEN.Role = p_role;
        practitionerEN.Name = p_name;
        practitionerEN.Surnames = p_surnames;
        practitionerEN.Gender = p_gender;
        practitionerEN.BirthDate = p_birthDate;
        practitionerEN.Address = p_address;
        practitionerEN.Email = p_email;
        practitionerEN.Phone = p_phone;
        practitionerEN.Photo = p_photo;
        practitionerEN.StartDate = p_startDate;
        practitionerEN.EndDate = p_endDate;
        practitionerEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        //Call to PractitionerCAD

        _IPractitionerCAD.Modify (practitionerEN);
}

public void Destroy (int identifier
                     )
{
        _IPractitionerCAD.Destroy (identifier);
}

public PractitionerEN ReadOID (int identifier
                               )
{
        PractitionerEN practitionerEN = null;

        practitionerEN = _IPractitionerCAD.ReadOID (identifier);
        return practitionerEN;
}

public System.Collections.Generic.IList<PractitionerEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PractitionerEN> list = null;

        list = _IPractitionerCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByRole_Location (ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum? p_role, int p_location)
{
        return _IPractitionerCAD.GetPractitionersByRole_Location (p_role, p_location);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByActive_Location (bool? p_active, int p_Location_OID)
{
        return _IPractitionerCAD.GetPractitionersByActive_Location (p_active, p_Location_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByName_Surname_Location (string p_name, int p_Location_OID)
{
        return _IPractitionerCAD.GetPractitionersByName_Surname_Location (p_name, p_Location_OID);
}
public void AssignLocation (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        //Call to PractitionerCAD

        _IPractitionerCAD.AssignLocation (p_Practitioner_OID, p_location_OIDs);
}
public void UnassignLocation (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_location_OIDs)
{
        //Call to PractitionerCAD

        _IPractitionerCAD.UnassignLocation (p_Practitioner_OID, p_location_OIDs);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByPatientNif (string p_Patient_nif)
{
        return _IPractitionerCAD.GetPractitionersByPatientNif (p_Patient_nif);
}
public void AssignSpecialty (int p_Practitioner_OID, int p_specialty_OID)
{
        //Call to PractitionerCAD

        _IPractitionerCAD.AssignSpecialty (p_Practitioner_OID, p_specialty_OID);
}
public void UnassignSpecialty (int p_Practitioner_OID, int p_specialty_OID)
{
        //Call to PractitionerCAD

        _IPractitionerCAD.UnassignSpecialty (p_Practitioner_OID, p_specialty_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByGender_Location (ChroniGenNHibernate.Enumerated.Chroni.GenderEnum? p_gender, int p_Location_OID)
{
        return _IPractitionerCAD.GetPractitionersByGender_Location (p_gender, p_Location_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByRole_LocationName (ChroniGenNHibernate.Enumerated.Chroni.PractitionerRoleEnum? p_role, string p_Location_name)
{
        return _IPractitionerCAD.GetPractitionersByRole_LocationName (p_role, p_Location_name);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByNif (string p_nif)
{
        return _IPractitionerCAD.GetPractitionerByNif (p_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByLocation (int p_location)
{
        return _IPractitionerCAD.GetPractitionersByLocation (p_location);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByLocationName (string p_Location_name)
{
        return _IPractitionerCAD.GetPractitionersByLocationName (p_Location_name);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByPhone (string p_phone)
{
        return _IPractitionerCAD.GetPractitionerByPhone (p_phone);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerBySpecialtyDisplay (string p_Specialty_Display)
{
        return _IPractitionerCAD.GetPractitionerBySpecialtyDisplay (p_Specialty_Display);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersBySpecialtyCode (string p_Specialty_code)
{
        return _IPractitionerCAD.GetPractitionersBySpecialtyCode (p_Specialty_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersBySpecialtyDisplay_Interval (string p_Specialty_display, Nullable<DateTime> p_dateFrom, Nullable<DateTime> p_dateTo)
{
        return _IPractitionerCAD.GetPractitionersBySpecialtyDisplay_Interval (p_Specialty_display, p_dateFrom, p_dateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByBirthInterval (Nullable<DateTime> p_birthDateFrom, Nullable<DateTime> p_birthDateTo)
{
        return _IPractitionerCAD.GetPractitionersByBirthInterval (p_birthDateFrom, p_birthDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionersByPatientName_Surnames (string p_Patient_name, string p_Patient_surnames)
{
        return _IPractitionerCAD.GetPractitionersByPatientName_Surnames (p_Patient_name, p_Patient_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> GetPractitionerByEmail (string email)
{
        return _IPractitionerCAD.GetPractitionerByEmail (email);
}
public void AssignSchedule (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_schedule_OIDs)
{
        //Call to PractitionerCAD

        _IPractitionerCAD.AssignSchedule (p_Practitioner_OID, p_schedule_OIDs);
}
public void UnassignSchedule (int p_Practitioner_OID, System.Collections.Generic.IList<int> p_schedule_OIDs)
{
        //Call to PractitionerCAD

        _IPractitionerCAD.UnassignSchedule (p_Practitioner_OID, p_schedule_OIDs);
}
}
}
