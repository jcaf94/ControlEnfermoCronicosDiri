
using System;
// Definición clase PositionEN
namespace ChroniGenNHibernate.EN.Chroni
{
public partial class PositionEN
{
/**
 *	Atributo identifier
 */
private int identifier;



/**
 *	Atributo latitude
 */
private double latitude;



/**
 *	Atributo longitude
 */
private double longitude;



/**
 *	Atributo altitude
 */
private double altitude;



/**
 *	Atributo location
 */
private ChroniGenNHibernate.EN.Chroni.LocationEN location;






public virtual int Identifier {
        get { return identifier; } set { identifier = value;  }
}



public virtual double Latitude {
        get { return latitude; } set { latitude = value;  }
}



public virtual double Longitude {
        get { return longitude; } set { longitude = value;  }
}



public virtual double Altitude {
        get { return altitude; } set { altitude = value;  }
}



public virtual ChroniGenNHibernate.EN.Chroni.LocationEN Location {
        get { return location; } set { location = value;  }
}





public PositionEN()
{
}



public PositionEN(int identifier, double latitude, double longitude, double altitude, ChroniGenNHibernate.EN.Chroni.LocationEN location
                  )
{
        this.init (Identifier, latitude, longitude, altitude, location);
}


public PositionEN(PositionEN position)
{
        this.init (Identifier, position.Latitude, position.Longitude, position.Altitude, position.Location);
}

private void init (int identifier
                   , double latitude, double longitude, double altitude, ChroniGenNHibernate.EN.Chroni.LocationEN location)
{
        this.Identifier = identifier;


        this.Latitude = latitude;

        this.Longitude = longitude;

        this.Altitude = altitude;

        this.Location = location;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PositionEN t = obj as PositionEN;
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
