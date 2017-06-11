
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
 * Clase Assessment:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class AssessmentCAD : BasicCAD, IAssessmentCAD
{
public AssessmentCAD() : base ()
{
}

public AssessmentCAD(ISession sessionAux) : base (sessionAux)
{
}



public AssessmentEN ReadOIDDefault (int identifier
                                    )
{
        AssessmentEN assessmentEN = null;

        try
        {
                SessionInitializeTransaction ();
                assessmentEN = (AssessmentEN)session.Get (typeof(AssessmentEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return assessmentEN;
}

public System.Collections.Generic.IList<AssessmentEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AssessmentEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AssessmentEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AssessmentEN>();
                        else
                                result = session.CreateCriteria (typeof(AssessmentEN)).List<AssessmentEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AssessmentEN assessment)
{
        try
        {
                SessionInitializeTransaction ();
                AssessmentEN assessmentEN = (AssessmentEN)session.Load (typeof(AssessmentEN), assessment.Identifier);

                assessmentEN.Rating = assessment.Rating;




                session.Update (assessmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AssessmentEN assessment)
{
        try
        {
                SessionInitializeTransaction ();
                if (assessment.Practitioner != null) {
                        // Argumento OID y no colección.
                        assessment.Practitioner = (ChroniGenNHibernate.EN.Chroni.PractitionerEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PractitionerEN), assessment.Practitioner.Identifier);

                        assessment.Practitioner.AssessmentPractitioner
                        .Add (assessment);
                }
                if (assessment.Patient != null) {
                        // Argumento OID y no colección.
                        assessment.Patient = (ChroniGenNHibernate.EN.Chroni.PatientEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.PatientEN), assessment.Patient.Identifier);

                        assessment.Patient.AssessmentPractitioner
                        .Add (assessment);
                }
                if (assessment.RelatedPerson != null) {
                        // Argumento OID y no colección.
                        assessment.RelatedPerson = (ChroniGenNHibernate.EN.Chroni.RelatedPersonEN)session.Load (typeof(ChroniGenNHibernate.EN.Chroni.RelatedPersonEN), assessment.RelatedPerson.Identifier);

                        assessment.RelatedPerson.AssessmentPractitioner
                        .Add (assessment);
                }

                session.Save (assessment);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return assessment.Identifier;
}

public void Modify (AssessmentEN assessment)
{
        try
        {
                SessionInitializeTransaction ();
                AssessmentEN assessmentEN = (AssessmentEN)session.Load (typeof(AssessmentEN), assessment.Identifier);

                assessmentEN.Rating = assessment.Rating;

                session.Update (assessmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
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
                AssessmentEN assessmentEN = (AssessmentEN)session.Load (typeof(AssessmentEN), identifier);
                session.Delete (assessmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AssessmentEN
public AssessmentEN ReadOID (int identifier
                             )
{
        AssessmentEN assessmentEN = null;

        try
        {
                SessionInitializeTransaction ();
                assessmentEN = (AssessmentEN)session.Get (typeof(AssessmentEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return assessmentEN;
}

public System.Collections.Generic.IList<AssessmentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AssessmentEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AssessmentEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AssessmentEN>();
                else
                        result = session.CreateCriteria (typeof(AssessmentEN)).List<AssessmentEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<AssessmentEN> GetAverageByPractitioner (int first, int size)
{
        System.Collections.Generic.IList<AssessmentEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AssessmentEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AssessmentEN>();
                else
                        result = session.CreateCriteria (typeof(AssessmentEN)).List<AssessmentEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<AssessmentEN> GetAverageByPractitionerNif (int first, int size)
{
        System.Collections.Generic.IList<AssessmentEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AssessmentEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AssessmentEN>();
                else
                        result = session.CreateCriteria (typeof(AssessmentEN)).List<AssessmentEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> GetAverageByPractitionerRole ()
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AssessmentEN self where FROM AssessmentEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AssessmentENgetAverageByPractitionerRoleHQL");

                result = query.List<ChroniGenNHibernate.EN.Chroni.AssessmentEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in AssessmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
