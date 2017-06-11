
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
 * Clase Medication:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class MedicationCAD : BasicCAD, IMedicationCAD
{
public MedicationCAD() : base ()
{
}

public MedicationCAD(ISession sessionAux) : base (sessionAux)
{
}



public MedicationEN ReadOIDDefault (int identifier
                                    )
{
        MedicationEN medicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                medicationEN = (MedicationEN)session.Get (typeof(MedicationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medicationEN;
}

public System.Collections.Generic.IList<MedicationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MedicationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MedicationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MedicationEN>();
                        else
                                result = session.CreateCriteria (typeof(MedicationEN)).List<MedicationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MedicationEN medication)
{
        try
        {
                SessionInitializeTransaction ();
                MedicationEN medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), medication.Identifier);

                medicationEN.Name = medication.Name;


                medicationEN.Manufacturer = medication.Manufacturer;


                medicationEN.Description = medication.Description;


                medicationEN.Form = medication.Form;


                medicationEN.Rate = medication.Rate;


                medicationEN.Dosage = medication.Dosage;


                medicationEN.Status = medication.Status;


                medicationEN.IsOverTheCounter = medication.IsOverTheCounter;



                session.Update (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MedicationEN medication)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (medication);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medication.Identifier;
}

public void Modify (MedicationEN medication)
{
        try
        {
                SessionInitializeTransaction ();
                MedicationEN medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), medication.Identifier);

                medicationEN.Name = medication.Name;


                medicationEN.Manufacturer = medication.Manufacturer;


                medicationEN.Description = medication.Description;


                medicationEN.Form = medication.Form;


                medicationEN.Rate = medication.Rate;


                medicationEN.Dosage = medication.Dosage;


                medicationEN.Status = medication.Status;


                medicationEN.IsOverTheCounter = medication.IsOverTheCounter;

                session.Update (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
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
                MedicationEN medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), identifier);
                session.Delete (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MedicationEN
public MedicationEN ReadOID (int identifier
                             )
{
        MedicationEN medicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                medicationEN = (MedicationEN)session.Get (typeof(MedicationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medicationEN;
}

public System.Collections.Generic.IList<MedicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MedicationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MedicationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MedicationEN>();
                else
                        result = session.CreateCriteria (typeof(MedicationEN)).List<MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsBySubstanceCodeCode (string p_SubstanceCode_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsBySubstanceCodeCodeHQL");
                query.SetParameter ("p_SubstanceCode_code", p_SubstanceCode_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsByIngredients_FormHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form_OverTheCounter ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsByIngredients_Form_OverTheCounterHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form_Manufacturer ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsByIngredients_Form_ManufacturerHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByActivity (int p_Activity_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsByActivityHQL");
                query.SetParameter ("p_Activity_OID", p_Activity_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByPatient (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsByPatientHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsBySubstanceCodeDisplay (string p_SubstanceCode_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MedicationEN self where FROM MedicationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MedicationENgetMedicationsBySubstanceCodeDisplayHQL");
                query.SetParameter ("p_SubstanceCode_display", p_SubstanceCode_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignIngredient (int p_Medication_OID, System.Collections.Generic.IList<int> p_ingredient_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.MedicationEN medicationEN = null;
        try
        {
                SessionInitializeTransaction ();
                medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), p_Medication_OID);
                ChroniGenNHibernate.EN.Chroni.IngredientEN ingredientENAux = null;
                if (medicationEN.Ingredient == null) {
                        medicationEN.Ingredient = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.IngredientEN>();
                }

                foreach (int item in p_ingredient_OIDs) {
                        ingredientENAux = new ChroniGenNHibernate.EN.Chroni.IngredientEN ();
                        ingredientENAux = (ChroniGenNHibernate.EN.Chroni.IngredientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.IngredientEN), item);
                        ingredientENAux.Medication.Add (medicationEN);

                        medicationEN.Ingredient.Add (ingredientENAux);
                }


                session.Update (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignIngredient (int p_Medication_OID, System.Collections.Generic.IList<int> p_ingredient_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.MedicationEN medicationEN = null;
                medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), p_Medication_OID);

                ChroniGenNHibernate.EN.Chroni.IngredientEN ingredientENAux = null;
                if (medicationEN.Ingredient != null) {
                        foreach (int item in p_ingredient_OIDs) {
                                ingredientENAux = (ChroniGenNHibernate.EN.Chroni.IngredientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.IngredientEN), item);
                                if (medicationEN.Ingredient.Contains (ingredientENAux) == true) {
                                        medicationEN.Ingredient.Remove (ingredientENAux);
                                        ingredientENAux.Medication.Remove (medicationEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_ingredient_OIDs you are trying to unrelationer, doesn't exist in MedicationEN");
                        }
                }

                session.Update (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
