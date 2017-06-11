
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface ICarePlanCategoryCAD
{
CarePlanCategoryEN ReadOIDDefault (int identifier
                                   );

void ModifyDefault (CarePlanCategoryEN carePlanCategory);

System.Collections.Generic.IList<CarePlanCategoryEN> ReadAllDefault (int first, int size);



int New_ (CarePlanCategoryEN carePlanCategory);

void Modify (CarePlanCategoryEN carePlanCategory);


void Destroy (int identifier
              );


CarePlanCategoryEN ReadOID (int identifier
                            );


System.Collections.Generic.IList<CarePlanCategoryEN> ReadAll (int first, int size);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> GetCarePlanCategoryByCode (string p_code);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> GetCarePlanCategoryByDisplay (string p_display);
}
}
