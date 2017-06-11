
using System;
// Definición clase AdministratorEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class AdministratorEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo gender
 */
private ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender;



/**
 *	Atributo birthDate
 */
private Nullable<DateTime> birthDate;



/**
 *	Atributo photo
 */
private string photo;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo surnames
 */
private string surnames;



/**
 *	Atributo nif
 */
private string nif;



/**
 *	Atributo address
 */
private string address;



/**
 *	Atributo phone
 */
private string phone;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.GenderEnum Gender {
        get { return gender; } set { gender = value;  }
}



public virtual Nullable<DateTime> BirthDate {
        get { return birthDate; } set { birthDate = value;  }
}



public virtual string Photo {
        get { return photo; } set { photo = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual string Surnames {
        get { return surnames; } set { surnames = value;  }
}



public virtual string Nif {
        get { return nif; } set { nif = value;  }
}



public virtual string Address {
        get { return address; } set { address = value;  }
}



public virtual string Phone {
        get { return phone; } set { phone = value;  }
}





public AdministratorEN()
{
}



public AdministratorEN(int identifier, string name, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, string photo, string email, String password, string surnames, string nif, string address, string phone
                       )
{
        this.init (Identifier, name, gender, birthDate, photo, email, password, surnames, nif, address, phone);
}


public AdministratorEN(AdministratorEN administrator)
{
        this.init (Identifier, administrator.Name, administrator.Gender, administrator.BirthDate, administrator.Photo, administrator.Email, administrator.Password, administrator.Surnames, administrator.Nif, administrator.Address, administrator.Phone);
}

private void init (int identifier
                   , string name, ChroniGenNHibernate.Enumerated.Chroni.GenderEnum gender, Nullable<DateTime> birthDate, string photo, string email, String password, string surnames, string nif, string address, string phone)
{
        this.Identifier = identifier;


        this.Name = name;

        this.Gender = gender;

        this.BirthDate = birthDate;

        this.Photo = photo;

        this.Email = email;

        this.Password = password;

        this.Surnames = surnames;

        this.Nif = nif;

        this.Address = address;

        this.Phone = phone;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministratorEN t = obj as AdministratorEN;
        if (t == null)
                return false;
        if (Identifier.Equals (t.Identifier))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Identifier.GetHashCode ();
        return hash;
}
}
}
