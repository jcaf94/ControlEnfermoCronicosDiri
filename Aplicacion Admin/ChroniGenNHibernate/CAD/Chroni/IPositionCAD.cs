
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IPositionCAD
{
PositionEN ReadOIDDefault (int identifier
                           );

void ModifyDefault (PositionEN position);

System.Collections.Generic.IList<PositionEN> ReadAllDefault (int first, int size);



int New_ (PositionEN position);

void Modify (PositionEN position);


void Destroy (int identifier
              );


PositionEN ReadOID (int identifier
                    );


System.Collections.Generic.IList<PositionEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionByLocation (int p_Location_OID);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionByLocationName (string p_Location_name);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionsByLocationPostalCode (string p_Location_postalCode);
}
}
