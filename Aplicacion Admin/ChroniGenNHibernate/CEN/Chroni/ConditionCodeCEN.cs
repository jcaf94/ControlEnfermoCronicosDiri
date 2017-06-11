

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
 *      Definition of the class ConditionCodeCEN
 *
 */
public partial class ConditionCodeCEN
{
private IConditionCodeCAD _IConditionCodeCAD;

public ConditionCodeCEN()
{
        this._IConditionCodeCAD = new ConditionCodeCAD ();
}

public ConditionCodeCEN(IConditionCodeCAD _IConditionCodeCAD)
{
        this._IConditionCodeCAD = _IConditionCodeCAD;
}

public IConditionCodeCAD get_IConditionCodeCAD ()
{
        return this._IConditionCodeCAD;
}

public int New_ (string p_code, string p_display)
{
        ConditionCodeEN conditionCodeEN = null;
        int oid;

        //Initialized ConditionCodeEN
        conditionCodeEN = new ConditionCodeEN ();
        conditionCodeEN.Code = p_code;

        conditionCodeEN.Display = p_display;

        //Call to ConditionCodeCAD

        oid = _IConditionCodeCAD.New_ (conditionCodeEN);
        return oid;
}

public void Modify (int p_ConditionCode_OID, string p_code, string p_display)
{
        ConditionCodeEN conditionCodeEN = null;

        //Initialized ConditionCodeEN
        conditionCodeEN = new ConditionCodeEN ();
        conditionCodeEN.Identifier = p_ConditionCode_OID;
        conditionCodeEN.Code = p_code;
        conditionCodeEN.Display = p_display;
        //Call to ConditionCodeCAD

        _IConditionCodeCAD.Modify (conditionCodeEN);
}

public void Destroy (int identifier
                     )
{
        _IConditionCodeCAD.Destroy (identifier);
}

public ConditionCodeEN ReadOID (int identifier
                                )
{
        ConditionCodeEN conditionCodeEN = null;

        conditionCodeEN = _IConditionCodeCAD.ReadOID (identifier);
        return conditionCodeEN;
}

public System.Collections.Generic.IList<ConditionCodeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConditionCodeEN> list = null;

        list = _IConditionCodeCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> GetConditionCodeByCode (string p_code)
{
        return _IConditionCodeCAD.GetConditionCodeByCode (p_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionCodeEN> GetConditionCodeByDisplay (string p_display)
{
        return _IConditionCodeCAD.GetConditionCodeByDisplay (p_display);
}
}
}
