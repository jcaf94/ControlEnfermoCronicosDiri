
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IReclamationResponseCAD
{
ReclamationResponseEN ReadOIDDefault (int identifier
                                      );

void ModifyDefault (ReclamationResponseEN reclamationResponse);

System.Collections.Generic.IList<ReclamationResponseEN> ReadAllDefault (int first, int size);



int New_ (ReclamationResponseEN reclamationResponse);

void Modify (ReclamationResponseEN reclamationResponse);


void Destroy (int identifier
              );


ReclamationResponseEN ReadOID (int identifier
                               );


System.Collections.Generic.IList<ReclamationResponseEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponsesByInterval (Nullable<DateTime> p_createdDateFrom, Nullable<DateTime> p_createdDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponsesByActionState_Interval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum? p_actionState, Nullable<DateTime> p_createdDateFrom, Nullable<DateTime> p_createdDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponseByReclamation (int p_Reclamation_OID);
}
}
