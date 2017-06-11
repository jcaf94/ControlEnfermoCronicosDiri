
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface ISubstanceCodeCAD
{
SubstanceCodeEN ReadOIDDefault (int identifier
                                );

void ModifyDefault (SubstanceCodeEN substanceCode);

System.Collections.Generic.IList<SubstanceCodeEN> ReadAllDefault (int first, int size);



int New_ (SubstanceCodeEN substanceCode);

void Modify (SubstanceCodeEN substanceCode);


void Destroy (int identifier
              );


SubstanceCodeEN ReadOID (int identifier
                         );


System.Collections.Generic.IList<SubstanceCodeEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> GetSubstanceCodeByCode (string p_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> GetSubstanceCodeByDisplay (string p_display);
}
}
