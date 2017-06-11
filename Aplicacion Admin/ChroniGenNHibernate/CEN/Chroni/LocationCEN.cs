

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
 *      Definition of the class LocationCEN
 *
 */
public partial class LocationCEN
{
private ILocationCAD _ILocationCAD;

public LocationCEN()
{
        this._ILocationCAD = new LocationCAD ();
}

public LocationCEN(ILocationCAD _ILocationCAD)
{
        this._ILocationCAD = _ILocationCAD;
}

public ILocationCAD get_ILocationCAD ()
{
        return this._ILocationCAD;
}

public int New_ (ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum p_status, string p_name, string p_description, ChroniGenNHibernate.Enumerated.Chroni.LocationModeEnum p_mode, ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum p_type, string p_address, ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum p_physicalType, string p_managingOrganization, string p_phone, string p_email, string p_postalCode)
{
        LocationEN locationEN = null;
        int oid;

        //Initialized LocationEN
        locationEN = new LocationEN ();
        locationEN.Status = p_status;

        locationEN.Name = p_name;

        locationEN.Description = p_description;

        locationEN.Mode = p_mode;

        locationEN.Type = p_type;

        locationEN.Address = p_address;

        locationEN.PhysicalType = p_physicalType;

        locationEN.ManagingOrganization = p_managingOrganization;

        locationEN.Phone = p_phone;

        locationEN.Email = p_email;

        locationEN.PostalCode = p_postalCode;

        //Call to LocationCAD

        oid = _ILocationCAD.New_ (locationEN);
        return oid;
}

public void Modify (int p_Location_OID, ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum p_status, string p_name, string p_description, ChroniGenNHibernate.Enumerated.Chroni.LocationModeEnum p_mode, ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum p_type, string p_address, ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum p_physicalType, string p_managingOrganization, string p_phone, string p_email, string p_postalCode)
{
        LocationEN locationEN = null;

        //Initialized LocationEN
        locationEN = new LocationEN ();
        locationEN.Identifier = p_Location_OID;
        locationEN.Status = p_status;
        locationEN.Name = p_name;
        locationEN.Description = p_description;
        locationEN.Mode = p_mode;
        locationEN.Type = p_type;
        locationEN.Address = p_address;
        locationEN.PhysicalType = p_physicalType;
        locationEN.ManagingOrganization = p_managingOrganization;
        locationEN.Phone = p_phone;
        locationEN.Email = p_email;
        locationEN.PostalCode = p_postalCode;
        //Call to LocationCAD

        _ILocationCAD.Modify (locationEN);
}

public void Destroy (int identifier
                     )
{
        _ILocationCAD.Destroy (identifier);
}

public LocationEN ReadOID (int identifier
                           )
{
        LocationEN locationEN = null;

        locationEN = _ILocationCAD.ReadOID (identifier);
        return locationEN;
}

public System.Collections.Generic.IList<LocationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LocationEN> list = null;

        list = _ILocationCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByType (ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum ? p_type)
{
        return _ILocationCAD.GetLocationsByType (p_type);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByType_Status (ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum? p_type, ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum ? p_status)
{
        return _ILocationCAD.GetLocationsByType_Status (p_type, p_status);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPostalCode (string p_postalCode)
{
        return _ILocationCAD.GetLocationsByPostalCode (p_postalCode);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPractitioner (int p_Practitioner_oid)
{
        return _ILocationCAD.GetLocationsByPractitioner (p_Practitioner_oid);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatient (int p_Patient_oid, string arg1)
{
        return _ILocationCAD.GetLocationsByPatient (p_Patient_oid, arg1);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPhysicalType (ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum ? p_physicalType)
{
        return _ILocationCAD.GetLocationsByPhysicalType (p_physicalType);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatientNif (string p_Patient_nif)
{
        return _ILocationCAD.GetLocationsByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatientSurnames (string p_surnames)
{
        return _ILocationCAD.GetLocationsByPatientSurnames (p_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationByPosition (int p_Position_OID)
{
        return _ILocationCAD.GetLocationByPosition (p_Position_OID);
}
public void AssignPosition (int p_Location_OID, int p_position_OID)
{
        //Call to LocationCAD

        _ILocationCAD.AssignPosition (p_Location_OID, p_position_OID);
}
public void UnassignPosition (int p_Location_OID, int p_position_OID)
{
        //Call to LocationCAD

        _ILocationCAD.UnassignPosition (p_Location_OID, p_position_OID);
}
}
}
