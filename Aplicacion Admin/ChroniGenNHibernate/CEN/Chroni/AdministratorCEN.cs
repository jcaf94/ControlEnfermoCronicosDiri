

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
 *      Definition of the class AdministratorCEN
 *
 */
public partial class AdministratorCEN
{
private IAdministratorCAD _IAdministratorCAD;

public AdministratorCEN()
{
        this._IAdministratorCAD = new AdministratorCAD ();
}

public AdministratorCEN(IAdministratorCAD _IAdministratorCAD)
{
        this._IAdministratorCAD = _IAdministratorCAD;
}

public IAdministratorCAD get_IAdministratorCAD ()
{
        return this._IAdministratorCAD;
}

public int New_ (string p_name, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, string p_photo, string p_email, String p_password, string p_surnames, string p_nif, string p_address, string p_phone)
{
        AdministratorEN administratorEN = null;
        int oid;

        //Initialized AdministratorEN
        administratorEN = new AdministratorEN ();
        administratorEN.Name = p_name;

        administratorEN.Gender = p_gender;

        administratorEN.BirthDate = p_birthDate;

        administratorEN.Photo = p_photo;

        administratorEN.Email = p_email;

        administratorEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        administratorEN.Surnames = p_surnames;

        administratorEN.Nif = p_nif;

        administratorEN.Address = p_address;

        administratorEN.Phone = p_phone;

        //Call to AdministratorCAD

        oid = _IAdministratorCAD.New_ (administratorEN);
        return oid;
}

public void Modify (int p_Administrator_OID, string p_name, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum p_gender, Nullable<DateTime> p_birthDate, string p_photo, string p_email, String p_password, string p_surnames, string p_nif, string p_address, string p_phone)
{
        AdministratorEN administratorEN = null;

        //Initialized AdministratorEN
        administratorEN = new AdministratorEN ();
        administratorEN.Identifier = p_Administrator_OID;
        administratorEN.Name = p_name;
        administratorEN.Gender = p_gender;
        administratorEN.BirthDate = p_birthDate;
        administratorEN.Photo = p_photo;
        administratorEN.Email = p_email;
        administratorEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        administratorEN.Surnames = p_surnames;
        administratorEN.Nif = p_nif;
        administratorEN.Address = p_address;
        administratorEN.Phone = p_phone;
        //Call to AdministratorCAD

        _IAdministratorCAD.Modify (administratorEN);
}

public void Destroy (int identifier
                     )
{
        _IAdministratorCAD.Destroy (identifier);
}

public AdministratorEN ReadOID (int identifier
                                )
{
        AdministratorEN administratorEN = null;

        administratorEN = _IAdministratorCAD.ReadOID (identifier);
        return administratorEN;
}

public System.Collections.Generic.IList<AdministratorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministratorEN> list = null;

        list = _IAdministratorCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorByNif (string p_nif)
{
        return _IAdministratorCAD.GetAdministratorByNif (p_nif);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsBySurnames (string p_surnames)
{
        return _IAdministratorCAD.GetAdministratorsBySurnames (p_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByNames_Surnames (string p_name, string p_surnames)
{
        return _IAdministratorCAD.GetAdministratorsByNames_Surnames (p_name, p_surnames);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByPhone (string p_phone)
{
        return _IAdministratorCAD.GetAdministratorsByPhone (p_phone);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.AdministratorEN> GetAdministratorsByEmail (string p_email)
{
        return _IAdministratorCAD.GetAdministratorsByEmail (p_email);
}
}
}
