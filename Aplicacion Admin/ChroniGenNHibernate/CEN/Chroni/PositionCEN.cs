

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
 *      Definition of the class PositionCEN
 *
 */
public partial class PositionCEN
{
private IPositionCAD _IPositionCAD;

public PositionCEN()
{
        this._IPositionCAD = new PositionCAD ();
}

public PositionCEN(IPositionCAD _IPositionCAD)
{
        this._IPositionCAD = _IPositionCAD;
}

public IPositionCAD get_IPositionCAD ()
{
        return this._IPositionCAD;
}

public int New_ (double p_latitude, double p_longitude, double p_altitude, int p_location)
{
        PositionEN positionEN = null;
        int oid;

        //Initialized PositionEN
        positionEN = new PositionEN ();
        positionEN.Latitude = p_latitude;

        positionEN.Longitude = p_longitude;

        positionEN.Altitude = p_altitude;


        if (p_location != -1) {
                // El argumento p_location -> Property location es oid = false
                // Lista de oids identifier
                positionEN.Location = new ChroniGenNHibernate.EN.Chroni.LocationEN ();
                positionEN.Location.Identifier = p_location;
        }

        //Call to PositionCAD

        oid = _IPositionCAD.New_ (positionEN);
        return oid;
}

public void Modify (int p_Position_OID, double p_latitude, double p_longitude, double p_altitude)
{
        PositionEN positionEN = null;

        //Initialized PositionEN
        positionEN = new PositionEN ();
        positionEN.Identifier = p_Position_OID;
        positionEN.Latitude = p_latitude;
        positionEN.Longitude = p_longitude;
        positionEN.Altitude = p_altitude;
        //Call to PositionCAD

        _IPositionCAD.Modify (positionEN);
}

public void Destroy (int identifier
                     )
{
        _IPositionCAD.Destroy (identifier);
}

public PositionEN ReadOID (int identifier
                           )
{
        PositionEN positionEN = null;

        positionEN = _IPositionCAD.ReadOID (identifier);
        return positionEN;
}

public System.Collections.Generic.IList<PositionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PositionEN> list = null;

        list = _IPositionCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionByLocation (int p_Location_OID)
{
        return _IPositionCAD.GetPositionByLocation (p_Location_OID);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionByLocationName (string p_Location_name)
{
        return _IPositionCAD.GetPositionByLocationName (p_Location_name);
}
public System.Collections.Generic.IList<ChroniGenNHibernate.EN.Chroni.PositionEN> GetPositionsByLocationPostalCode (string p_Location_postalCode)
{
        return _IPositionCAD.GetPositionsByLocationPostalCode (p_Location_postalCode);
}
}
}
