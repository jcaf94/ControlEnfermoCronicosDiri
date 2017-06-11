

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
 *      Definition of the class ObservationCEN
 *
 */
public partial class ObservationCEN
{
private IObservationCAD _IObservationCAD;

public ObservationCEN()
{
        this._IObservationCAD = new ObservationCAD ();
}

public ObservationCEN(IObservationCAD _IObservationCAD)
{
        this._IObservationCAD = _IObservationCAD;
}

public IObservationCAD get_IObservationCAD ()
{
        return this._IObservationCAD;
}

public int New_ (ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum p_measureType, string p_name, Nullable<DateTime> p_dateEntry, string p_note, Nullable<DateTime> p_dateAdded, int p_diary, Nullable<DateTime> p_dateObservation, ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum p_category, ChroniGenNHibernate.Enumerated.Chroni.SymptomGradeEnum p_grade, double p_value1, double p_value2, int p_personOID)
{
        ObservationEN observationEN = null;
        int oid;

        //Initialized ObservationEN
        observationEN = new ObservationEN ();
        observationEN.MeasureType = p_measureType;

        observationEN.Name = p_name;

        observationEN.DateEntry = p_dateEntry;

        observationEN.Note = p_note;

        observationEN.DateAdded = p_dateAdded;


        if (p_diary != -1) {
                // El argumento p_diary -> Property diary es oid = false
                // Lista de oids identifier
                observationEN.Diary = new ChroniGenNHibernate.EN.Chroni.DiaryEN ();
                observationEN.Diary.Identifier = p_diary;
        }

        observationEN.DateObservation = p_dateObservation;

        observationEN.Category = p_category;

        observationEN.Grade = p_grade;

        observationEN.Value1 = p_value1;

        observationEN.Value2 = p_value2;

        observationEN.PersonOID = p_personOID;

        //Call to ObservationCAD

        oid = _IObservationCAD.New_ (observationEN);
        return oid;
}

public void Modify (int p_Observation_OID, ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum p_measureType, string p_name, Nullable<DateTime> p_dateEntry, string p_note, Nullable<DateTime> p_dateAdded, Nullable<DateTime> p_dateObservation, ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum p_category, ChroniGenNHibernate.Enumerated.Chroni.SymptomGradeEnum p_grade, double p_value1, double p_value2, int p_personOID)
{
        ObservationEN observationEN = null;

        //Initialized ObservationEN
        observationEN = new ObservationEN ();
        observationEN.Identifier = p_Observation_OID;
        observationEN.MeasureType = p_measureType;
        observationEN.Name = p_name;
        observationEN.DateEntry = p_dateEntry;
        observationEN.Note = p_note;
        observationEN.DateAdded = p_dateAdded;
        observationEN.DateObservation = p_dateObservation;
        observationEN.Category = p_category;
        observationEN.Grade = p_grade;
        observationEN.Value1 = p_value1;
        observationEN.Value2 = p_value2;
        observationEN.PersonOID = p_personOID;
        //Call to ObservationCAD

        _IObservationCAD.Modify (observationEN);
}

public void Destroy (int identifier
                     )
{
        _IObservationCAD.Destroy (identifier);
}

public ObservationEN ReadOID (int identifier
                              )
{
        ObservationEN observationEN = null;

        observationEN = _IObservationCAD.ReadOID (identifier);
        return observationEN;
}

public System.Collections.Generic.IList<ObservationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ObservationEN> list = null;

        list = _IObservationCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByCategory_Interval (ChroniGenNHibernate.Enumerated.Chroni.ObservationCategoryEnum? p_category, Nullable<DateTime> p_dateObservationFrom, Nullable<DateTime> p_dateObservationTo)
{
        return _IObservationCAD.GetObservationsByCategory_Interval (p_category, p_dateObservationFrom, p_dateObservationTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByMesureType_Value1 (ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum? p_measureType, double ? p_value1)
{
        return _IObservationCAD.GetObservationsByMesureType_Value1 (p_measureType, p_value1);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByMesureType_Value2 (ChroniGenNHibernate.Enumerated.Chroni.MeasureTypeEnum? p_measureType, double ? p_value2)
{
        return _IObservationCAD.GetObservationsByMesureType_Value2 (p_measureType, p_value2);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByName_Interval (string p_name, Nullable<DateTime> p_observationDateFrom, Nullable<DateTime> p_observationDateTo)
{
        return _IObservationCAD.GetObservationsByName_Interval (p_name, p_observationDateFrom, p_observationDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ObservationEN> GetObservationsByInterval (Nullable<DateTime> p_observationDateFrom, Nullable<DateTime> p_observationDateTo)
{
        return _IObservationCAD.GetObservationsByInterval (p_observationDateFrom, p_observationDateTo);
}
}
}
