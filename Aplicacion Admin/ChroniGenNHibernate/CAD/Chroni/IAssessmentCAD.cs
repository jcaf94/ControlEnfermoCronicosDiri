
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IAssessmentCAD
{
AssessmentEN ReadOIDDefault (int identifier
                             );

void ModifyDefault (AssessmentEN assessment);

System.Collections.Generic.IList<AssessmentEN> ReadAllDefault (int first, int size);



int New_ (AssessmentEN assessment);

void Modify (AssessmentEN assessment);


void Destroy (int identifier
              );


AssessmentEN ReadOID (int identifier
                      );


System.Collections.Generic.IList<AssessmentEN> ReadAll (int first, int size);


System.Collections.Generic.IList<AssessmentEN> GetAverageByPractitioner (int first, int size);


System.Collections.Generic.IList<AssessmentEN> GetAverageByPractitionerNif (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> GetAverageByPractitionerRole ();
}
}
