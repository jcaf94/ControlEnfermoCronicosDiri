
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Medication_setDosage) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class MedicationCEN
{
public void SetDosage (int p_oid, string p_dosage)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Medication_setDosage) ENABLED START*/

        // Write here your custom code...

        MedicationCAD medicationCAD = new MedicationCAD ();
        MedicationCEN medicationCEN = new MedicationCEN (medicationCAD);

        if (p_oid > 0) {
                MedicationEN medication = medicationCEN.ReadOID (p_oid);

                if (medication != null) {
                        if (!string.IsNullOrEmpty (p_dosage)) {
                                medication.Dosage = p_dosage;
                                medicationCAD.Modify (medication);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
