
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ChroniGenNHibernate.Exceptions;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.CAD.Chroni;


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Reclamation_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class ReclamationCEN
{
public int New_ (ChroniGenNHibernate.Enumerated.Chroni.ReclamationActionEnum p_action, string p_subject, string p_content, Nullable<DateTime> p_startDate, int p_practitioner, string p_note, bool p_resolved, ChroniGenNHibernate.Enumerated.Chroni.ReclamationTypeEnum p_type)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Reclamation_new__customized) START*/

        ReclamationEN reclamationEN = null;

        int oid;

        //Initialized ReclamationEN
        reclamationEN = new ReclamationEN ();
        reclamationEN.Action = p_action;

        reclamationEN.Subject = p_subject;

        reclamationEN.Content = p_content;

        reclamationEN.StartDate = p_startDate;


        if (p_practitioner != -1) {
                reclamationEN.Practitioner = new ChroniGenNHibernate.EN.Chroni.PractitionerEN ();
                reclamationEN.Practitioner.Identifier = p_practitioner;
        }

        reclamationEN.Note = p_note;

        reclamationEN.Resolved = p_resolved;

        reclamationEN.Type = p_type;

        //Call to ReclamationCAD

        oid = _IReclamationCAD.New_ (reclamationEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
