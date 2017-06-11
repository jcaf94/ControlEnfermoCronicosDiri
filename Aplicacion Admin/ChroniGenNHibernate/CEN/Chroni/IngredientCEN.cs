

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
 *      Definition of the class IngredientCEN
 *
 */
public partial class IngredientCEN
{
private IIngredientCAD _IIngredientCAD;

public IngredientCEN()
{
        this._IIngredientCAD = new IngredientCAD ();
}

public IngredientCEN(IIngredientCAD _IIngredientCAD)
{
        this._IIngredientCAD = _IIngredientCAD;
}

public IIngredientCAD get_IIngredientCAD ()
{
        return this._IIngredientCAD;
}

public int New_ (string p_amount, bool p_isActive, int p_substanceCode)
{
        IngredientEN ingredientEN = null;
        int oid;

        //Initialized IngredientEN
        ingredientEN = new IngredientEN ();
        ingredientEN.Amount = p_amount;

        ingredientEN.IsActive = p_isActive;


        if (p_substanceCode != -1) {
                // El argumento p_substanceCode -> Property substanceCode es oid = false
                // Lista de oids identifier
                ingredientEN.SubstanceCode = new ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN ();
                ingredientEN.SubstanceCode.Identifier = p_substanceCode;
        }

        //Call to IngredientCAD

        oid = _IIngredientCAD.New_ (ingredientEN);
        return oid;
}

public void Modify (int p_Ingredient_OID, string p_amount, bool p_isActive)
{
        IngredientEN ingredientEN = null;

        //Initialized IngredientEN
        ingredientEN = new IngredientEN ();
        ingredientEN.Identifier = p_Ingredient_OID;
        ingredientEN.Amount = p_amount;
        ingredientEN.IsActive = p_isActive;
        //Call to IngredientCAD

        _IIngredientCAD.Modify (ingredientEN);
}

public void Destroy (int identifier
                     )
{
        _IIngredientCAD.Destroy (identifier);
}

public IngredientEN ReadOID (int identifier
                             )
{
        IngredientEN ingredientEN = null;

        ingredientEN = _IIngredientCAD.ReadOID (identifier);
        return ingredientEN;
}

public System.Collections.Generic.IList<IngredientEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IngredientEN> list = null;

        list = _IIngredientCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> GetIngredientsByIsActive (bool ? p_isActive)
{
        return _IIngredientCAD.GetIngredientsByIsActive (p_isActive);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> GetIngredientsByMedicationName (string p_Medication_Name)
{
        return _IIngredientCAD.GetIngredientsByMedicationName (p_Medication_Name);
}
}
}
