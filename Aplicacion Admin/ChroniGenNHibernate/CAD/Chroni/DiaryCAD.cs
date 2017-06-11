
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
 * Clase Diary:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class DiaryCAD : BasicCAD, IDiaryCAD
{
public DiaryCAD() : base ()
{
}

public DiaryCAD(ISession sessionAux) : base (sessionAux)
{
}



public DiaryEN ReadOIDDefault (int identifier
                               )
{
        DiaryEN diaryEN = null;

        try
        {
                SessionInitializeTransaction ();
                diaryEN = (DiaryEN)session.Get (typeof(DiaryEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diaryEN;
}

public System.Collections.Generic.IList<DiaryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DiaryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DiaryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DiaryEN>();
                        else
                                result = session.CreateCriteria (typeof(DiaryEN)).List<DiaryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DiaryEN diary)
{
        try
        {
                SessionInitializeTransaction ();
                DiaryEN diaryEN = (DiaryEN)session.Load (typeof(DiaryEN), diary.Identifier);



                session.Update (diaryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (DiaryEN diary)
{
        try
        {
                SessionInitializeTransaction ();
                if (diary.Patient != null) {
                        // Argumento OID y no colección.
                        diary.Patient = (ChroniGenNHibernate.EN.Chroni.PatientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PatientEN), diary.Patient.Identifier);

                        diary.Patient.Diary
                                = diary;
                }

                session.Save (diary);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diary.Identifier;
}

public void Modify (DiaryEN diary)
{
        try
        {
                SessionInitializeTransaction ();
                DiaryEN diaryEN = (DiaryEN)session.Load (typeof(DiaryEN), diary.Identifier);
                session.Update (diaryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
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
                DiaryEN diaryEN = (DiaryEN)session.Load (typeof(DiaryEN), identifier);
                session.Delete (diaryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: DiaryEN
public DiaryEN ReadOID (int identifier
                        )
{
        DiaryEN diaryEN = null;

        try
        {
                SessionInitializeTransaction ();
                diaryEN = (DiaryEN)session.Get (typeof(DiaryEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diaryEN;
}

public System.Collections.Generic.IList<DiaryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DiaryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DiaryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DiaryEN>();
                else
                        result = session.CreateCriteria (typeof(DiaryEN)).List<DiaryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitioner (int p_Practitioner_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaryEN self where FROM DiaryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaryENgetDiariesByPractitionerHQL");
                query.SetParameter ("p_Practitioner_OID", p_Practitioner_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.DiaryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitionerNif (string p_Practitioner_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaryEN self where FROM DiaryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaryENgetDiariesByPractitionerNifHQL");
                query.SetParameter ("p_Practitioner_nif", p_Practitioner_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.DiaryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiariesByPractitionerSurnames (string p_Practitioner_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaryEN self where FROM DiaryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaryENgetDiariesByPractitionerSurnamesHQL");
                query.SetParameter ("p_Practitioner_surnames", p_Practitioner_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.DiaryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AssignPractitioner (int p_Diary_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        ChroniGenNHibernate.EN.Chroni.DiaryEN diaryEN = null;
        try
        {
                SessionInitializeTransaction ();
                diaryEN = (DiaryEN)session.Load (typeof(DiaryEN), p_Diary_OID);
                ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerENAux = null;
                if (diaryEN.Practitioner == null) {
                        diaryEN.Practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
                }

                foreach (int item in p_practitioner_OIDs) {
                        practitionerENAux = new ChroniGenNHibernate.EN.Chroni.PractitionerEN ();
                        practitionerENAux = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), item);
                        practitionerENAux.Diary.Add (diaryEN);

                        diaryEN.Practitioner.Add (practitionerENAux);
                }


                session.Update (diaryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnassignPractitioner (int p_Diary_OID, System.Collections.Generic.IList<int> p_practitioner_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ChroniGenNHibernate.EN.Chroni.DiaryEN diaryEN = null;
                diaryEN = (DiaryEN)session.Load (typeof(DiaryEN), p_Diary_OID);

                ChroniGenNHibernate.EN.Chroni.PractitionerEN practitionerENAux = null;
                if (diaryEN.Practitioner != null) {
                        foreach (int item in p_practitioner_OIDs) {
                                practitionerENAux = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), item);
                                if (diaryEN.Practitioner.Contains (practitionerENAux) == true) {
                                        diaryEN.Practitioner.Remove (practitionerENAux);
                                        practitionerENAux.Diary.Remove (diaryEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_practitioner_OIDs you are trying to unrelationer, doesn't exist in DiaryEN");
                        }
                }

                session.Update (diaryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatient (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaryEN self where FROM DiaryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaryENgetDiaryByPatientHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.DiaryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatientNif (string p_Patient_nif)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaryEN self where FROM DiaryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaryENgetDiaryByPatientNifHQL");
                query.SetParameter ("p_Patient_nif", p_Patient_nif);

                result = query.List<ChroniGenNHibernate.EN.Chroni.DiaryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> GetDiaryByPatientSurnames (string p_Patient_surnames)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.DiaryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaryEN self where FROM DiaryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaryENgetDiaryByPatientSurnamesHQL");
                query.SetParameter ("p_Patient_surnames", p_Patient_surnames);

                result = query.List<ChroniGenNHibernate.EN.Chroni.DiaryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in DiaryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
