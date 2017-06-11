
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IAdministratorCAD
{
AdministratorEN ReadOIDDefault (int identifier
                                );

void ModifyDefault (AdministratorEN administrator);

System.Collections.Generic.IList<AdministratorEN> ReadAllDefault (int first, int size);



int New_ (AdministratorEN administrator);

void Modify (AdministratorEN administrator);


void Destroy (int identifier
              );


AdministratorEN ReadOID (int identifier
                         );


System.Collections.Generic.IList<AdministratorEN> ReadAll (int first, int size);








System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorByNif (string p_nif);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsBySurnames (string p_surnames);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByNames_Surnames (string p_name, string p_surnames);



System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByPhone (string p_phone);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByEmail (string p_email);
}
}
