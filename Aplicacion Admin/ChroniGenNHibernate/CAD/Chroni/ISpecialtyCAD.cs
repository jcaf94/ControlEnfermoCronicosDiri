
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface ISpecialtyCAD
{
SpecialtyEN ReadOIDDefault (int identifier
                            );

void ModifyDefault (SpecialtyEN specialty);

System.Collections.Generic.IList<SpecialtyEN> ReadAllDefault (int first, int size);



int New_ (SpecialtyEN specialty);

void Modify (SpecialtyEN specialty);


void Destroy (int identifier
              );


SpecialtyEN ReadOID (int identifier
                     );


System.Collections.Generic.IList<SpecialtyEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtyByCode (string p_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtyByDisplay (string p_display);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitioner (int p_Practitioner_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitionerNif (string p_Practitioner_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitionerName_Surnames (string p_Practitioner_name, string p_Practitioner_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByLocationName (string p_Location_name);
}
}
