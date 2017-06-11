

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
 *      Definition of the class CarePlanCategoryCEN
 *
 */
public partial class CarePlanCategoryCEN
{
private ICarePlanCategoryCAD _ICarePlanCategoryCAD;

public CarePlanCategoryCEN()
{
        this._ICarePlanCategoryCAD = new CarePlanCategoryCAD ();
}

public CarePlanCategoryCEN(ICarePlanCategoryCAD _ICarePlanCategoryCAD)
{
        this._ICarePlanCategoryCAD = _ICarePlanCategoryCAD;
}

public ICarePlanCategoryCAD get_ICarePlanCategoryCAD ()
{
        return this._ICarePlanCategoryCAD;
}

public int New_ (string p_code, string p_display)
{
        CarePlanCategoryEN carePlanCategoryEN = null;
        int oid;

        //Initialized CarePlanCategoryEN
        carePlanCategoryEN = new CarePlanCategoryEN ();
        carePlanCategoryEN.Code = p_code;

        carePlanCategoryEN.Display = p_display;

        //Call to CarePlanCategoryCAD

        oid = _ICarePlanCategoryCAD.New_ (carePlanCategoryEN);
        return oid;
}

public void Modify (int p_CarePlanCategory_OID, string p_code, string p_display)
{
        CarePlanCategoryEN carePlanCategoryEN = null;

        //Initialized CarePlanCategoryEN
        carePlanCategoryEN = new CarePlanCategoryEN ();
        carePlanCategoryEN.Identifier = p_CarePlanCategory_OID;
        carePlanCategoryEN.Code = p_code;
        carePlanCategoryEN.Display = p_display;
        //Call to CarePlanCategoryCAD

        _ICarePlanCategoryCAD.Modify (carePlanCategoryEN);
}

public void Destroy (int identifier
                     )
{
        _ICarePlanCategoryCAD.Destroy (identifier);
}

public CarePlanCategoryEN ReadOID (int identifier
                                   )
{
        CarePlanCategoryEN carePlanCategoryEN = null;

        carePlanCategoryEN = _ICarePlanCategoryCAD.ReadOID (identifier);
        return carePlanCategoryEN;
}

public System.Collections.Generic.IList<CarePlanCategoryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanCategoryEN> list = null;

        list = _ICarePlanCategoryCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> GetCarePlanCategoryByCode (string p_code)
{
        return _ICarePlanCategoryCAD.GetCarePlanCategoryByCode (p_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> GetCarePlanCategoryByDisplay (string p_display)
{
        return _ICarePlanCategoryCAD.GetCarePlanCategoryByDisplay (p_display);
}
}
}
