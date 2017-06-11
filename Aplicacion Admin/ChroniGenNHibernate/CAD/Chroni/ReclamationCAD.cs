
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
 * Clase Reclamation:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class ReclamationCAD : BasicCAD, IReclamationCAD
{
public ReclamationCAD() : base ()
{
}

public ReclamationCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReclamationEN ReadOIDDefault (int identifier
                                     )
{
        ReclamationEN reclamationEN = null;

        try
        {
                SessionInitializeTransaction ();
                reclamationEN = (ReclamationEN)session.Get (typeof(ReclamationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reclamationEN;
}

public System.Collections.Generic.IList<ReclamationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReclamationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReclamationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReclamationEN>();
                        else
                                result = session.CreateCriteria (typeof(ReclamationEN)).List<ReclamationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReclamationEN reclamation)
{
        try
        {
                SessionInitializeTransaction ();
                ReclamationEN reclamationEN = (ReclamationEN)session.Load (typeof(ReclamationEN), reclamation.Identifier);

                reclamationEN.Action = reclamation.Action;


                reclamationEN.Subject = reclamation.Subject;


                reclamationEN.Content = reclamation.Content;


                reclamationEN.StartDate = reclamation.StartDate;





                reclamationEN.Note = reclamation.Note;


                reclamationEN.Resolved = reclamation.Resolved;


                reclamationEN.Type = reclamation.Type;


                session.Update (reclamationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReclamationEN reclamation)
{
        try
        {
                SessionInitializeTransaction ();
                if (reclamation.Practitioner != null) {
                        // Argumento OID y no colección.
                        reclamation.Practitioner = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), reclamation.Practitioner.Identifier);

                        reclamation.Practitioner.Reclamation
                        .Add (reclamation);
                }

                session.Save (reclamation);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reclamation.Identifier;
}

public void Modify (ReclamationEN reclamation)
{
        try
        {
                SessionInitializeTransaction ();
                ReclamationEN reclamationEN = (ReclamationEN)session.Load (typeof(ReclamationEN), reclamation.Identifier);

                reclamationEN.Action = reclamation.Action;


                reclamationEN.Subject = reclamation.Subject;


                reclamationEN.Content = reclamation.Content;


                reclamationEN.StartDate = reclamation.StartDate;


                reclamationEN.Note = reclamation.Note;


                reclamationEN.Resolved = reclamation.Resolved;


                reclamationEN.Type = reclamation.Type;

                session.Update (reclamationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
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
                ReclamationEN reclamationEN = (ReclamationEN)session.Load (typeof(ReclamationEN), identifier);
                session.Delete (reclamationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ReclamationEN
public ReclamationEN ReadOID (int identifier
                              )
{
        ReclamationEN reclamationEN = null;

        try
        {
                SessionInitializeTransaction ();
                reclamationEN = (ReclamationEN)session.Get (typeof(ReclamationEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reclamationEN;
}

public System.Collections.Generic.IList<ReclamationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReclamationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReclamationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReclamationEN>();
                else
                        result = session.CreateCriteria (typeof(ReclamationEN)).List<ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByStartInterval (Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByStartIntervalHQL");
                query.SetParameter ("p_startDateFrom", p_startDateFrom);
                query.SetParameter ("p_startDateTo", p_startDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByResolved_ResponseInterval (bool? p_resolved, Nullable<DateTime> p_ReclamationResponse_createdDateFrom, Nullable<DateTime> p_ReclamationResponse_createdDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByResolved_ResponseIntervalHQL");
                query.SetParameter ("p_resolved", p_resolved);
                query.SetParameter ("p_ReclamationResponse_createdDateFrom", p_ReclamationResponse_createdDateFrom);
                query.SetParameter ("p_ReclamationResponse_createdDateTo", p_ReclamationResponse_createdDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitionerNif (string p_Practitioner_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByPractitionerNifHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByType_StartInterval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum? p_type, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByType_StartIntervalHQL");
                query.SetParameter ("p_type", p_type);
                query.SetParameter ("p_startDateFrom", p_startDateFrom);
                query.SetParameter ("p_startDateTo", p_startDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByResolved_StartInterval (bool? p_resolved, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByResolved_StartIntervalHQL");
                query.SetParameter ("p_resolved", p_resolved);
                query.SetParameter ("p_startDateFrom", p_startDateFrom);
                query.SetParameter ("p_startDateTo", p_startDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByAction_StartInterval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum? p_reclamationType, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByAction_StartIntervalHQL");
                query.SetParameter ("p_reclamationType", p_reclamationType);
                query.SetParameter ("p_startDateFrom", p_startDateFrom);
                query.SetParameter ("p_startDateTo", p_startDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByAction_StartInterval_Patient (ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum? p_action, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo, int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByAction_StartInterval_PatientHQL");
                query.SetParameter ("p_action", p_action);
                query.SetParameter ("p_startDateFrom", p_startDateFrom);
                query.SetParameter ("p_startDateTo", p_startDateTo);
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByRelatedPersonNif (string p_RelatedPerson_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationByRelatedPersonNifHQL");
                query.SetParameter ("p_RelatedPerson_nif", p_RelatedPerson_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByAction_StartInterval_RelatedPerson (ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum? p_action, Nullable<DateTime> p_startDateFrom, Nullable<DateTime> p_startDateTo, int p_RelatedPerson_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationByAction_StartInterval_RelatedPersonHQL");
                query.SetParameter ("p_action", p_action);
                query.SetParameter ("p_startDateFrom", p_startDateFrom);
                query.SetParameter ("p_startDateTo", p_startDateTo);
                query.SetParameter ("p_RelatedPerson_OID", p_RelatedPerson_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByEndInterval (Nullable<DateTime> p_ReclamationResponse_createdDateFrom, Nullable<DateTime> p_ReclamationResponse_createdDateTo)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationByEndIntervalHQL");
                query.SetParameter ("p_ReclamationResponse_createdDateFrom", p_ReclamationResponse_createdDateFrom);
                query.SetParameter ("p_ReclamationResponse_createdDateTo", p_ReclamationResponse_createdDateTo);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPersonNif (string p_RelatedPerson_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByRelatedPersonNifHQL");
                query.SetParameter ("p_RelatedPerson_nif", p_RelatedPerson_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPatient (int p_patient)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByPatientHQL");
                query.SetParameter ("p_patient", p_patient);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPerson (int p_RelatedPerson_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByRelatedPersonHQL");
                query.SetParameter ("p_RelatedPerson_OID", p_RelatedPerson_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitioner (int p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByPractitionerHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationByReclamationResponseActionState (ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum ? p_ReclamationResponse_actionState)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationByReclamationResponseActionStateHQL");
                query.SetParameter ("p_ReclamationResponse_actionState", p_ReclamationResponse_actionState);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPatientSurnames (string p_Patient_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByPatientSurnamesHQL");
                query.SetParameter ("p_Patient_surnames", p_Patient_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByRelatedPersonSurnames (string p_RelatedPerson_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByRelatedPersonSurnamesHQL");
                query.SetParameter ("p_RelatedPerson_surnames", p_RelatedPerson_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByPractitionerSurnames (string p_Practitioner_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByPractitionerSurnamesHQL");
                query.SetParameter ("p_Practitioner_surnames", p_Practitioner_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsBySubject (string p_subject)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsBySubjectHQL");
                query.SetParameter ("p_subject", p_subject);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByContent (string p_content)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByContentHQL");
                query.SetParameter ("p_content", p_content);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> GetReclamationsByNote (string p_note)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReclamationEN self where FROM ReclamationEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReclamationENgetReclamationsByNoteHQL");
                query.SetParameter ("p_note", p_note);

                result = query.List<ChroniGenNHibernate.EN.Chroni.ReclamationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignPractitioner (int p_Reclamation_OID, int p_practitioner_OID)
{
        ChroniGenNHibernate.EN.Chroni.ReclamationEN reclamationEN = null;
        try
        {
                SessionInitializeTransaction ();
                reclamationEN = (ReclamationEN)session.Load (typeof(ReclamationEN), p_Reclamation_OID);
                reclamationEN.Practitioner = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), p_practitioner_OID);

                reclamationEN.Practitioner.Reclamation.Add (reclamationEN);



                session.Update (reclamationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignPractitioner (int p_Reclamation_OID, int p_practitioner_OID)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.ReclamationEN reclamationEN = null;
                reclamationEN = (ReclamationEN)session.Load (typeof(ReclamationEN), p_Reclamation_OID);

                if (reclamationEN.Practitioner.Identifier == p_practitioner_OID) {
                        reclamationEN.Practitioner = null;
                }
                else
                        throw new ModelException ("The identifier " + p_practitioner_OID + " in p_practitioner_OID you are trying to unrelationer, doesn't exist in ReclamationEN");

                session.Update (reclamationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in ReclamationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
