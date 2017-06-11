

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
 *      Definition of the class ReclamationResponseCEN
 *
 */
public partial class ReclamationResponseCEN
{
private IReclamationResponseCAD _IReclamationResponseCAD;

public ReclamationResponseCEN()
{
        this._IReclamationResponseCAD = new ReclamationResponseCAD ();
}

public ReclamationResponseCEN(IReclamationResponseCAD _IReclamationResponseCAD)
{
        this._IReclamationResponseCAD = _IReclamationResponseCAD;
}

public IReclamationResponseCAD get_IReclamationResponseCAD ()
{
        return this._IReclamationResponseCAD;
}

public int New_ (string p_response, ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum p_actionState, Nullable<DateTime> p_createdDate, int p_reclamation)
{
        ReclamationResponseEN reclamationResponseEN = null;
        int oid;

        //Initialized ReclamationResponseEN
        reclamationResponseEN = new ReclamationResponseEN ();
        reclamationResponseEN.Response = p_response;

        reclamationResponseEN.ActionState = p_actionState;

        reclamationResponseEN.CreatedDate = p_createdDate;


        if (p_reclamation != -1) {
                // El argumento p_reclamation -> Property reclamation es oid = false
                // Lista de oids identifier
                reclamationResponseEN.Reclamation = new ChroniGenNHibernate.EN.Chroni.ReclamationEN ();
                reclamationResponseEN.Reclamation.Identifier = p_reclamation;
        }

        //Call to ReclamationResponseCAD

        oid = _IReclamationResponseCAD.New_ (reclamationResponseEN);
        return oid;
}

public void Modify (int p_ReclamationResponse_OID, string p_response, ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum p_actionState, Nullable<DateTime> p_createdDate)
{
        ReclamationResponseEN reclamationResponseEN = null;

        //Initialized ReclamationResponseEN
        reclamationResponseEN = new ReclamationResponseEN ();
        reclamationResponseEN.Identifier = p_ReclamationResponse_OID;
        reclamationResponseEN.Response = p_response;
        reclamationResponseEN.ActionState = p_actionState;
        reclamationResponseEN.CreatedDate = p_createdDate;
        //Call to ReclamationResponseCAD

        _IReclamationResponseCAD.Modify (reclamationResponseEN);
}

public void Destroy (int identifier
                     )
{
        _IReclamationResponseCAD.Destroy (identifier);
}

public ReclamationResponseEN ReadOID (int identifier
                                      )
{
        ReclamationResponseEN reclamationResponseEN = null;

        reclamationResponseEN = _IReclamationResponseCAD.ReadOID (identifier);
        return reclamationResponseEN;
}

public System.Collections.Generic.IList<ReclamationResponseEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReclamationResponseEN> list = null;

        list = _IReclamationResponseCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponsesByInterval (Nullable<DateTime> p_createdDateFrom, Nullable<DateTime> p_createdDateTo)
{
        return _IReclamationResponseCAD.GetReclamationResponsesByInterval (p_createdDateFrom, p_createdDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponsesByActionState_Interval (ChroniGenNHibernate.Enumerated.Chroni.ReclamationResponseActionStateEnum? p_actionState, Nullable<DateTime> p_createdDateFrom, Nullable<DateTime> p_createdDateTo)
{
        return _IReclamationResponseCAD.GetReclamationResponsesByActionState_Interval (p_actionState, p_createdDateFrom, p_createdDateTo);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ReclamationResponseEN> GetReclamationResponseByReclamation (int p_Reclamation_OID)
{
        return _IReclamationResponseCAD.GetReclamationResponseByReclamation (p_Reclamation_OID);
}
}
}
