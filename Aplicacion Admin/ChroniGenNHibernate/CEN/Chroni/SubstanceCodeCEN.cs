

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
 *      Definition of the class SubstanceCodeCEN
 *
 */
public partial class SubstanceCodeCEN
{
private ISubstanceCodeCAD _ISubstanceCodeCAD;

public SubstanceCodeCEN()
{
        this._ISubstanceCodeCAD = new SubstanceCodeCAD ();
}

public SubstanceCodeCEN(ISubstanceCodeCAD _ISubstanceCodeCAD)
{
        this._ISubstanceCodeCAD = _ISubstanceCodeCAD;
}

public ISubstanceCodeCAD get_ISubstanceCodeCAD ()
{
        return this._ISubstanceCodeCAD;
}

public int New_ (string p_code, string p_display)
{
        SubstanceCodeEN substanceCodeEN = null;
        int oid;

        //Initialized SubstanceCodeEN
        substanceCodeEN = new SubstanceCodeEN ();
        substanceCodeEN.Code = p_code;

        substanceCodeEN.Display = p_display;

        //Call to SubstanceCodeCAD

        oid = _ISubstanceCodeCAD.New_ (substanceCodeEN);
        return oid;
}

public void Modify (int p_SubstanceCode_OID, string p_code, string p_display)
{
        SubstanceCodeEN substanceCodeEN = null;

        //Initialized SubstanceCodeEN
        substanceCodeEN = new SubstanceCodeEN ();
        substanceCodeEN.Identifier = p_SubstanceCode_OID;
        substanceCodeEN.Code = p_code;
        substanceCodeEN.Display = p_display;
        //Call to SubstanceCodeCAD

        _ISubstanceCodeCAD.Modify (substanceCodeEN);
}

public void Destroy (int identifier
                     )
{
        _ISubstanceCodeCAD.Destroy (identifier);
}

public SubstanceCodeEN ReadOID (int identifier
                                )
{
        SubstanceCodeEN substanceCodeEN = null;

        substanceCodeEN = _ISubstanceCodeCAD.ReadOID (identifier);
        return substanceCodeEN;
}

public System.Collections.Generic.IList<SubstanceCodeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SubstanceCodeEN> list = null;

        list = _ISubstanceCodeCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> GetSubstanceCodeByCode (string p_code)
{
        return _ISubstanceCodeCAD.GetSubstanceCodeByCode (p_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN> GetSubstanceCodeByDisplay (string p_display)
{
        return _ISubstanceCodeCAD.GetSubstanceCodeByDisplay (p_display);
}
}
}
