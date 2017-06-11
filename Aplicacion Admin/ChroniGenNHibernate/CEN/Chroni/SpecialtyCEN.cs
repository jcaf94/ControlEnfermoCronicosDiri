

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
 *      Definition of the class SpecialtyCEN
 *
 */
public partial class SpecialtyCEN
{
private ISpecialtyCAD _ISpecialtyCAD;

public SpecialtyCEN()
{
        this._ISpecialtyCAD = new SpecialtyCAD ();
}

public SpecialtyCEN(ISpecialtyCAD _ISpecialtyCAD)
{
        this._ISpecialtyCAD = _ISpecialtyCAD;
}

public ISpecialtyCAD get_ISpecialtyCAD ()
{
        return this._ISpecialtyCAD;
}

public int New_ (string p_code, string p_display)
{
        SpecialtyEN specialtyEN = null;
        int oid;

        //Initialized SpecialtyEN
        specialtyEN = new SpecialtyEN ();
        specialtyEN.Code = p_code;

        specialtyEN.Display = p_display;

        //Call to SpecialtyCAD

        oid = _ISpecialtyCAD.New_ (specialtyEN);
        return oid;
}

public void Modify (int p_Specialty_OID, string p_code, string p_display)
{
        SpecialtyEN specialtyEN = null;

        //Initialized SpecialtyEN
        specialtyEN = new SpecialtyEN ();
        specialtyEN.Identifier = p_Specialty_OID;
        specialtyEN.Code = p_code;
        specialtyEN.Display = p_display;
        //Call to SpecialtyCAD

        _ISpecialtyCAD.Modify (specialtyEN);
}

public void Destroy (int identifier
                     )
{
        _ISpecialtyCAD.Destroy (identifier);
}

public SpecialtyEN ReadOID (int identifier
                            )
{
        SpecialtyEN specialtyEN = null;

        specialtyEN = _ISpecialtyCAD.ReadOID (identifier);
        return specialtyEN;
}

public System.Collections.Generic.IList<SpecialtyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SpecialtyEN> list = null;

        list = _ISpecialtyCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtyByCode (string p_code)
{
        return _ISpecialtyCAD.GetSpecialtyByCode (p_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtyByDisplay (string p_display)
{
        return _ISpecialtyCAD.GetSpecialtyByDisplay (p_display);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitioner (int p_Practitioner_OID)
{
        return _ISpecialtyCAD.GetSpecialtiesByPractitioner (p_Practitioner_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitionerNif (string p_Practitioner_nif)
{
        return _ISpecialtyCAD.GetSpecialtiesByPractitionerNif (p_Practitioner_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByPractitionerName_Surnames (string p_Practitioner_name, string p_Practitioner_surnames)
{
        return _ISpecialtyCAD.GetSpecialtiesByPractitionerName_Surnames (p_Practitioner_name, p_Practitioner_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SpecialtyEN> GetSpecialtiesByLocationName (string p_Location_name)
{
        return _ISpecialtyCAD.GetSpecialtiesByLocationName (p_Location_name);
}
}
}
