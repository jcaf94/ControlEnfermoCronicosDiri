
using System;
using ChroniGenNHibernate.EN.Chroni;

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial interface IObservationCAD
{
ObservationEN ReadOIDDefault (int identifier
                              );

void ModifyDefault (ObservationEN observation);

System.Collections.Generic.IList<ObservationEN> ReadAllDefault (int first, int size);



int New_ (ObservationEN observation);

void Modify (ObservationEN observation);


void Destroy (int identifier
              );


ObservationEN ReadOID (int identifier
                       );


System.Collections.Generic.IList<ObservationEN> ReadAll (int first, int size);




System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByCategory_Interval (ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum? p_category, Nullable<DateTime> p_dateObservationFrom, Nullable<DateTime> p_dateObservationTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByMesureType_Value1 (ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum? p_measureType, double ? p_value1);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByMesureType_Value2 (ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum? p_measureType, double ? p_value2);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByName_Interval (string p_name, Nullable<DateTime> p_observationDateFrom, Nullable<DateTime> p_observationDateTo);


System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByInterval (Nullable<DateTime> p_observationDateFrom, Nullable<DateTime> p_observationDateTo);
}
}
