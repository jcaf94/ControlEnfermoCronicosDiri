
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface ILocationCAD
{
LocationEN ReadOIDDefault (int identifier
                           );

void ModifyDefault (LocationEN location);

System.Collections.Generic.IList<LocationEN> ReadAllDefault (int first, int size);



int New_ (LocationEN location);

void Modify (LocationEN location);


void Destroy (int identifier
              );


LocationEN ReadOID (int identifier
                    );


System.Collections.Generic.IList<LocationEN> ReadAll (int first, int size);






System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByType (ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum ? p_type);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByType_Status (ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum? p_type, ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum ? p_status);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPostalCode (string p_postalCode);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPractitioner (int p_Practitioner_oid);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatient (int p_Patient_oid, string arg1);





System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPhysicalType (ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum ? p_physicalType);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatientNif (string p_Patient_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationsByPatientSurnames (string p_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.LocationEN> GetLocationByPosition (int p_Position_OID);


void AssignPosition (int p_Location_OID, int p_position_OID);

void UnassignPosition (int p_Location_OID, int p_position_OID);
}
}
