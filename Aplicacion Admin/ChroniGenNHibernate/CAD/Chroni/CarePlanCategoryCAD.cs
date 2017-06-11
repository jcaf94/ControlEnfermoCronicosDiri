
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
 * Clase CarePlanCategory:
 *
 */

namespace ChroniGenNHibernate.CAD.Chroni
{
public partial class CarePlanCategoryCAD : BasicCAD, ICarePlanCategoryCAD
{
public CarePlanCategoryCAD() : base ()
{
}

public CarePlanCategoryCAD(ISession sessionAux) : base (sessionAux)
{
}



public CarePlanCategoryEN ReadOIDDefault (int identifier
                                          )
{
        CarePlanCategoryEN carePlanCategoryEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanCategoryEN = (CarePlanCategoryEN)session.Get (typeof(CarePlanCategoryEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanCategoryEN;
}

public System.Collections.Generic.IList<CarePlanCategoryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CarePlanCategoryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CarePlanCategoryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CarePlanCategoryEN>();
                        else
                                result = session.CreateCriteria (typeof(CarePlanCategoryEN)).List<CarePlanCategoryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CarePlanCategoryEN carePlanCategory)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanCategoryEN carePlanCategoryEN = (CarePlanCategoryEN)session.Load (typeof(CarePlanCategoryEN), carePlanCategory.Identifier);

                carePlanCategoryEN.Code = carePlanCategory.Code;


                carePlanCategoryEN.Display = carePlanCategory.Display;


                session.Update (carePlanCategoryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CarePlanCategoryEN carePlanCategory)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (carePlanCategory);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanCategory.Identifier;
}

public void Modify (CarePlanCategoryEN carePlanCategory)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanCategoryEN carePlanCategoryEN = (CarePlanCategoryEN)session.Load (typeof(CarePlanCategoryEN), carePlanCategory.Identifier);

                carePlanCategoryEN.Code = carePlanCategory.Code;


                carePlanCategoryEN.Display = carePlanCategory.Display;

                session.Update (carePlanCategoryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
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
                CarePlanCategoryEN carePlanCategoryEN = (CarePlanCategoryEN)session.Load (typeof(CarePlanCategoryEN), identifier);
                session.Delete (carePlanCategoryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CarePlanCategoryEN
public CarePlanCategoryEN ReadOID (int identifier
                                   )
{
        CarePlanCategoryEN carePlanCategoryEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanCategoryEN = (CarePlanCategoryEN)session.Get (typeof(CarePlanCategoryEN), identifier);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanCategoryEN;
}

public System.Collections.Generic.IList<CarePlanCategoryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanCategoryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CarePlanCategoryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CarePlanCategoryEN>();
                else
                        result = session.CreateCriteria (typeof(CarePlanCategoryEN)).List<CarePlanCategoryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> GetCarePlanCategoryByCode (string p_code)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanCategoryEN self where FROM CarePlanCategoryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanCategoryENGetCarePlanCategoryByCodeHQL");
                query.SetParameter ("p_code", p_code);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> GetCarePlanCategoryByDisplay (string p_display)
{
        System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CarePlanCategoryEN self where FROM CarePlanCategoryEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CarePlanCategoryENGetCarePlanCategoryByDisplayHQL");
                query.SetParameter ("p_display", p_display);

                result = query.List<ChroniGenNHibernate.EN.Chroni.CarePlanCategoryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ChroniGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ChroniGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCategoryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
