

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
 *      Definition of the class MedicationCEN
 *
 */
public partial class MedicationCEN
{
private IMedicationCAD _IMedicationCAD;

public MedicationCEN()
{
        this._IMedicationCAD = new MedicationCAD ();
}

public MedicationCEN(IMedicationCAD _IMedicationCAD)
{
        this._IMedicationCAD = _IMedicationCAD;
}

public IMedicationCAD get_IMedicationCAD ()
{
        return this._IMedicationCAD;
}

public int New_ (string p_name, string p_manufacturer, string p_description, ChroniGenNHibernate.Enumerated.Chroni.FormEnum p_form, double p_rate, string p_dosage, ChroniGenNHibernate.Enumerated.Chroni.MedicationStatusEnum p_status, bool p_isOverTheCounter)
{
        MedicationEN medicationEN = null;
        int oid;

        //Initialized MedicationEN
        medicationEN = new MedicationEN ();
        medicationEN.Name = p_name;

        medicationEN.Manufacturer = p_manufacturer;

        medicationEN.Description = p_description;

        medicationEN.Form = p_form;

        medicationEN.Rate = p_rate;

        medicationEN.Dosage = p_dosage;

        medicationEN.Status = p_status;

        medicationEN.IsOverTheCounter = p_isOverTheCounter;

        //Call to MedicationCAD

        oid = _IMedicationCAD.New_ (medicationEN);
        return oid;
}

public void Modify (int p_Medication_OID, string p_name, string p_manufacturer, string p_description, ChroniGenNHibernate.Enumerated.Chroni.FormEnum p_form, double p_rate, string p_dosage, ChroniGenNHibernate.Enumerated.Chroni.MedicationStatusEnum p_status, bool p_isOverTheCounter)
{
        MedicationEN medicationEN = null;

        //Initialized MedicationEN
        medicationEN = new MedicationEN ();
        medicationEN.Identifier = p_Medication_OID;
        medicationEN.Name = p_name;
        medicationEN.Manufacturer = p_manufacturer;
        medicationEN.Description = p_description;
        medicationEN.Form = p_form;
        medicationEN.Rate = p_rate;
        medicationEN.Dosage = p_dosage;
        medicationEN.Status = p_status;
        medicationEN.IsOverTheCounter = p_isOverTheCounter;
        //Call to MedicationCAD

        _IMedicationCAD.Modify (medicationEN);
}

public void Destroy (int identifier
                     )
{
        _IMedicationCAD.Destroy (identifier);
}

public MedicationEN ReadOID (int identifier
                             )
{
        MedicationEN medicationEN = null;

        medicationEN = _IMedicationCAD.ReadOID (identifier);
        return medicationEN;
}

public System.Collections.Generic.IList<MedicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MedicationEN> list = null;

        list = _IMedicationCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsBySubstanceCodeCode (string p_SubstanceCode_code)
{
        return _IMedicationCAD.GetMedicationsBySubstanceCodeCode (p_SubstanceCode_code);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form ()
{
        return _IMedicationCAD.GetMedicationsByIngredients_Form ();
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form_OverTheCounter ()
{
        return _IMedicationCAD.GetMedicationsByIngredients_Form_OverTheCounter ();
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByIngredients_Form_Manufacturer ()
{
        return _IMedicationCAD.GetMedicationsByIngredients_Form_Manufacturer ();
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByActivity (int p_Activity_OID)
{
        return _IMedicationCAD.GetMedicationsByActivity (p_Activity_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByPatient (int p_Patient_OID)
{
        return _IMedicationCAD.GetMedicationsByPatient (p_Patient_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsByPatientNif (string p_Patient_nif)
{
        return _IMedicationCAD.GetMedicationsByPatientNif (p_Patient_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.MedicationEN> GetMedicationsBySubstanceCodeDisplay (string p_SubstanceCode_display)
{
        return _IMedicationCAD.GetMedicationsBySubstanceCodeDisplay (p_SubstanceCode_display);
}
public void AssignIngredient (int p_Medication_OID, System.Collections.Generic.IList<int> p_ingredient_OIDs)
{
        //Call to MedicationCAD

        _IMedicationCAD.AssignIngredient (p_Medication_OID, p_ingredient_OIDs);
}
public void UnassignIngredient (int p_Medication_OID, System.Collections.Generic.IList<int> p_ingredient_OIDs)
{
        //Call to MedicationCAD

        _IMedicationCAD.UnassignIngredient (p_Medication_OID, p_ingredient_OIDs);
}
}
}
