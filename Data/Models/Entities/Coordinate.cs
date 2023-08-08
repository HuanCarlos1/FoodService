using System;

namespace Kamall_foods_server_aspNetCore.Data.Models;

public class Coordinate
{
    public Coordinate()
    {
        Latitude = 0.0;
        Longitude = 0.0;
    }

    public Coordinate(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        if (obj is not Coordinate)
            return false;
        return Latitude == ((Coordinate)obj).Latitude && Longitude == ((Coordinate)obj).Longitude;
    }

    public override string ToString()
    {
        return "Lat: " + Latitude + "\nLon: " + Longitude;
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}