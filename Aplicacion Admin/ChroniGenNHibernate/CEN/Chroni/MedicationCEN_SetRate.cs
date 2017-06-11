
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Medication_setRate) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class MedicationCEN
{
public void SetRate (int p_oid, double p_rate)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Medication_setRate) ENABLED START*/

        // Write here your custom code...

        MedicationCAD medicationCAD = new MedicationCAD ();
        MedicationCEN medicationCEN = new MedicationCEN (medicationCAD);

        if (p_oid > 0) {
                MedicationEN medication = medicationCEN.ReadOID (p_oid);

                if (medication != null) {
                        if (p_rate >= 0) {
                                medication.Rate = p_rate;
                                medicationCAD.Modify (medication);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
