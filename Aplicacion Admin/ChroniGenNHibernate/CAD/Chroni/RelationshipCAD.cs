
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
 * Clase Relationship:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class RelationshipCAD : BasicCAD, IRelationshipCAD
{
public RelationshipCAD() : base ()
{
}

public RelationshipCAD(ISession sessionAux) : base (sessionAux)
{
}



public RelationshipEN ReadOIDDefault (int identifier
                                      )
{
        RelationshipEN relationshipEN = null;

        try
        {
                SessionInitializeTransaction ();
                relationshipEN = (RelationshipEN)session.Get (typeof(RelationshipEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relationshipEN;
}

public System.Collections.Generic.IList<RelationshipEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RelationshipEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RelationshipEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RelationshipEN>();
                        else
                                result = session.CreateCriteria (typeof(RelationshipEN)).List<RelationshipEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RelationshipEN relationship)
{
        try
        {
                SessionInitializeTransaction ();
                RelationshipEN relationshipEN = (RelationshipEN)session.Load (typeof(RelationshipEN), relationship.Identifier);

                relationshipEN.Relationship = relationship.Relationship;


                relationshipEN.PatientOID = relationship.PatientOID;


                relationshipEN.RelatedPersonOID = relationship.RelatedPersonOID;

                session.Update (relationshipEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RelationshipEN relationship)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (relationship);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relationship.Identifier;
}

public void Modify (RelationshipEN relationship)
{
        try
        {
                SessionInitializeTransaction ();
                RelationshipEN relationshipEN = (RelationshipEN)session.Load (typeof(RelationshipEN), relationship.Identifier);

                relationshipEN.Relationship = relationship.Relationship;


                relationshipEN.PatientOID = relationship.PatientOID;


                relationshipEN.RelatedPersonOID = relationship.RelatedPersonOID;

                session.Update (relationshipEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
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
                RelationshipEN relationshipEN = (RelationshipEN)session.Load (typeof(RelationshipEN), identifier);
                session.Delete (relationshipEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RelationshipEN
public RelationshipEN ReadOID (int identifier
                               )
{
        RelationshipEN relationshipEN = null;

        try
        {
                SessionInitializeTransaction ();
                relationshipEN = (RelationshipEN)session.Get (typeof(RelationshipEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relationshipEN;
}

public System.Collections.Generic.IList<RelationshipEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RelationshipEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RelationshipEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RelationshipEN>();
                else
                        result = session.CreateCriteria (typeof(RelationshipEN)).List<RelationshipEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> GetRelationshipByPatient (int p_Patient_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelationshipEN self where FROM RelationshipEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelationshipENgetRelationshipByPatientHQL");
                query.SetParameter ("p_Patient_OID", p_Patient_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelationshipEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> GetRelationshipByRelatedPerson (string p_RelatedPerson_OID)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.RelationshipEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM RelationshipEN self where FROM RelationshipEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("RelationshipENgetRelationshipByRelatedPersonHQL");
                query.SetParameter ("p_RelatedPerson_OID", p_RelatedPerson_OID);

                result = query.List<ChroniGenNHibernate.EN.Chroni.RelationshipEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in RelationshipCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
