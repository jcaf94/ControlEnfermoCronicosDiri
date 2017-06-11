
using System;
using System.Text;
using ChroniGenNHibernate.CEN.Chroni;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.Exceptions;


/*
 * Clase Ingredient:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class IngredientCAD : BasicCAD, IIngredientCAD
{
public IngredientCAD() : base ()
{
}

public IngredientCAD(ISession sessionAux) : base (sessionAux)
{
}



public IngredientEN ReadOIDDefault (int identifier
                                    )
{
        IngredientEN ingredientEN = null;

        try
        {
                SessionInitializeTransaction ();
                ingredientEN = (IngredientEN)session.Get (typeof(IngredientEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredientEN;
}

public System.Collections.Generic.IList<IngredientEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IngredientEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IngredientEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IngredientEN>();
                        else
                                result = session.CreateCriteria (typeof(IngredientEN)).List<IngredientEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IngredientEN ingredient)
{
        try
        {
                SessionInitializeTransaction ();
                IngredientEN ingredientEN = (IngredientEN)session.Load (typeof(IngredientEN), ingredient.Identifier);

                ingredientEN.Amount = ingredient.Amount;



                ingredientEN.IsActive = ingredient.IsActive;


                session.Update (ingredientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IngredientEN ingredient)
{
        try
        {
                SessionInitializeTransaction ();
                if (ingredient.SubstanceCode != null) {
                        // Argumento OID y no colección.
                        ingredient.SubstanceCode = (ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.SubstanceCodeEN), ingredient.SubstanceCode.Identifier);

                        ingredient.SubstanceCode.Ingredient
                        .Add (ingredient);
                }

                session.Save (ingredient);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredient.Identifier;
}

public void Modify (IngredientEN ingredient)
{
        try
        {
                SessionInitializeTransaction ();
                IngredientEN ingredientEN = (IngredientEN)session.Load (typeof(IngredientEN), ingredient.Identifier);

                ingredientEN.Amount = ingredient.Amount;


                ingredientEN.IsActive = ingredient.IsActive;

                session.Update (ingredientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int identifier
                     )
{
        try
        {
                SessionInitializeTransaction ();
                IngredientEN ingredientEN = (IngredientEN)session.Load (typeof(IngredientEN), identifier);
                session.Delete (ingredientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IngredientEN
public IngredientEN ReadOID (int identifier
                             )
{
        IngredientEN ingredientEN = null;

        try
        {
                SessionInitializeTransaction ();
                ingredientEN = (IngredientEN)session.Get (typeof(IngredientEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredientEN;
}

public System.Collections.Generic.IList<IngredientEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IngredientEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IngredientEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IngredientEN>();
                else
                        result = session.CreateCriteria (typeof(IngredientEN)).List<IngredientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> GetIngredientsByIsActive (bool ? p_isActive)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM IngredientEN self where FROM IngredientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("IngredientENgetIngredientsByIsActiveHQL");
                query.SetParameter ("p_isActive", p_isActive);

                result = query.List<ChroniGenNHibernate.EN.Chroni.IngredientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> GetIngredientsByMedicationName (string p_Medication_Name)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.IngredientEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM IngredientEN self where FROM IngredientEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("IngredientENgetIngredientsByMedicationNameHQL");
                query.SetParameter ("p_Medication_Name", p_Medication_Name);

                result = query.List<ChroniGenNHibernate.EN.Chroni.IngredientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in IngredientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
