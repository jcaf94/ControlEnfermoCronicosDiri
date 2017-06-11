

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
 *      Definition of the class AssessmentCEN
 *
 */
public partial class AssessmentCEN
{
private IAssessmentCAD _IAssessmentCAD;

public AssessmentCEN()
{
        this._IAssessmentCAD = new AssessmentCAD ();
}

public AssessmentCEN(IAssessmentCAD _IAssessmentCAD)
{
        this._IAssessmentCAD = _IAssessmentCAD;
}

public IAssessmentCAD get_IAssessmentCAD ()
{
        return this._IAssessmentCAD;
}

public void Modify (int p_Assessment_OID, int p_rating)
{
        AssessmentEN assessmentEN = null;

        //Initialized AssessmentEN
        assessmentEN = new AssessmentEN ();
        assessmentEN.Identifier = p_Assessment_OID;
        assessmentEN.Rating = p_rating;
        //Call to AssessmentCAD

        _IAssessmentCAD.Modify (assessmentEN);
}

public void Destroy (int identifier
                     )
{
        _IAssessmentCAD.Destroy (identifier);
}

public AssessmentEN ReadOID (int identifier
                             )
{
        AssessmentEN assessmentEN = null;

        assessmentEN = _IAssessmentCAD.ReadOID (identifier);
        return assessmentEN;
}

public System.Collections.Generic.IList<AssessmentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AssessmentEN> list = null;

        list = _IAssessmentCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<AssessmentEN> GetAverageByPractitioner (int first, int size)
{
        System.Collections.Generic.IList<AssessmentEN> list = null;

        list = _IAssessmentCAD.GetAverageByPractitioner (first, size);
        return list;
}
public System.Collections.Generic.IList<AssessmentEN> GetAverageByPractitionerNif (int first, int size)
{
        System.Collections.Generic.IList<AssessmentEN> list = null;

        list = _IAssessmentCAD.GetAverageByPractitionerNif (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AssessmentEN> GetAverageByPractitionerRole ()
{
        return _IAssessmentCAD.GetAverageByPractitionerRole ();
}
}
}
