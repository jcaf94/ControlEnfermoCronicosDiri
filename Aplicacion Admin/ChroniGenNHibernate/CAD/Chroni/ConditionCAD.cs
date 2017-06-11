
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
 * Clase Condition:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ConditionCAD : BasicCAD, IConditionCAD
{
public ConditionCAD() : base ()
{
}

public ConditionCAD(ISession sessionAux) : base (sessionAux)
{
}



public ConditionEN ReadOIDDefault (int identifier
                                   )
{
        ConditionEN conditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                conditionEN = (ConditionEN)session.Get (typeof(ConditionEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conditionEN;
}

public System.Collections.Generic.IList<ConditionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ConditionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ConditionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ConditionEN>();
                        else
                                result = session.CreateCriteria (typeof(ConditionEN)).List<ConditionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ConditionEN condition)
{
        try
        {
                SessionInitializeTransaction ();
                ConditionEN conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), condition.Identifier);



                conditionEN.Category = condition.Category;


                conditionEN.ClinicalStatus = condition.ClinicalStatus;


                conditionEN.Severity = condition.Severity;


                conditionEN.Onset = condition.Onset;


                conditionEN.Abatement = condition.Abatement;


                conditionEN.Note = condition.Note;

                session.Update (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ConditionEN condition)
{
        try
        {
                SessionInitializeTransaction ();
                if (condition.Encounter != null) {
                        // Argumento OID y no colección.
                        condition.Encounter = (ChroniGenNHibernate.EN.Chroni.EncounterEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.EncounterEN), condition.Encounter.Identifier);

                        condition.Encounter.Condition
                                = condition;
                }

                session.Save (condition);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return condition.Identifier;
}

public void Modify (ConditionEN condition)
{
        try
        {
                SessionInitializeTransaction ();
                ConditionEN conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), condition.Identifier);

                conditionEN.Category = condition.Category;


                conditionEN.ClinicalStatus = condition.ClinicalStatus;


                conditionEN.Severity = condition.Severity;


                conditionEN.Onset = condition.Onset;


                conditionEN.Abatement = condition.Abatement;


                conditionEN.Note = condition.Note;

                session.Update (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
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
                ConditionEN conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), identifier);
                session.Delete (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ConditionEN
public ConditionEN ReadOID (int identifier
                            )
{
        ConditionEN conditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                conditionEN = (ConditionEN)session.Get (typeof(ConditionEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conditionEN;
}

public System.Collections.Generic.IList<ConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConditionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ConditionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ConditionEN>();
                else
                        result = session.CreateCriteria (typeof(ConditionEN)).List<ConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByPatient (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConditionEN self where FROM ConditionEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConditionENgetConditionsByPatientHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByPatient_ClinicalStatus (int p_Patient_OID, ChroniGenNHibernate.Enumerated.Chroni.ConditionClinicalStatusEnum ? p_clnicalStatus)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConditionEN self where FROM ConditionEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConditionENgetConditionsByPatient_ClinicalStatusHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);
                query.SetParameter ("p_clnicalStatus", p_clnicalStatus);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByConditionCodeCode (string p_ConditionCode_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConditionEN self where FROM ConditionEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConditionENgetConditionsByConditionCodeCodeHQL");
                query.SetParameter ("p_ConditionCode_code", p_ConditionCode_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> GetConditionsByConditionCode_Display (string p_ConditionCode_Display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ConditionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ConditionEN self where FROM ConditionEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ConditionENgetConditionsByConditionCode_DisplayHQL");
                query.SetParameter ("p_ConditionCode_Display", p_ConditionCode_Display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignConditionCode (int p_Condition_OID, int p_conditionCode_OID)
{
        ChroniGenNHibernate.EN.Chroni.ConditionEN conditionEN = null;
        try
        {
                SessionInitializeTransaction ();
                conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), p_Condition_OID);
                conditionEN.ConditionCode = (ChroniGenNHibernate.EN.Chroni.ConditionCodeEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.ConditionCodeEN), p_conditionCode_OID);

                conditionEN.ConditionCode.Condition.Add (conditionEN);



                session.Update (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignConditionCode (int p_Condition_OID, int p_conditionCode_OID)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.ConditionEN conditionEN = null;
                conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), p_Condition_OID);

                if (conditionEN.ConditionCode.Identifier == p_conditionCode_OID) {
                        conditionEN.ConditionCode = null;
                }
                else
                        throw new ModelException ("The identifier " + p_conditionCode_OID + " in p_conditionCode_OID you are trying to unrelationer, doesn't exist in ConditionEN");

                session.Update (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
