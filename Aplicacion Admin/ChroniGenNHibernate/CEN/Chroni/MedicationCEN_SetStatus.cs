
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


/*PROTECTED REGION ID(usingChroniGenNHibernate.CEN.Chroni_Medication_setStatus) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ChroniGenNHibernate.CEN.Chroni
{
public partial class MedicationCEN
{
public void SetStatus (int p_oid, ChroniGenNHibernate.Enumerated.Chroni.MedicationStatusEnum p_status)
{
        /*PROTECTED REGION ID(ChroniGenNHibernate.CEN.Chroni_Medication_setStatus) ENABLED START*/

        // Write here your custom code...

        MedicationCAD medicationCAD = new MedicationCAD ();
        MedicationCEN medicationCEN = new MedicationCEN (medicationCAD);

        if (p_oid > 0) {
                MedicationEN medication = medicationCEN.ReadOID (p_oid);

                if (medication != null) {
                        if (p_status > 0) {
                                medication.Status = p_status;
                                medicationCAD.Modify (medication);
                        }
                }
        }

        /*PROTECTED REGION END*/
}
}
}
