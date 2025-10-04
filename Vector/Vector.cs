namespace Vector;

public struct Vector
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Magnitude =>  Math.Sqrt(X * X + Y * Y);
    public double Direction => Math.Atan2(Y, X)*180/Math.PI;

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Instance methods 
    public Vector Add(Vector v)
    {
        Vector result = new Vector(this.X + v.X, this.Y + v.Y);
        /*result.X = this.X + v.X;
        result.Y = this.Y + v.Y;*/

        return result;
    }
    public Vector Subtract(Vector v)
    {
        Vector result = new Vector(this.X - v.X, this.Y - v.Y);

        return result;
    }
    public double Dot(Vector v)
    {
        return this.X * v.X + this.Y * v.Y;
    }
    public double AngleBetween(Vector v)
    {
        double dot = this.Dot(v);
        double mag1 = this.Magnitude;
        double mag2 = v.Magnitude;
        double cosTheta = dot / (mag1 * mag2);
        return Math.Acos(cosTheta) * (180.0 / Math.PI);
    }

    public Vector Multiply(double scalar)
    {
        return new Vector(this.X * scalar, this.Y * scalar);
    }

    public Vector Divide(double scalar)
    {
        return new Vector(this.X / scalar, this.Y / scalar);
    }

    public Vector Normalize()
    {
        return Divide(Magnitude);
    }

    // Class (static) methods 
    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector Subtract(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double Dot(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static double AngleBetween(Vector v1, Vector v2)
    {
        return v1.AngleBetween(v2);
    }

     public static Vector Multiply(Vector v, double scalar)
    {
        return v.Multiply(scalar);
    }

    public static Vector Divide(Vector v, double scalar)
    {
        return v.Divide(scalar);
    }

    public static Vector Normalize(Vector v)
    {
        return v.Normalize();
    }

    // Overloaded operators 
    public static Vector operator +(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static Vector operator *(Vector v1, double scalar)
    {
        return v1.Multiply(scalar);
    }

     public static Vector operator /(Vector v1, double scalar)
    {
        return v1.Divide(scalar);
    }

    public override string ToString()
    {
        return "<" + X + ", " + Y + ">";
    }
}