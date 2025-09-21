using System.Numerics;

namespace Vector;

public class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector();
        v1.X = 3;
        v1.Y = 7;

        Vector v2 = v1;

        Vector result = v1.Add(v2);

        Vector result2 = Vector.Add(v1, v2);

        Vector result3 = v1 + v2;

    }
}

