
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Diary_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class DiaryCEN
{
public int New_ (int p_patient)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Diary_new__customized) START*/

        DiaryEN diaryEN = null;

        int oid;

        //Initialized DiaryEN
        diaryEN = new DiaryEN ();

        if (p_patient != -1) {
                diaryEN.Patient = new ChroniGenNHibernate.EN.Chroni.PatientEN ();
                diaryEN.Patient.Identifier = p_patient;
        }

        //Call to DiaryCAD

        oid = _IDiaryCAD.New_ (diaryEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
