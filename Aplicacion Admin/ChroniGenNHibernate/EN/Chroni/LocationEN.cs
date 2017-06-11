
using System;
// Definición clase LocationEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class LocationEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo status
 */
private ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum status;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo mode
 */
private ChroniGenNHibernate.Enumerated.Chroni.LocationModeEnum mode;



/**
 *	Atributo type
 */
private ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum type;



/**
 *	Atributo address
 */
private string address;



/**
 *	Atributo physicalType
 */
private ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum physicalType;



/**
 *	Atributo managingOrganization
 */
private string managingOrganization;



/**
 *	Atributo position
 */
private ChroniGenNHibernate.EN.Chroni.PositionEN position;



/**
 *	Atributo practitioner
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner;



/**
 *	Atributo patient
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient;



/**
 *	Atributo phone
 */
private string phone;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo postalCode
 */
private string postalCode;



/**
 *	Atributo schedule
 */
private System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> schedule;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.LocationModeEnum Mode {
        get { return mode; } set { mode = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual string Address {
        get { return address; } set { address = value;  }
}



public virtual ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum PhysicalType {
        get { return physicalType; } set { physicalType = value;  }
}



public virtual string ManagingOrganization {
        get { return managingOrganization; } set { managingOrganization = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.PositionEN Position {
        get { return position; } set { position = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> Patient {
        get { return patient; } set { patient = value;  }
}



public virtual string Phone {
        get { return phone; } set { phone = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string PostalCode {
        get { return postalCode; } set { postalCode = value;  }
}



public virtual System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> Schedule {
        get { return schedule; } set { schedule = value;  }
}





public LocationEN()
{
        practitioner = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PractitionerEN>();
        patient = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.PatientEN>();
        schedule = new System.Collections.Generic.List<ChroniGenNHibernate.EN.Chroni.ScheduleEN>();
}



public LocationEN(int identifier, ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum status, string name, string description, ChroniGenNHibernate.Enumerated.Chroni.LocationModeEnum mode, ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum type, string address, ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum physicalType, string managingOrganization, ChroniGenNHibernate.EN.Chroni.PositionEN position, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient, string phone, string email, string postalCode, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> schedule
                  )
{
        this.init (Identifier, status, name, description, mode, type, address, physicalType, managingOrganization, position, practitioner, patient, phone, email, postalCode, schedule);
}


public LocationEN(LocationEN location)
{
        this.init (Identifier, location.Status, location.Name, location.Description, location.Mode, location.Type, location.Address, location.PhysicalType, location.ManagingOrganization, location.Position, location.Practitioner, location.Patient, location.Phone, location.Email, location.PostalCode, location.Schedule);
}

private void init (int identifier
                   , ChroniGenNHibernate.Enumerated.Chroni.LocationStatusEnum status, string name, string description, ChroniGenNHibernate.Enumerated.Chroni.LocationModeEnum mode, ChroniGenNHibernate.Enumerated.Chroni.LocationTypeEnum type, string address, ChroniGenNHibernate.Enumerated.Chroni.LocationPhysicalTypeEnum physicalType, string managingOrganization, ChroniGenNHibernate.EN.Chroni.PositionEN position, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PractitionerEN> practitioner, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PatientEN> patient, string phone, string email, string postalCode, System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.ScheduleEN> schedule)
{
        this.Identifier = identifier;


        this.Status = status;

        this.Name = name;

        this.Description = description;

        this.Mode = mode;

        this.Type = type;

        this.Address = address;

        this.PhysicalType = physicalType;

        this.ManagingOrganization = managingOrganization;

        this.Position = position;

        this.Practitioner = practitioner;

        this.Patient = patient;

        this.Phone = phone;

        this.Email = email;

        this.PostalCode = postalCode;

        this.Schedule = schedule;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LocationEN t = obj as LocationEN;
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
